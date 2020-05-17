// <copyright file="Startup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Reporter.BL.Services.Comments;
using Reporter.BL.Services.Departmens;
using Reporter.BL.Services.Faculties;
using Reporter.BL.Services.Persons;
using Reporter.BL.Services.Reports;
using Reporter.BL.Mapper;
using Reporter.DL;
using Reporter.DL.Entities;
using Microsoft.AspNetCore.Identity;
using Reporter.UI.Mapper;

namespace Reporter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ReporterDBContext>();
            services.AddIdentity<PersonEntity, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 8;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireDigit = true;
                opts.Password.RequireUppercase = true;
            }).AddEntityFrameworkStores<ReporterDBContext>().AddDefaultTokenProviders();

            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IFacultiesService, FacultieService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ICommentService, CommentService>();

            services.AddMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");

                //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
