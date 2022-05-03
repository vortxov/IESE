using IESE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.Abstract
{
    public interface IDocumentCategoryRepository //интерфейсы для CRUD
    {
        IQueryable<DocumentCategory> GetDocumentCatigories();
        DocumentCategory GetDocumentCategoryById(Guid id);
        Task SaveDocumentCategory(DocumentCategory entity);
        Task DeleteDocumentCategory(Guid id);
        Task UpdateDocumentCategory(DocumentCategory entity);
    }
}
