using IESE.Domain;
using IESE.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IESE.Areas.Admin.Controllers
{
    //[Area("Admin")]
    [Route("[controller]")]
    [ApiController]
    public class AdminCategoryController : ControllerBase
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;

        public AdminCategoryController(DataManager dataManager, IWebHostEnvironment appEnvironment)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
        }
        [HttpGet("{id}")]  //Гет запрос для получения одной категории в бд по id
        public async Task<DocumentCategory> Get(Guid id)
        {
            return dataManager.DocumentCategory.GetDocumentCategoryById(id);
        }
        [HttpGet]
        public async Task<IEnumerable<DocumentCategory>> Get() //Гет запрос для получение всех категорий в бд
        {
            var category = dataManager.DocumentCategory.GetDocumentCatigories().ToList();
            return category;
        }

        [HttpPost]
        public async Task<IActionResult> Post(DocumentCategory category) //Пост запрос для добавления категории в бд
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

             await dataManager.DocumentCategory.SaveDocumentCategory(category);
             return Ok(category);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DocumentCategory category) //Пут запрос для изменения определенной категории
        {
            if (category == null)
            {
                return BadRequest();
            }
            if (!dataManager.DocumentCategory.GetDocumentCatigories().Any(x => x.Id == category.Id))
            {
                return NotFound();
            }
            await dataManager.DocumentCategory.UpdateDocumentCategory(category);
            return Ok(category);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) //Делит запрос для удаления запроса
        {
            var documents = dataManager.DocumentCategory.GetDocumentCategoryById(id).Documents;
            foreach (var item in documents)
            {
                var fileInfo = new FileInfo(_appEnvironment.WebRootPath + item.Path);

                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }

                await dataManager.WordDocument.DeleteWordDocument(item.Id);
            }


            await dataManager.DocumentCategory.DeleteDocumentCategory(id);

            return Ok();
        }

    }
}
