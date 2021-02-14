using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using LojaVirtual.Database;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Sessao;
using LojaVirtual.Repositories;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LojaVirtual
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddHttpContextAccessor();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<INewsletterRepository, NewsletterRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            services.AddScoped<SmtpClient>(options => {
                SmtpClient smtp = new SmtpClient()
                {
                    Host = Configuration.GetValue<string>("Email:ServerMSTP"),
                    Port = Configuration.GetValue<int>("Email:ServerPort"),
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Configuration.GetValue<string>("Email:Username"), Configuration.GetValue<string>("Email:Password")),
                    EnableSsl = true
                };
                return smtp;
            });
            services.AddScoped<GerenciarEmail>();




            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false; 
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMemoryCache(); 
            services.AddSession(opts =>
            {
                opts.Cookie.IsEssential = true; 
            });
            
            

            services.AddScoped<Sessao>();
            services.AddScoped<LoginCliente>();
            services.AddScoped<LoginColaborador>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection));
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                 app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<ValidateAntiForgeryTokenAttribute>();

            app.UseEndpoints(endpoints =>
            {
                    endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                    endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
