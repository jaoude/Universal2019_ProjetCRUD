using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Helpers;
using MultiGrain.BLL.Services;
using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Repositories;
using MultiGrain.DAL.UnitOfWork;
using NLog.Extensions.Logging;
using NLog.Web;
using System.IO;

namespace MultiGrain.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<MultiGrainDbContext>(
                option => option.UseSqlServer(Configuration.GetConnectionString("MultiGrainConnectionString")
            ));
            services.AddIdentityCore<IdentityUser>().AddEntityFrameworkStores<MultiGrainDbContext>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IInstitutionRepository, InstitutionRepository>();
            services.AddTransient<IFileDocumentRepository, FileDocumentRepository>();
        

            services.AddTransient<IServiceBase, ServiceBase>();
            services.AddTransient<IAutoMapperService, AutoMapperService>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IFileDocumentService, FileDocumentService>();
            services.AddCors();
            services.AddLogging();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [System.Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(options =>options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints( endpoints => { endpoints.MapControllers(); });

            //NLog
            loggerFactory.AddNLog();
            var dir = new DirectoryInfo("NLog");
            var path = Path.Combine(dir.FullName, "", $"NLog.{env.EnvironmentName}.config");
            env.ConfigureNLog(path);
        }
    }
}
