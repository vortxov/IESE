using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Domain.Repositories.Abstract;
using IESE.Domain.Repositories.EntityFramework;
using IESE.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IESE
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config()); //из файла appsettings.json заносим настройки из  отдела Project в класс конфиг 

            services.AddTransient<IWordDocumentRepository, EFWordDocumentRepository>(); //Создаем классы под интерфейс
            services.AddTransient<IWordTemplateRepository, EFWordTemplateRepository>(); //Создаем классы под интерфейс
            services.AddTransient<IDocumentCategoryRepository, EFDocumentCategoryRepository>(); //Создаем классы под интерфейс 
            services.AddTransient<IArchiveDocumentRepository, EFArchiveDocumentRepository>();
            services.AddTransient<INumberDocumentRepository, EFNumberDocumentRepository>();
            services.AddTransient<DataManager>();//Создаем классы под интерфейс, когда другие классы будут их просить они будут брать эти созданые

            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString)); //Подключаем sql сервер из настроек из класса конфиг созданый ранее

            services.Configure<FormOptions>(options =>
            {
                // Set the limit to 256 MB
                options.MultipartBodyLengthLimit = 268435456; //делаем лимит для загруски файлов, если надо будет просто делай выше, это ограничения для ебанутых людей на модераторах
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();  //Это стандартные настройки куки в браузере, в основном они будут менять вручную в другом классе


            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); }); //Определяем область для админа, скорее всего не работает,
                                                                                      //так как я поменял реализацию проверки из за смены на Rest
            });

            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea")); //Добавляем как раз область для админа все так же уже не нужно,
                                                                                     //если не уберу то спросишь нахуй она осталась
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); // Добавление всех контролеров, то что в скобках выше
                                                                                                              // это настройки области в контролерах
            services.AddControllers(); //Добавление всех областей
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage(); //Настройки для проверки сервера

            app.UseDefaultFiles(); //Помечает что нужно использовать стандартные файлы
            app.UseStaticFiles(); //Помечает что нужно использовать статические файлы в папке wwwroot

            app.UseRouting(); //Использовать маршрутизатор 

            app.UseCookiePolicy(); //использовать куки
            app.UseAuthentication(); // аутентификация
            app.UseAuthorization(); // авторизация

            app.UseEndpoints(endpoints => //Какие использовать страницы и их маршруты 
            {
                endpoints.MapControllers();  //Пометка контролеров сервера
            });
        }
    }
}
