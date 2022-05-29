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
            Configuration.Bind("Project", new Config()); //�� ����� appsettings.json ������� ��������� ��  ������ Project � ����� ������ 

            services.AddTransient<IWordDocumentRepository, EFWordDocumentRepository>(); //������� ������ ��� ���������
            services.AddTransient<IWordTemplateRepository, EFWordTemplateRepository>(); //������� ������ ��� ���������
            services.AddTransient<IDocumentCategoryRepository, EFDocumentCategoryRepository>(); //������� ������ ��� ��������� 
            services.AddTransient<IArchiveDocumentRepository, EFArchiveDocumentRepository>();
            services.AddTransient<INumberDocumentRepository, EFNumberDocumentRepository>();
            services.AddTransient<DataManager>();//������� ������ ��� ���������, ����� ������ ������ ����� �� ������� ��� ����� ����� ��� ��������

            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString)); //���������� sql ������ �� �������� �� ������ ������ �������� �����

            services.Configure<FormOptions>(options =>
            {
                // Set the limit to 256 MB
                options.MultipartBodyLengthLimit = 268435456; //������ ����� ��� �������� ������, ���� ���� ����� ������ ����� ����, ��� ����������� ��� �������� ����� �� �����������
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();  //��� ����������� ��������� ���� � ��������, � �������� ��� ����� ������ ������� � ������ ������


            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); }); //���������� ������� ��� ������, ������ ����� �� ��������,
                                                                                      //��� ��� � ������� ���������� �������� �� �� ����� �� Rest
            });

            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea")); //��������� ��� ��� ������� ��� ������ ��� ��� �� ��� �� �����,
                                                                                     //���� �� ����� �� �������� ����� ��� ��������
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); // ���������� ���� �����������, �� ��� � ������� ����
                                                                                                              // ��� ��������� ������� � �����������
            services.AddControllers(); //���������� ���� ��������
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage(); //��������� ��� �������� �������

            app.UseDefaultFiles(); //�������� ��� ����� ������������ ����������� �����
            app.UseStaticFiles(); //�������� ��� ����� ������������ ����������� ����� � ����� wwwroot

            app.UseRouting(); //������������ ������������� 

            app.UseCookiePolicy(); //������������ ����
            app.UseAuthentication(); // ��������������
            app.UseAuthorization(); // �����������

            app.UseEndpoints(endpoints => //����� ������������ �������� � �� �������� 
            {
                endpoints.MapControllers();  //������� ����������� �������
            });
        }
    }
}
