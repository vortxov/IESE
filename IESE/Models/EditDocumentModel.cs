using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Models
{
    public class EditDocumentModel
    {
        public string Text { get; set; }
        public string Title { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}
