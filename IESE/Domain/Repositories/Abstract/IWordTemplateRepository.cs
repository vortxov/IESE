using IESE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.Abstract
{
    public interface IWordTemplateRepository //интерфейсы для CRUD
    {
        IQueryable<WordTemplate> GetWordTemplates();
        WordTemplate GetWordTemplateById(Guid id);
        WordTemplate GetWordTemplateByTemplate(string template);
        void SaveWordTemplate(WordTemplate entity);
        void DeleteWordTemplate(Guid id);
    }
}
