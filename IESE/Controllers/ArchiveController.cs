
using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArchiveController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly DataManager dataManager;

        public ArchiveController(DataManager dataManager, UserManager<ApplicationUser> userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
        }

        [HttpGet] //Гет запрос для получения списка всех документов в определенной категории (Категорию определяем через его id)
        public IEnumerable<ArchiveUserModel> GetDocumentsUser()
        {
            var iduser = User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier).Value;
            var user = userManager.Users.Include(x => x.Archives).First(x => x.Id == iduser);
            List<ArchiveUserModel> archiveUserModels = new List<ArchiveUserModel>();
            foreach (var item in user.Archives)
            {
                archiveUserModels.Add(new ArchiveUserModel()
                {
                    IdArchive = item.Id,
                    Title = item.Title,
                    CategoryTitle = item.CategoryTitle,
                    DateCreate = item.DateCreate,
                    PathPDF = item.PathPDF,
                    FIO = user.Firstname + " " + user.Surname + " " + user.Patronymic
                });
            }
            return archiveUserModels;
        }



        [HttpPost] //Пост запрос для скачивания файла
        public async Task<ActionResult> Post(ArchiveDocument id) //Запрос передает данные о файле который нужно изменить(шаблоны реализовать) и передать клиенту
        {
            try
            {
                var fileArchive = dataManager.ArchiveDocument.GetArchiveDocumentById(id.Id);
                if (fileArchive != null)
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
