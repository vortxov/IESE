using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IESE.Domain.Entities
{
    public class ApplicationUser : IdentityUser //Таблица user
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string? FormOfEducation { get; set; }
        public int? Course { get; set; }
        public string? Group { get; set; }
        public string? Faculty { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Specialization { get; set; }


    }
}
