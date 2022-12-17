using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deloitte.Portal.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Deloitte.Portal.DataAccess.Account;
using Deloitte.Portal.Service.UserService;
using Microsoft.AspNetCore.Http;
using System.Net;
using Deloitte.Portal.Model;
using Deloitte.Portal.DataAccess.Test;
using Deloitte.Portal.DataAccess.ClaimFormsData;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.HttpOverrides;

namespace Deloitte.Portal.API
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
            services.AddCors();
            services.AddSwaggerGen();
            services.AddDbContextPool<AppDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));

            services.AddScoped<ISQLAccountRepository, SQLAccountRepository>();
            services.AddScoped<IClaimsFormRepository, ClaimFormsRepository>();
            services.AddScoped<ITestUser, TestUser>();
            services.AddScoped<IServices, Services>();

            services.AddIdentity<IdentityUser,IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredUniqueChars = 1;
            })
                .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddHttpContextAccessor();
            services.AddControllers();
            services.AddDistributedMemoryCache();
            services.AddSession(
                opts =>
                {
                    opts.Cookie.IsEssential = true;
                });
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Deloitte.Portal v1.0");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseHttpsRedirection();
            
            app.UseRouting();
            app.UseCors(options =>
            {
                options.
                AllowAnyOrigin().
                AllowAnyMethod().
                AllowAnyHeader();
            });

            app.UseAuthentication();
            app.UseAuthorization();
         
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
