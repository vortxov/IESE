using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IESE.Domain.Entities
{
    public class ArchiveDocument
    {
        public Guid Id { get; set; }
        public Guid IdDocument { get; set; }
        public string Title { get; set; }
        public string CategoryTitle { get; set; }
        public string PathWord { get; set; }
        public string PathPDF { get; set; }
        public string DateCreate { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
    }
}
