using IESE.Domain.Entities;
using IESE.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.EntityFramework
{
    public class EFArchiveDocumentRepository : IArchiveDocumentRepository
    {
        private readonly AppDbContext context;
        public EFArchiveDocumentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task DeleteArchiveDocument(Guid id)
        {
            context.ArchiveDocuments.Remove(GetArchiveDocumentById(id));
            context.SaveChanges();
        }

        public ArchiveDocument GetArchiveDocumentById(Guid id)
        {
            return context.ArchiveDocuments.FirstOrDefault(x => x.Id == id);
        }

        public ArchiveDocument GetArchiveDocumentByIdDocument(Guid id, string idUser)
        {
            return context.ArchiveDocuments.FirstOrDefault(x => x.IdDocument == id && x.User.Id == idUser);
        }

        public IQueryable<ArchiveDocument> GetArchiveDocuments()
        {
            return context.ArchiveDocuments;
        }

        public async Task SavArchiveDocument(ArchiveDocument entity)
        {
            try
            {
                await context.ArchiveDocuments.AddAsync(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateArchiveDocument(ArchiveDocument entity)
        {
            try
            {
                context.ArchiveDocuments.Update(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
