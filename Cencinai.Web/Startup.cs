using System;
using AutoMapper;
using Cencinai.Data;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Repository;
using Cencinai.Logic.Repository.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cencinai.Web
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
            services.AddControllersWithViews();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(8);
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            services.AddDbContext<CencinaiContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("CencinaiConnection")));

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            services.AddScoped<IUsuarioRepo, UsuarioRepo>();
            services.AddScoped<IProvinciaRepo, ProvinciaRepo>();
            services.AddScoped<ICantonRepo, CantonRepo>();
            services.AddScoped<IDistritoRepo, DistritoRepo>();
            services.AddScoped<IResponsableRepo, ResponsableRepo>();
            services.AddScoped<INiñoRepo, NiñoRepo>();
            services.AddScoped<ICategoriaRepo, CategoriaRepo>();
            services.AddScoped<IEstadoNutricionalRepo, EstadoNutricionalRepo>();
            services.AddScoped<INivelDesarrolloRepo, NivelDesarrolloRepo>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
