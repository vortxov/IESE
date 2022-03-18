using IESE.Domain.Entities;
using IESE.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.EntityFramework //функции CRUD
{
    public class EFWordDocumentRepository : IWordDocumentRepository
    {
        private readonly AppDbContext context;
        public EFWordDocumentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteWordDocument(Guid id)
        {
            context.WordDocuments.Remove(GetWordDocmentById(id));
            context.SaveChanges();
        }

        public WordDocument GetWordDocmentById(Guid id)
        {
            return context.WordDocuments.Include(x => x.Templates).FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<WordDocument> GetWordDocuments()
        {
            return context.WordDocuments;
        }

        public void SaveWordDocument(WordDocument entity)
        {
            if (context.WordDocuments.FirstOrDefault(x => x.Id == entity.Id) == null)
            {
                context.WordDocuments.Add(entity);
                context.SaveChanges();
            }
        }
    }
}
