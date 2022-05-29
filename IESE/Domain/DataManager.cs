using IESE.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain
{
    public class DataManager //Менеджер для уgравления интерфейсами по управлению бд
    {
        public IWordDocumentRepository WordDocument { get; set; }
        public IWordTemplateRepository WordTepmlate { get; set; }
        public IDocumentCategoryRepository DocumentCategory { get; set; }
        public IArchiveDocumentRepository ArchiveDocument { get; set; }
        public INumberDocumentRepository NumberDocument { get; set; }

        public DataManager(IWordDocumentRepository wordDocumentRepository, IWordTemplateRepository templateRepository,
                            IDocumentCategoryRepository documentCategoryRepository, IArchiveDocumentRepository archiveDocumentRepository, INumberDocumentRepository numberDocumentRepository)
        {
            WordDocument = wordDocumentRepository;
            WordTepmlate = templateRepository;
            DocumentCategory = documentCategoryRepository;
            ArchiveDocument = archiveDocumentRepository;
            NumberDocument = numberDocumentRepository;
        }
    }
}
