#region using
using Autofac;
using Business.Extension;
using Core.Extension;
using Core.Utilities.Caching;
using Core.Utilities.Cookie;
using Core.Utilities.DependencyResolvers;
using Core.Utilities.Generate;
using Core.Utilities.Identity;
using Core.Utilities.IoC;
using Core.Utilities.Middlewares;
using Core.Utilities.Quartz;
using Core.Utilities.Swagger;
using DataAccess.Extension;
using DataAccess.Repository.Read;
using DataAccess.Repository.Write;
using DataAccess.UnitOfWork;
using eCommerce.Extensions;
using Entities.Extensions.AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
#endregion
namespace eCommerce
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            CurrentEnvironment = env;
        }
        private IWebHostEnvironment CurrentEnvironment { get; }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //ApiGenerator.GenerateApi(BusinessAssembliesExtension.GetBusinessAssemblies());
            services.AddDbContext(Configuration);
            services.AddCors(options =>
            options.AddPolicy("AllowOrigin", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.AddCustomSwaggerGen();
            services.AutoMapperSettings();
            services.AddHttpContextAccessor();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IWriteDbRepository<>), typeof(WriteDbRepository<>));
            services.AddTransient(typeof(IReadDbRepository<>),typeof(ReadDbRepository<>));
            services.AddRedis(Configuration);
            services.AddIdentitySettings(Configuration);
            services.UseQuartz();
            //services.AddJobList();
            services.ConfigureApplicationCookie(CurrentEnvironment);
            services.AddRazorPages().AddNewtonsoftJson();
            services.AddMvc().AddFluentValidation().ConfigureApiBehaviorOptions(x => x.SuppressModelStateInvalidFilter = true);
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));         
            services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacBusinessModule(AssembliesExtension.GetAllAssemblies()));
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseStatusCodePagesWithReExecute("/Web/Home/Error");
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "eCommerce v1"));
            app.UseCors("AllowOrigin");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                   name: "Plugin",
                   pattern: "{plugin:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToAreaController("Index", "Home", "Web");
            });
            app.UseMiddleware<ExceptionMiddleware>();
            ServiceTool.ServiceProvider = app.ApplicationServices;
        }
    }
}
