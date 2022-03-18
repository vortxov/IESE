using IESE.Domain.Entities;
using IESE.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.EntityFramework //функции CRUD
{
    public class EFWordTemplateRepository : IWordTemplateRepository
    {
        private readonly AppDbContext context;
        public EFWordTemplateRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteWordTemplate(Guid id)
        {
            context.Remove(new WordTemplate() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<WordTemplate> GetWordTemplates()
        {
            return context.WordTemplates;
        }

        public WordTemplate GetWordTemplateById(Guid id)
        {
            return context.WordTemplates.FirstOrDefault(x => x.Id == id);
        }

        public WordTemplate GetWordTemplateByTemplate(string template)
        {
            return context.WordTemplates.FirstOrDefault(x => x.Template == template);
        }

        public void SaveWordTemplate(WordTemplate entity)
        {
            if (context.WordDocuments.FirstOrDefault(x => x.Id == entity.Id) == null)
            {
                context.WordTemplates.Add(entity);
                context.SaveChanges();
            }
        }
    }
}
