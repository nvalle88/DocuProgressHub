#region Using

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartAdminSaludsa.Models;
using SmartAdminSaludsa.Models.Utiles;
using SmartAdminSaludsa.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using EnviarCorreo;
using SistemaPedidos.Utils;
using NumberGenerate;
using SistemaPedidos.Utilidades;
using SmartAdmin.Seed.BaseDatos.ContextoBaseDatos;
using SmartAdminSaludsa.Extensores;
using DocuProgreessHub.BaseDatos.ContextoBaseDatos;

// ReSharper disable UnusedMember.Global
// ReSharper disable once ClassNeverInstantiated.Global

#endregion

namespace SmartAdminSaludsa
{
    /// <summary>
    /// Defines the startup instance used by the web host.
    /// </summary>

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
            var id = DateTime.Now.Ticks;
            Log.Logger.Info($"{id} - ConfigureServices");

            var TiempoVidaCookie = Convert.ToDouble(Configuration.GetSection("TiempoVidaCookie").Value);

            Log.Logger.Info($"{id} - TiempoVidaCookie - {TiempoVidaCookie}");



            Log.Logger.Info($"{id} - SQL - {Configuration.GetConnectionString("DefaultConnection")}");

            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            Log.Logger.Info($"{id} - AddDbContext - DefaultConnection");



            //Log.Logger.Info($"{id} - SQL - {Configuration.GetConnectionString("ConnectionBddPrestadores")}");

            //services.AddDbContext<PrestadoresContext>(options =>
            //   options.UseSqlServer(Configuration.GetConnectionString("ConnectionBddPrestadores")));

            //Log.Logger.Info($"{id} - AddDbContext - ConnectionBddPrestadores");

            //services.AddDbContext<SaludsaContext>(options =>
            //   options.UseSqlServer(Configuration.GetConnectionString("ConnectionBddSaludsa")));


            services.AddDbContext<DContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();


            services.AddTransient<IEmailSender, AuthMessageSender>();


            GenerateNumber.Lower = Convert.ToInt32(Configuration.GetSection("LowerRandom").Value);
            GenerateNumber.Top = Convert.ToInt32(Configuration.GetSection("TopRandom").Value);


            Mensaje.AsuntoCorreo = Configuration.GetSection("AsuntoCorreo").Value;

            MailConfig.HostUri = Configuration.GetSection("Smtp").Value;
            MailConfig.PrimaryPort = Convert.ToInt32(Configuration.GetSection("PrimaryPort").Value);
            MailConfig.SecureSocketOptions = Convert.ToInt32(Configuration.GetSection("SecureSocketOptions").Value);
            MailConfig.RequireAuthentication = Convert.ToBoolean(Configuration.GetSection("RequireAuthentication").Value);

            MailConfig.UserName = Configuration.GetSection("UsuarioCorreo").Value;
            MailConfig.Password = Configuration.GetSection("PasswordCorreo").Value;

            MailConfig.EmailFrom = Configuration.GetSection("EmailFrom").Value;
            MailConfig.NameFrom = Configuration.GetSection("NameFrom").Value;


            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 4;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(TiempoVidaCookie);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            Log.Logger.Info($"{id} - IdentityOptions");

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(TiempoVidaCookie);
                // If the LoginPath isn't set, ASP.NET Core defaults 
                // the path to /Account/Login.
                options.LoginPath = "/Account/Login";
                // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;

