using IESE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.Abstract
{
    public interface INumberDocumentRepository
    {
        IQueryable<NumberDocument> GetNumberDocuments();
        Task UpdateNumberDocument(NumberDocument entity);
    }
}
