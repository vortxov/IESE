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
            var userModel = new UserUpdateModel()
            {
                Firstname = user.Firstname,
                Surname = user.Surname,
                Patronymic = user.Patronymic,
                Specialization = user.Specialization,
                Group = user.Group,
                Course = user.Course,
                BirthDate = user.BirthDate,
                QualificationLevel = user.QualificationLevel,
                DateStartYear = user.DateStart,
                DateEndYear = user.DateEnd,
                Email = user.Email,
                Login = user.UserName,
                FinancialSupport = user.FinancialSupport,
                Faculty = user.Faculty,
                FormOfEducation = user.FormOfEducation,
                Id = id,

            };
            if (role == "admin")
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


        [HttpPost("Edit")]
        public async Task<IActionResult> PostEdit([FromForm] UserUpdateModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);
            if (user == null) return BadRequest(model);

            if(model.Firstname != null)
            {
                user.Firstname = model.Firstname;
            }
            if(model.Specialization != null)
            {
                user.Specialization = model.Specialization;
            }
            if(model.Patronymic != null)
            {
                user.Patronymic = model.Patronymic;
            }
            if(model.Email != null)
            {
                user.Email = model.Email;
            }
            if(model.Login != null)
            {
                user.UserName = model.Login;
            }
            if(model.QualificationLevel != null)
            {
                user.QualificationLevel = model.QualificationLevel;
            }
            if(model.BirthDate != null)
            {
                user.BirthDate = model.BirthDate;
            }
            if(model.DateStartYear != null)
            {
                user.DateStart = model.DateStartYear;
            }
            if(model.DateEndYear != null)
            {
                user.DateEnd = model.DateEndYear;
            }
            if(model.Course != null)
            {
                user.Course = model.Course;
            }
            if(model.Faculty != null)
            {
                user.Faculty = model.Faculty;
            }
            if(model.FinancialSupport != null)
            {
                user.FinancialSupport = model.FinancialSupport;
            }
            if(model.FormOfEducation != null)
            {
                model.FormOfEducation = model.FormOfEducation;
            }
            if(model.Group != null)
            {
                user.Group = model.Group;
            }
            //if(model.Role != null)
            //{
            //    user.Roles = new List<IdentityRole>();
            //    var role = await roleManager.FindByNameAsync(model.Role);
            //    user.Roles.Add(role);
            //}
            if (model.Password != null)
            {
                user.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, model.Password);
            }

            await userManager.UpdateAsync(user);

            return Ok(user);
        }



        [HttpPost]
        public async Task<IActionResult> PostFile([FromForm] UserFileModel model)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            using (XLWorkbook workBook = new XLWorkbook(model.File.OpenReadStream(), XLEventTracking.Disabled))
            {
                foreach (IXLWorksheet worksheet in workBook.Worksheets)
                {
                    foreach (IXLRow row in worksheet.RowsUsed().Skip(1))
                    {
                        try
                        {
                            ApplicationUser user = new ApplicationUser();
                            user.Surname = row.Cell(1).Value.ToString();
                            user.Firstname = row.Cell(2).Value.ToString();
                            user.Patronymic = row.Cell(3).Value.ToString();

                            var course = row.Cell(4).Value.ToString();
                            if (course != "")
                                user.Course = int.Parse(course);

                            var group = row.Cell(5).Value.ToString();
                            if (group != "")
                                user.Group = group;

                            var FormOfEducation = row.Cell(6).Value.ToString();
                            if (FormOfEducation != "")
                                user.FormOfEducation = FormOfEducation;

                            var Faculty = row.Cell(7).Value.ToString();
                            if (Faculty != "")
                                user.Faculty = Faculty;

                            var Specialization = row.Cell(8).Value.ToString();
                            if (Specialization != "")
                                user.Specialization = Specialization;

                            var QualificationLevel = row.Cell(9).Value.ToString();
                            if (QualificationLevel != "")
                                user.QualificationLevel = QualificationLevel;

                            var FinancialSupport = row.Cell(10).Value.ToString();
                            if (FinancialSupport != "")
                                user.FinancialSupport = FinancialSupport;

                            var Email = row.Cell(11).Value.ToString();
                            if (Email != "")
                            {
                                user.Email = Email;
                                user.NormalizedEmail = user.Email.ToUpper();
                            }

                            var DateStartYear = row.Cell(12).Value.ToString();
                            if (DateStartYear != "")
                                user.DateStart = DateTime.Parse(DateStartYear);

                            var DateEndYear = row.Cell(13).Value.ToString();
                            if (DateEndYear != "")
                                user.DateEnd = DateTime.Parse(DateEndYear);

                            var UserName = row.Cell(14).Value.ToString();
                            if (UserName != "")
                                user.UserName = UserName;

                            user.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, row.Cell(15).Value.ToString());

                            var rolest = row.Cell(16).Value.ToString();
                            if (rolest != "")
                            {
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

                                await userManager.AddToRoleAsync(user, role.Name);
                            }

                            await userManager.CreateAsync(user); //TODO: CHECK
                            users.Add(user);

                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                    }
                    return Ok(users);
                }
            }
            return NotFound();
        }
    }
}
