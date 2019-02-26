using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UnitOfWork.Sample.Domain.Services;
using UnitOfWork.Sample.Services.Implementation;
using UnitOfWork.Sample.IoC.DependencyResolution;
using UnitOfWork.Sample.DataAccess;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Core;
using UnitOfWork.Sample.WebApi.DependencyResolution;

namespace UnitOfWork.Sample.WebApi
{
    public class Startup
    {
        public List<Type> TypesToRegister { get; }


        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;

            IoC.DependencyResolution.IoC.Iniailize(new DefaultRegistry());
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("TargetDatabase")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IDataProvider, DataProvider>();
            services.AddTransient<IArticleService, ArticleService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
