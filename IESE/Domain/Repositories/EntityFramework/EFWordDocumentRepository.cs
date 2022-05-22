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
        public async Task DeleteWordDocument(Guid id)
        {
            context.WordDocuments.Remove(GetWordDocmentById(id));
            context.SaveChanges();
        }

        public WordDocument GetWordDocmentById(Guid id)
        {
            return context.WordDocuments.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<WordDocument> GetWordDocuments()
        {
            return context.WordDocuments;
        }

        public async Task SaveWordDocument(WordDocument entity)
        {
            //    if (context.WordDocuments.FirstOrDefault(x => x.Id == entity.Id) == null)
            //   {
            try
            {
                await context.WordDocuments.AddAsync(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
       //     }
        }

        public async Task UpdateWordDocument(WordDocument entity)
        {
            context.WordDocuments.Update(entity);
            context.SaveChanges();
        }
    }
}
