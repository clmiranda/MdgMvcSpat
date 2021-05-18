using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace ModalidadGradoSpat
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
            //services.AddControllersWithViews();
            //services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddHttpContextAccessor();
            //services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddCors();
            services.AddMvc();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });
            //services.AddDistributedMemoryCache();
            //services.AddSession();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
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
                app.UseExceptionHandler("/Home/Error/{0}");
                app.UseStatusCodePagesWithRedirects("/Home/Error/{0}");
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            }
            app.UseHsts();
            app.UseSession();
            app.Use(async (context, next) =>
            {
                var JWToken = context.Session.GetString("JWToken");
                if (!string.IsNullOrEmpty(JWToken))
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + JWToken);
                }
                await next();
            });
            app.UseHttpsRedirection();
            //app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "AreaAdministracion",
                //    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                                endpoints.MapAreaControllerRoute(
            name: "AreaAdministracionMascotas",
            areaName: "AdministracionMascotas",
            pattern: "AdministracionMascotas/{controller=}/{action=}/{id?}");

                endpoints.MapAreaControllerRoute(
name: "AreaAdministracionAdopciones",
areaName: "AdministracionAdopciones",
pattern: "AdministracionAdopciones/{controller=}/{action=}/{id?}");

                endpoints.MapAreaControllerRoute(
name: "AreaAdministracionCuentas",
areaName: "AdministracionCuentas",
pattern: "AdministracionCuentas/{controller=}/{action=}/{id?}");

                endpoints.MapAreaControllerRoute(
name: "AreaAdministracionReportes",
areaName: "AdministracionReportes",
pattern: "AdministracionReportes/{controller=}/{action=}/{id?}");

                endpoints.MapAreaControllerRoute(
name: "AreaAdministracionSeguimientos",
areaName: "AdministracionSeguimientos",
pattern: "AdministracionSeguimientos/{controller=}/{action=}/{id?}");

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Adopciones}/{action=Index}/{id?}");
            });
        }
    }
}
