using ClosedXML.Excel;
using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Areas.Admin.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminUsersController : ControllerBase
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AdminUsersController(DataManager dataManager, IWebHostEnvironment appEnvironment, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        [HttpGet]
        public IEnumerable<ApplicationUser> GetDocumentsUser()
        {
            var users = userManager.Users;
            return users;
        }

        [HttpGet("archive/{id}")]
        public IEnumerable<ArchiveUserModel> GetArchiveUser(string id)
        {
            var user = userManager.Users.Include(x => x.Archives).First(x => x.Id == id);
            List<ArchiveUserModel> archiveUserModels = new List<ArchiveUserModel>();
            foreach (var item in user.Archives)
            {
                archiveUserModels.Add(new ArchiveUserModel()
                {
                    IdArchive = item.Id,
                    Title = item.Title,
                    CategoryTitle = item.CategoryTitle,
                    DateCreate = item.DateCreate,
                    PathPDF = item.PathPDF,
                    FIO = user.Firstname + " " + user.Surname + " " + user.Patronymic
                });
            }
            return archiveUserModels;
        }


        [HttpGet("{id}")]
        public UserUpdateModel GetUserInfo(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;
            var role = userManager.GetRolesAsync(user).Result.FirstOrDefault();
            var userModel = new UserUpdateModel() {
                Firstname = user.Firstname,
                Surname = user.Surname,
                Patronymic = user.Patronymic,
                Specialization = user.Specialization,
                Group = user.Group,
                Course = user.Course,
                BirthDate = user.BirthDate,
                QualificationLevel = user.QualificationLevel,
                DateStartYear = user.DateStartYear,
                DateEndYear = user.DateEndYear,
                Email = user.Email,
                Login = user.UserName,
                FinancialSupport = user.FinancialSupport,
                Faculty = user.Faculty,
                FormOfEducation = user.FormOfEducation,
                Id = id,

            };
            if(role == "admin")
            {
                userModel.Role = "Администратор";
            }
            if (role == "user")
            {
                userModel.Role = "Студент";
            }
            if (role == "teacher")
            {
                userModel.Role = "Преподаватель";
            }
            if (role == "otdelcadrov")
            {
                userModel.Role = "Отдел кадров";
            }
            if (role == "teacheruser")
            {
                userModel.Role = "Преподаватель-Студент";
            }


            return userModel;
        }



        [HttpPost]
        public async Task<IActionResult> PostFile([FromForm] UserFileModel model)
        {
            using (XLWorkbook workBook = new XLWorkbook(model.File.OpenReadStream(), XLEventTracking.Disabled))
            {
                foreach (IXLWorksheet worksheet in workBook.Worksheets)
                {
                    foreach (IXLRow row in worksheet.RowsUsed().Skip(1))
                    {
                        try
                        {
                            ApplicationUser user = new ApplicationUser(); //TODO: БД 
                            user.Surname = row.Cell(1).Value.ToString();
                            user.Firstname = row.Cell(2).Value.ToString();
                            user.Patronymic = row.Cell(3).Value.ToString();
                            user.Course = int.Parse(row.Cell(4).Value.ToString());
                            user.Group = row.Cell(5).Value.ToString();
                            user.FormOfEducation = row.Cell(6).Value.ToString();
                            user.Faculty = row.Cell(7).Value.ToString();
                            user.Specialization = row.Cell(8).Value.ToString();

                            user.QualificationLevel = row.Cell(9).Value.ToString();

                            user.FinancialSupport = row.Cell(10).Value.ToString();
                            user.Email = row.Cell(12).Value.ToString();
                            user.NormalizedEmail = user.Email.ToUpper();
                            user.DateStartYear = int.Parse(row.Cell(13).Value.ToString());
                            user.DateEndYear = int.Parse(row.Cell(14).Value.ToString());
                            user.UserName = row.Cell(15).Value.ToString();
                            user.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, row.Cell(15).Value.ToString());
                            var rolest = row.Cell(16).Value.ToString();
                            IdentityRole role = new IdentityRole();
                            role = roleManager.FindByNameAsync("user").Result;
                            if (rolest == "Студент")
                            {
                                role = roleManager.FindByNameAsync("user").Result;
                            }
                            else if (rolest == "Студент-преподаватель")
                            {
                                role = roleManager.FindByNameAsync("teacheruser").Result;
                            }
                            else if (rolest == "Преподаватель")
                            {
                                role = roleManager.FindByNameAsync("teacher").Result;
                            }

                            user.Roles.Add(role);

                            await userManager.CreateAsync(user);

                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                    }
                }
            }
                return NotFound();
        }
    }
}
