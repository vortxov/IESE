using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Text;
using Cyriller;

namespace IESE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;
        public CyrName CyrName { get; protected set; } = new CyrName();

        public DocumentController(DataManager dataManager, IWebHostEnvironment appEnvironment, UserManager<ApplicationUser> userManager)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
            this.userManager = userManager;
        }

        [HttpGet("{id}")] //Гет запрос для получения списка всех документов в определенной категории (Категорию определяем через его id)
        public IEnumerable<WordDocument> Get(Guid id)
        {
            return dataManager.DocumentCategory.GetDocumentCategoryById(id).Documents;
        }

        [HttpGet("item/{id}")] //Гет запрос для получения одного документа по его id
        public async Task<ArchiveDocument> GetDocument(Guid id)
        {
            var fileArchive = dataManager.ArchiveDocument.GetArchiveDocumentByIdDocument(id, User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier).Value);
            if (fileArchive == null)
            {
                var file = dataManager.WordDocument.GetWordDocmentById(id);
                var path = file.Path; //Находим путь к файлу 

                var wordHelper = new WordHelper(path); //Передаем конструктору класса для изменения шаблона в ворде путь к файлу и он найдет сам файл
                var temp = new Dictionary<string, string>();

                var listTemplate = dataManager.WordTepmlate.GetWordTemplates();
                var user = await userManager.FindByIdAsync(User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier).Value);

                foreach (var item in listTemplate)
                {
                    var res = "";
                    foreach (var type in item.ClaimType.Split(":"))
                    {
                        switch (type)
                        {
                            case "fm":
                                res += user.Firstname + " " + user.Surname + " " + user.Patronymic;
                                break;

                            case "cr":
                                if (user.Course != null)
                                {
                                    res += user.Course;
                                }
                                break;

                            case "fr":
                                if (user.Faculty != null)
                                {
                                    res += user.Faculty;
                                }
                                break;

                            case "date":
                                    res += DateTime.Now.ToShortDateString();
                                break;

                            case "fred":
                                if (user.FormOfEducation != null)
                                {
                                    res += user.FormOfEducation;
                                }
                                break;

                            case "gr":
                                if (user.Group != null)
                                {
                                    res += user.Group;
                                }
                                break;

                            case "sz":
                                if (user.Specialization != null)
                                {
                                    res += user.Specialization;
                                }
                                break;

                            case "fs":
                                if (user.FinancialSupport != null)
                                {
                                    res += user.FinancialSupport;
                                }
                                break;

                            case "dsy":
                                if (user.DateStart != null)
                                {
                                    res += user.DateStart;
                                }
                                break;

                            case "dey":
                                if (user.DateEnd != null)
                                {
                                    res += user.DateEnd;
                                }
                                break;

                            case "bd":
                                if (user.BirthDate != null)
                                {
                                    res += user.BirthDate?.ToShortDateString();
                                }
                                break;

                            case "ql":
                                if (user.QualificationLevel != null)
                                {
                                    res += user.QualificationLevel;
                                }
                                break;

                            case "num":
                                var num = dataManager.NumberDocument.GetNumberDocuments().FirstOrDefault();
                                res += num.Number.ToString();
                                num.Number++;
                                dataManager.NumberDocument.UpdateNumberDocument(num);
                                break;

                            case "fiod":
                                var sr = user.Firstname + " " + user.Surname + " " + user.Patronymic;
                                StringBuilder sb = new StringBuilder();

                                CyrResult result = this.CyrName.Decline(sr, Cyriller.Model.GendersEnum.Undefined, false);
                                res += result.Get(Cyriller.Model.CasesEnum.Dative);
                                break;

                            default:
                                break;
                        }
                    }
                    temp.Add(item.Template, res); //Заполняем список чего нужно изменить в файле
                }
                string pathArchive = _appEnvironment.WebRootPath + "\\Archive\\" + user.Group + user.Firstname + "\\";

                path = wordHelper.Process(temp, pathArchive); //И вызываем функцию для изменения шаблонов на текст, передаем функции список необходимых изменений
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

                        var arhiveDocument = new ArchiveDocument()
                        {
                            PathPDF = path,
                            PathWord = path.Split(".pdf")[0] + ".docx",
                            DateCreate = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString(),
                            IdDocument = file.Id,
                            Title = file.Title,
                            CategoryTitle = file.Category.NameCategory,
                            User = user
                        };

                        await dataManager.ArchiveDocument.SavArchiveDocument(arhiveDocument);

                        return arhiveDocument; //Передаем файл запросу в приложение ворд и его имя
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException(e.Message); //Если была ошибка то напишет //TODO: Изменить ошибку
                    }
                }
            }

            return fileArchive;
        }

        [HttpPost] //Пост запрос для скачивания файла
        [Authorize] //TODO: проверить работоспособность 
        public async Task<ActionResult> Post(WordDocument file) //Запрос передает данные о файле который нужно изменить(шаблоны реализовать) и передать клиенту
        {
            try
            {
                file = dataManager.WordDocument.GetWordDocmentById(file.Id); //Ищем файл в бд по id
                var fileArchive = dataManager.ArchiveDocument.GetArchiveDocumentByIdDocument(file.Id, User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier).Value);

                if(fileArchive != null)
                {
                    try
                    {
                        var memory = new MemoryStream();
                        using (var stream = new FileStream(fileArchive.PathPDF, FileMode.Open)) //Открываем файл 
                        {
                            await stream.CopyToAsync(memory); //копируем его в память 
                        }
                        memory.Position = 0;
                        var ext = Path.GetExtension(fileArchive.PathPDF).ToLowerInvariant(); //Получаем данные о файле 
                        return File(memory, "application/vnd.ms-word", Path.GetFileName(fileArchive.PathPDF)); //Передаем файл запросу в приложение ворд и его имя
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException(e.Message); //Если была ошибка то напишет //TODO: Изменить ошибку
                    }
                }

                var path = file.Path; //Находим путь к файлу 

                var wordHelper = new WordHelper(path); //Передаем конструктору класса для изменения шаблона в ворде путь к файлу и он найдет сам файл
                var temp = new Dictionary<string, string>();

                var listTemplate = dataManager.WordTepmlate.GetWordTemplates();
                var user = await userManager.FindByIdAsync(User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier).Value);

                foreach (var item in listTemplate)
                {
                    var res = "";
                    foreach (var type in item.ClaimType.Split(":"))
                    {
                        switch (type)
                        {
                            case "fm":
                                res += user.Firstname + " " + user.Surname + " " + user.Patronymic;
                                break;
                            default:
                                break;
                        }
                    }
                    temp.Add(item.Template, res); //Заполняем список чего нужно изменить в файле
                }
                temp.Add("DATA", DateTime.Now.ToString()); //Добавляем к этому списку еще дату на данный момент 
                string pathArchive = _appEnvironment.WebRootPath + "\\Archive\\" + user.Group + user.Firstname + "\\";

                path = wordHelper.Process(temp, pathArchive); //И вызываем функцию для изменения шаблонов на текст, передаем функции список необходимых изменений
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

                        var arhiveDocument = new ArchiveDocument()
                        {
                            PathPDF = path,
                            PathWord = path.Split(".pdf")[0] + ".docx",
                            DateCreate = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString(),
                            IdDocument = file.Id,
                            Title = file.Title,
                            CategoryTitle = file.Category.NameCategory,
                            User = user
                        };

                        await dataManager.ArchiveDocument.SavArchiveDocument(arhiveDocument);

                        return File(memory, "application/vnd.ms-word", Path.GetFileName(path)); //Передаем файл запросу в приложение ворд и его имя
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException(e.Message); //Если была ошибка то напишет //TODO: Изменить ошибку
                    }
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound();
            }
        }

       
    }
}
