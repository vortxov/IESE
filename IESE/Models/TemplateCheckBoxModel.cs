using IESE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Models
{
    public class TemplateCheckBoxModel
    {
        public Guid ID { get; set; }
        public string Display { get; set; }
        public bool IsChecked { get; set; }
    }
}
