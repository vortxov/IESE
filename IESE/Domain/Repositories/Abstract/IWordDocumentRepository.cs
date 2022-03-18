using IESE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.Abstract
{
    public interface IWordDocumentRepository //интерфейсы для CRUD
    {
        IQueryable<WordDocument> GetWordDocuments();
        WordDocument GetWordDocmentById(Guid id);
        void SaveWordDocument(WordDocument entity);
        void DeleteWordDocument(Guid id);
    }
}
