using IESE.Domain;
using IESE.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IESE.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataManager dataManager;

        public CategoryController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpGet] //Гет запрос для получения всех категорий из бд
        public IEnumerable<DocumentCategory> Get()
        {
            var categorydb = dataManager.DocumentCategory.GetDocumentCatigories().ToList();
            List<DocumentCategory> categories = new List<DocumentCategory>();

            var userRole = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;

            foreach (var category in categorydb)
            {
                foreach (var doc in category.Documents)
                {
                    if(doc.Roles.FirstOrDefault(x => x.Name == userRole) != null || "admin" == userRole)
                    {
                        categories.Add(category);
                        break;
                    }
                }
            }

            return categories;
        }

        [HttpGet("{id}")] //Гет запрос для получения одной катерогии из бд по его id
        public DocumentCategory Get(Guid id)
        {
            return dataManager.DocumentCategory.GetDocumentCategoryById(id);
        }

        //[HttpPost] //Пост запрос для внесения новой категории в бд
        //public async Task<ActionResult<DocumentCategory>> Post(DocumentCategory category) 
        //{
        //    if (category == null) //Если запрос не прислал новую категорию или она пустая то выдает ошибку в запрос
        //    {
        //        return BadRequest();
        //    }

        //    dataManager.DocumentCategory.SaveDocumentCategory(category); //Если все хорошо сохраняем категорию в бд
        //    return Ok(category); //Передаем хороший результат запросу и приклепляем категорию для того чтобы отобразить на странице
        //}


        //[HttpPut("{id}")]
        //public async Task<ActionResult<DocumentCategory>> Put(DocumentCategory category)
        //{
        //    if (category == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (dataManager.DocumentCategory.GetDocumentCategoryById(category.Id) == null)
        //    {
        //        return NotFound();
        //    }

        //    await dataManager.DocumentCategory.UpdateDocumentCategory(category);
            
        //    return Ok(category);
        //}
    }
}
