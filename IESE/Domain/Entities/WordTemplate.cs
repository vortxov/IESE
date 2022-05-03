using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Entities
{
    public class WordTemplate //таблица шаблонов
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string ClaimType { get; set; }
    }
}
