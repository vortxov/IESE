using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IESE.Domain.Entities
{
    public class WordDocument //таблица документов
    {
        public Guid Id { get; set; }
        public string NameFile { get; set; }
        public string Path { get; set; }
        public string PathPDF { get; set; }
        public string PathHTM { get; set; }
        public DateTime DateCreate { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public List<DocumentCategory> Categories { get; set; } = new List<DocumentCategory>();
    }
}
