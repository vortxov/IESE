using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Models
{
    public class ArchiveUserModel
    {
        public Guid IdArchive { get; set; }
        public string FIO { get; set; }
        public string PathPDF { get; set; }
        public string DateCreate { get; set; }
        public string Title { get; set; }
        public string CategoryTitle { get; set; }
    }
}
