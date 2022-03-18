using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace IESE.Controllers
{

    public class HomeController : Controller //Нахуй не нужно, потом удалю если не пригодится 
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(DataManager dataManager, IWebHostEnvironment appEnvironment)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
        }

    }
}