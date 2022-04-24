using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IESE.Domain.Entities;
using IESE.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IESE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager; //Управление таблицей с пользователям в бд
        private readonly SignInManager<ApplicationUser> signInManager; //Управление для авторизации
        public AccountController(UserManager<ApplicationUser> userMgr, SignInManager<ApplicationUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) //Пост запрос авторизации
        {
            if (ModelState.IsValid) //Проверка на ошибки, если нет то продолжаем авторизацию
            {
                ApplicationUser user = await userManager.FindByEmailAsync(model.Email); //Ищем в бд пользователя с таким майлом
                if (user != null) //Если такой есть то проверяем дальше
                {
                    await signInManager.SignOutAsync(); //На всякий случай выходим из прошлого аккаунта, это страховка
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, true/*model.RememberMe*/, false); //TODO: кнопка запомнить меня //Проверям пароль и нужно ли запоминать аккаунт и входим в аккаунт(но запоминание еще не работает)
                    if (result.Succeeded) //Если пароль совпадает то проходим дальше
                    {
                        await Authenticate(user); //Функция для создания куки и вносим в браузер 

                        return Ok(model); //Передаем сайту что все хорошо и возращаем этот аккаунт запросу
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.Email), "Неверный email или пароль"); //Если пароль не правильный или нет такого майла то выдаем эту ошибку
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState); //Если какая то еще ошибка то возращаем запросу он эту ошибку обработает

            return NotFound(model); //Если ничего из выше перечисленого то просто нихуя не делаем и возращаем нет информации, но это страховка от бед
        }

        [Authorize]
        [HttpGet("Logout")] //Гет запрос выхода
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync(); //Выходим из аккаунт 
            return Ok(); //И передаем запросу что все хорошо
        }

        [HttpGet("Authorize")] //Гет запрос для проверки авторизации
        public async Task<IActionResult> Authorize()
        {
            if (User.Identity.IsAuthenticated)
                return Ok(); //Если аккаунт авторизирован то передает это
            return NotFound(); //Если нет то ошибка
        }

        [HttpGet("AuthorizeRole")] //Гет запрос на проверку роли
        public async Task<IActionResult> AuthorizeRole()
        {
            if (User.Identity.IsAuthenticated) //Проверяем есть ли авторизация
                if (User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value == "admin") //Если есть авторизация то проверяем роль аккаунт
                    return Ok(); //Если роль аккаунта админ то выдаем это
            return NotFound(); //Если роль user или вообще не авторизирован то ошибка
        }

        private async Task Authenticate(ApplicationUser user) //Функция для создания куки
        {
            //if (userManager.GetRolesAsync(user).Result.FirstOrDefault() == "user") //Проверяем роль аккаунта на обычного пользователя, так как админу не нужно скачивать файл это в правилах должно быть у админов
                                                                                   //так как админы не студенты и у них нет данных в бд которые нужны некоторым документа
          //  {
                var claims = new List<Claim> //Список который должен заносится в куки, тоесть там имя студента факультет и так далее
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("FIO", user.Surname + " " + user.Firstname + " " + user.Patronymic),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, userManager.GetRolesAsync(user).Result.FirstOrDefault()),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                //new Claim("course", user.Course.ToString()),
                //new Claim("group", user.Group),
                //new Claim("faculty", user.Faculty),
                //new Claim("dateend", user.DateEnd.ToString()),
                //new Claim("birthdate", user.BirthDate.ToString()),
                //new Claim("specialization", user.Specialization),
                //new Claim("formofeducation", user.FormOfEducation),
                //new Claim("formofeducation", user.FormOfEducation),
                //new Claim("formofeducation", user.FormOfEducation),
                //new Claim("formofeducation", user.FormOfEducation),
                //new Claim("formofeducation", user.FormOfEducation),
            };


                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookies", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType); // Сами настрой для куки и что в них заносить

                await HttpContext.SignInAsync("Identity.Application", new ClaimsPrincipal(id)); //Имя куки в браузере и данные которые занесутся туда
                                                                                                //TODO: ПЕРЕДЕЛАТЬ КУКИ МАЙКРОСОФТ ЭДЖ, МАКЕТ ДОЛЖЭЕН БЫТЬ С ДАННЫМИ СРАЗУ


          //  }
        }
    }
}