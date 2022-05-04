using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Models
{
    public class AddTemp // Все что в мапке models это модели для контролеров, чтобы запросы могли передавать данные на сервер
    {
        public Guid Id { get; set; }
        public Guid IdCategory { get; set; }
        public List<string> RoleDocument { get; set; }
        [Required(ErrorMessage = "Пустое название")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        public string uploadedFile { get; set; }
        public AddTemp()
        {
          
        }
    }
}
