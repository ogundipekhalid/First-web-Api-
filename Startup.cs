using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Context;
using LinkedOut.Implementations.Repository;
using LinkedOut.Implementations.Services;
using LinkedOut.Interface.Repository;
using LinkedOut.Interface.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace First_web_Api
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
             services.AddCors(c => c
                .AddPolicy("LinkedOut", builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "First_web_Api", Version = "v1" });
            });
            services.AddDbContext<ApplicationContext>(options => options
            .UseMySQL(Configuration.GetConnectionString("LinkedOutConnection")));

            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            
            // services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdvertisementRepository, AdvertisementRepository>();

            // services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IApplicantRepository, ApplicantRepository>();

            // services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();

            // services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();

            // services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IUserRepository, UserRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "First_web_Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("LinkedOut");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
