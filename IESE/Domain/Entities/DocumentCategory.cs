using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IESE.Domain.Entities
{
    public class DocumentCategory //таблеца категории документов
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Пустое название")]
        [Display(Name = "NameCategory")]
        public string NameCategory { get; set; }
        [JsonIgnore]
        public List<WordDocument> Documents { get; set; } = new List<WordDocument>();
    }
}
