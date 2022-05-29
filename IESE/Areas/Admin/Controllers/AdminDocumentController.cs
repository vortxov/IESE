using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Models;
using IESE.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace IESE.Areas.Admin.Controllers
{
   // [Area("Admin")]
    [ApiController]
    [Route("[controller]")]
    public class AdminDocumentController : Controller
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;
        private readonly RoleManager<IdentityRole> roleManager;

        public AdminDocumentController(DataManager dataManager, IWebHostEnvironment appEnvironment, RoleManager<IdentityRole> roleManager)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
            this.roleManager = roleManager;
        }
        [HttpGet("category/{id}")]
        public async Task<IEnumerable<WordDocument>> Documents(Guid id) //Гет запрос получения списка документов в какой то категории
        {
            var catrgory = dataManager.DocumentCategory.GetDocumentCategoryById(id);
            return dataManager.DocumentCategory.GetDocumentCategoryById(id).Documents;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Document(Guid id) //Получение одного документа в бд по id
        {
            var wd = dataManager.WordDocument.GetWordDocmentById(id);
            if(wd == null)
            {
                return BadRequest();
            }
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                
                var doc = app.Documents.Open(wd.Path); //Открываем копию
                doc.Activate();
                var text = doc.Content.Text;
                

                app.ActiveDocument.Close(); //Закрываем файл

                var model = new EditDocumentModel();
                model.Title = wd.Title;
                model.Text = text;
                foreach (var item in wd.Roles)
                {
                    model.Roles.Add(item.Name);
                }
                return Ok(model);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet("templates")] // Гет запрос Получение всех возможных шаблонов
        public async Task<IEnumerable<WordTemplate>> Templates()
        {
            return dataManager.WordTepmlate.GetWordTemplates();
        }

        [HttpPost] //Пост запрос для добавления файла на сервер
        public async Task<IActionResult> AddFile([FromForm] AddTemp model)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model != null)
            {
                var helper = new WordHelper(_appEnvironment);
                string path = helper.CreateDocument(model.uploadedFile, model.Title);
                List<IdentityRole> roles = new List<IdentityRole>();

                foreach (var roleModel in model.RoleDocument[0].Split(","))
                {
                    switch (roleModel)
                    {
                        case "Студент":
                            roles.Add(await roleManager.FindByNameAsync("user"));
                            break;
                        case "Преподаватель":
                            roles.Add(await roleManager.FindByNameAsync("teacher"));
                            break;
                        case "Преподаватель-Студент":
                            roles.Add(await roleManager.FindByNameAsync("teacheruser"));
                            break;
                        default:
                            return BadRequest();
                    }
                }


                WordDocument file = new WordDocument { NameFile = model.Title, Path = path, Title = model.Title, DateCreate = DateTime.Now, Roles = roles }; //Создаем класс для бд


                FileInfo fileInfo = new FileInfo(path); //Получаем данные о файле


                Word.Application app = null;
                try
                {
                    app = new Word.Application();
                    Object fileW = fileInfo.FullName;

                    Object missing = Type.Missing;

                    app.Documents.Open(fileW); //Окрываем файл в word приложение
                    app.ActiveDocument.SaveAs2(fileInfo.DirectoryName + "/change.docx"); //Создаем копию файла
                    app.ActiveDocument.Close(); //Закрываем файл

                    app.Documents.Open(fileInfo.DirectoryName + "/change.docx"); //Открываем копию

                    string newFileNamePDF = fileInfo.DirectoryName + "\\" + file.NameFile + ".pdf"; //Пишем путь нового файла в пдф формате
                    app.ActiveDocument.ExportAsFixedFormat(newFileNamePDF, WdExportFormat.wdExportFormatPDF); //Сохраняем новый пдф файл

                    file.PathPDF = "/WordFiles/" + file.NameFile + DateTime.Now.Year + "/" + file.NameFile + ".pdf"; //Записываем его путь в бд 

                    string newFileNameHTM = fileInfo.DirectoryName + "\\" + file.NameFile + ".htm"; //Пишем путь нового файла в html формате
                    app.ActiveDocument.SaveAs2(newFileNameHTM, Word.WdSaveFormat.wdFormatHTML); //Сохраняем новый html файл

                    file.PathHTM = "/WordFiles/" + file.NameFile + DateTime.Now.Year +"/" + file.NameFile + ".htm"; //Записываем его в бд

                    app.ActiveDocument.Close(); //Закрываем файл
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return BadRequest();
                }
                finally
                {
                    System.IO.File.Delete(fileInfo.DirectoryName + "/change.docx"); //Удаляем копию файла 
                    if (app != null)
                        app.Quit(); //Выходим из word приложения
                }

                var category = dataManager.DocumentCategory.GetDocumentCategoryById(model.IdCategory); //Находим категорию в которую добавляем файл

                file.Category = category; //Добавляем категорию в документ чтобы добавить в список документов этой категории

                await dataManager.WordDocument.SaveWordDocument(file); //Сохраняем документ в бд



                return Ok(file); //Выводим в запрос что все хорошо с файлом для визуализации на сервер
            }

            return NotFound();
        }

        [HttpPut] //Пут запрос для изменения документа
        public async Task<IActionResult> UpdateFile([FromForm] AddTemp model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model != null)
            {
                var helper = new WordHelper(_appEnvironment);
                string path = helper.CreateDocument(model.uploadedFile, model.Title);
                List<IdentityRole> roles = new List<IdentityRole>();

                if(model.RoleDocument == null)
                {
                    NotFound();
                }
                foreach (var roleModel in model.RoleDocument[0].Split(","))
                {
                    switch (roleModel)
                    {
                        case "Студент":
                            roles.Add(await roleManager.FindByNameAsync("user"));
                            break;
                        case "Преподаватель":
                            roles.Add(await roleManager.FindByNameAsync("teacher"));
                            break;
                        case "Преподаватель-Студент":
                            roles.Add(await roleManager.FindByNameAsync("teacheruser"));
                            break;
                        default:
                            return BadRequest();
                    }
                }


                WordDocument file = dataManager.WordDocument.GetWordDocmentById(model.Id);
                file.Title = model.Title;
                file.Roles = roles;


                FileInfo fileInfo = new FileInfo(path); //Получаем данные о файле


                Word.Application app = null;
                try
                {
                    app = new Word.Application();
                    Object fileW = fileInfo.FullName;

                    Object missing = Type.Missing;

                    app.Documents.Open(fileW); //Окрываем файл в word приложение
                    app.ActiveDocument.SaveAs2(fileInfo.DirectoryName + "/change.docx"); //Создаем копию файла
                    app.ActiveDocument.Close(); //Закрываем файл

                    app.Documents.Open(fileInfo.DirectoryName + "/change.docx"); //Открываем копию

                    string newFileNamePDF = fileInfo.DirectoryName + "\\" + file.NameFile + ".pdf"; //Пишем путь нового файла в пдф формате
                    app.ActiveDocument.ExportAsFixedFormat(newFileNamePDF, WdExportFormat.wdExportFormatPDF); //Сохраняем новый пдф файл

                    file.PathPDF = "/WordFiles/" + file.NameFile + DateTime.Now.Year + "/" + file.NameFile + ".pdf"; //Записываем его путь в бд 

                    string newFileNameHTM = fileInfo.DirectoryName + "\\" + file.NameFile + ".htm"; //Пишем путь нового файла в html формате
                    app.ActiveDocument.SaveAs2(newFileNameHTM, Word.WdSaveFormat.wdFormatHTML); //Сохраняем новый html файл

                    file.PathHTM = "/WordFiles/" + file.NameFile + DateTime.Now.Year + "/" + file.NameFile + ".htm"; //Записываем его в бд

                    app.ActiveDocument.Close(); //Закрываем файл
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return BadRequest();
                }
                finally
                {
                    System.IO.File.Delete(fileInfo.DirectoryName + "/change.docx"); //Удаляем копию файла 
                    if (app != null)
                        app.Quit(); //Выходим из word приложения
                }

                var category = dataManager.DocumentCategory.GetDocumentCategoryById(model.IdCategory); //Находим категорию в которую добавляем файл

                file.Category = category; //Добавляем категорию в документ чтобы добавить в список документов этой категории

                await dataManager.WordDocument.UpdateWordDocument(file); //Сохраняем документ в бд



                return Ok(file); //Выводим в запрос что все хорошо с файлом для визуализации на сервер
            }

            return NotFound();
        }


        [HttpDelete("{id}")] //Делит запрос
        public async Task<IActionResult> DeleteFile(Guid id)
        {
            //   var file = dataManager.WordDocument.GetWordDocmentById(id); //Находим документ по id 


            dataManager.WordDocument.DeleteWordDocument(id); //Удаляем из бд

            return Ok(id);
        }

        [HttpPost("removeSelect")] //Делит запрос
        public async Task<IActionResult> DeleteSelects([FromForm] List<string> files)
        {
            foreach (var filesId in files[0].Split(","))
            {
                var id = Guid.Parse(filesId);
                // var file = dataManager.WordDocument.GetWordDocmentById(id); //Находим документ по id 

                dataManager.WordDocument.DeleteWordDocument(id); //Удаляем из бд
            }

            return Ok(files);
        }

    }
}
