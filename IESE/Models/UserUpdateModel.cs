using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Models
{
    public class UserUpdateModel
    {
        public string Id { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string? FormOfEducation { get; set; }
        public int? Course { get; set; }
        public string? Group { get; set; }
        public string? Faculty { get; set; }
        public DateTime? DateStartYear { get; set; }
        public DateTime? DateEndYear { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Specialization { get; set; }
        public string? QualificationLevel { get; set; }
        public string? FinancialSupport { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
