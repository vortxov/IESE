using IESE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.Abstract
{
    public interface IArchiveDocumentRepository
    {
        IQueryable<ArchiveDocument> GetArchiveDocuments();
        ArchiveDocument GetArchiveDocumentById(Guid id);
        ArchiveDocument GetArchiveDocumentByIdDocument(Guid id);
        Task SavArchiveDocument(ArchiveDocument entity);
        Task DeleteArchiveDocument(Guid id);
        Task UpdateArchiveDocument(ArchiveDocument entity);
    }
}
