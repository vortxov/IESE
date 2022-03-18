using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : Controller
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;

        public DocumentController(DataManager dataManager, IWebHostEnvironment appEnvironment)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
        }

        [HttpGet("{id}")] //Гет запрос для получения списка всех документов в определенной категории (Категорию определяем через его id)
        public IEnumerable<WordDocument> Get(Guid id)
        {
            return dataManager.DocumentCategory.GetDocumentCategoryById(id).Documents;
        }

        [HttpGet("item/{id}")] //Гет запрос для получения одного документа по его id
        public async Task<WordDocument> GetDocument(Guid id)
        {
            return dataManager.WordDocument.GetWordDocmentById(id);
        }

        [HttpPost] //Пост запрос для скачивания файла
        [Authorize] //TODO: проверить работоспособность 
        public async Task<ActionResult> Post(WordDocument file) //Запрос передает данные о файле который нужно изменить(шаблоны реализовать) и передать клиенту
        {
            try
            {
                file = dataManager.WordDocument.GetWordDocmentById(file.Id); //Ищем файл в бд по id
                var path = _appEnvironment.WebRootPath + file.Path; //Находим путь к файлу 

                var wordHelper = new WordHelper(path); //Передаем конструктору класса для изменения шаблона в ворде путь к файлу и он найдет сам файл
                var temp = new Dictionary<string, string>();

                var listTemplate = file.Templates; //передаем все шаблоны которые есть в файле

                foreach (var item in listTemplate)
                {
                    temp.Add(item.Template, User.FindFirst(x => x.Type == item.ClaimType).Value); //Заполняем список чего нужно изменить в файле
                }
                temp.Add("DATA", DateTime.Now.ToString()); //Добавляем к этому списку еще дату на данный момент 


                path = wordHelper.Process(temp); //И вызываем функцию для изменения шаблонов на текст, передаем функции список необходимых изменений
                                                 //и получаем путь к новому файлу pdf который содержит в себе изменения 

                if (path != null) //Если нет пути значит нет файла и произошла ошибка
                {
                    try
                    {
                        var memory = new MemoryStream();
                        using (var stream = new FileStream(path, FileMode.Open)) //Открываем файл 
                        {
                            await stream.CopyToAsync(memory); //копируем его в память 
                        }
                        memory.Position = 0;
                        var ext = Path.GetExtension(path).ToLowerInvariant(); //Получаем данные о файле 
                        return File(memory, "application/vnd.ms-word", Path.GetFileName(path)); //Передаем файл запросу в приложение ворд и его имя
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException(e.Message); //Если была ошибка то напишет //TODO: Изменить ошибку
                    }
                    finally
                    {
                        System.IO.File.Delete(path); //После передачи файла запросу удаляем его на сервере, чтобы не накапливалась 
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound();
            }
        }

       
    }
}