                options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
            });

            Log.Logger.Info($"{id} - ConfigureApplicationCookie");

            services.AddAuthorization(opts => {
                opts.AddPolicy("Administracion", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Administrador");
                });

                opts.AddPolicy("Gestor", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Gestor","Administrador");
                });

                opts.AddPolicy("Cliente", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Cliente");
                });
            });


            Log.Logger.Info($"{id} - services - AddAuthorization");

            services.AddMvc();

            Log.Logger.Info($"{id} - services - AddMvc");

            services.AddMemoryCache();

            Log.Logger.Info($"{id} - services - AddMemoryCache");

            services.AddSession();

            Log.Logger.Info($"{id} - services - AddSession");

            services.AddDistributedMemoryCache();

            Log.Logger.Info($"{id} - services - AddDistributedMemoryCache");

            services.AddResponseCaching();

            Log.Logger.Info($"{id} - services - AddResponseCaching");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {

            var id = DateTime.Now.Ticks;
            Log.Logger.Info($"{id} - Configure - Init");


            Log.Logger.Info($"{id} - Configure - CultureInfo - Init");
            var defaultCulture = new CultureInfo("es-EC");

            defaultCulture.NumberFormat.NumberDecimalSeparator = ".";
            defaultCulture.NumberFormat.CurrencyDecimalSeparator = ".";

            var culture = defaultCulture.Serializar();
            var numberFormat = defaultCulture.NumberFormat.Serializar();
            var dateTimeFormat = defaultCulture.DateTimeFormat.Serializar();

            Log.Logger.Info($"{id} - culture - {culture}");
            Log.Logger.Info($"{id} - numberFormat - {numberFormat}");
            Log.Logger.Info($"{id} - dateTimeFormat - {dateTimeFormat}");

            Log.Logger.Info($"{id} - Configure - CultureInfo - fin");
            //defaultCulture.DateTimeFormat = DateTimeFormatInfo.CurrentInfo;
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture },
                FallBackToParentCultures = false,
                FallBackToParentUICultures = false,
                RequestCultureProviders = new List<IRequestCultureProvider> { }
            });

            app.UseStatusCodePages();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseSession();

            CreateRoles(serviceProvider);
            CreateUsers(serviceProvider);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseResponseCaching();

            Log.Logger.Info($"{id} - Configure - Fin");
        }


        private void CreateRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] rolesName = new string[] { Perfiles.Administrador, 
                Perfiles.Genencia, 
                Perfiles.Gestor, 
                Perfiles.Cliente
            };
            IdentityResult result;
            foreach (var item in rolesName)
            {
                 var roleExist = roleManager.RoleExistsAsync(item).Result;
                if (!roleExist)
                {
                    //Se crean los roles si no existen en la BD
                    result = roleManager.CreateAsync(new IdentityRole(item)).Result;
                }
            }
        }

        private void CreateUsers(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var usersName = new ApplicationUser[]
            {
                new ApplicationUser { UserName = "nvalle880416@gmail.com", Email = "nvalle880416@gmail.com" },
                 new ApplicationUser { UserName = "administrador@docuprohub.com", Email = "administrador@docuprohub.com" },
                //new ApplicationUser { UserName = "nvalle880416@gmail.com", Email = "nvalle880416@gmail.com" },
            };
            IdentityResult result;
            foreach (var item in usersName)
            {
                var user = userManager.FindByNameAsync(item.UserName).Result;
                if (user == null)
                {
                    //Se crean los usuarios si no existen en la BD
                    switch (item.UserName)
                    {
                        case "nvalle880416@gmail.com": result = userManager.CreateAsync(item, "Administrador2018*").Result; break;
                        case "administrador@docuprohub.com": result = userManager.CreateAsync(item, "Administrador2018*").Result; break;
                        //case "gestor@saludsa.com.ec": result = userManager.CreateAsync(item, "Gestor2021*").Result; break;
                    }

                    switch (item.UserName)
                    {
                        case "nvalle880416@gmail.com": result = userManager.AddToRoleAsync(item, Perfiles.Administrador).Result; break;
                        case "administrador@docuprohub.com": result = userManager.AddToRoleAsync(item, Perfiles.Administrador).Result; break;
                            //case "gestor@bekaert.com": result = userManager.AddToRoleAsync(item, Perfiles.Gestor).Result; break;
                    }
                }

                //Se asignan los roles a los usuarios si no existen en la BD
               
            }
        }
    }
}
