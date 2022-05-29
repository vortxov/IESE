using IESE.Domain.Entities;
using IESE.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.EntityFramework
{
    public class EFNumberDocumentRepository : INumberDocumentRepository
    {
        private readonly AppDbContext context;
        public EFNumberDocumentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<NumberDocument> GetNumberDocuments()
        {
            return context.NumberDocuments;
        }

        public async Task UpdateNumberDocument(NumberDocument entity)
        {
            try
            {
                context.NumberDocuments.Update(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
