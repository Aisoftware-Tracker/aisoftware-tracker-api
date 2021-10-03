using Aisoftware.Tracker.Repositories;
using Aisoftware.Tracker.Repositories.Devices.Interfaces;
using Aisoftware.Tracker.Repositories.Devices.Repositories;
using Aisoftware.Tracker.Repositories.Groups.Interfaces;
using Aisoftware.Tracker.Repositories.Groups.Repositories;
using Aisoftware.Tracker.Repositories.Login.Repositories;
using Aisoftware.Tracker.Repositories.Permissions.Interfaces;
using Aisoftware.Tracker.Repositories.Permissions.Repositories;
using Aisoftware.Tracker.Repositories.Reports.Interfaces;
using Aisoftware.Tracker.Repositories.Reports.Repositories;
using Aisoftware.Tracker.Repositories.Sessions.Interfaces;
using Aisoftware.Tracker.Repositories.Users.Interfaces;
using Aisoftware.Tracker.UseCases.Devices.Interfaces;
using Aisoftware.Tracker.UseCases.Devices.UseCases;
using Aisoftware.Tracker.UseCases.Groups.Interfaces;
using Aisoftware.Tracker.UseCases.Groups.UseCases;
using Aisoftware.Tracker.UseCases.Login.UseCases;
using Aisoftware.Tracker.UseCases.Permissions.Interfaces;
using Aisoftware.Tracker.UseCases.Permissions.UseCases;
using Aisoftware.Tracker.UseCases.Reports.Interfaces;
using Aisoftware.Tracker.UseCases.Reports.UseCases;
using Aisoftware.Tracker.UseCases.Session.Interfaces;
using Aisoftware.Tracker.UseCases.Session.UseCases;
using Aisoftware.Tracker.UseCases.Users.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Aisoftware.Tracker.Api
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
            services.AddControllers();

            #region Dependency Injection

            #region Use Cases
            services.AddScoped<IDeviceUseCase, DeviceUseCase>();
            services.AddScoped<IEventUseCase, EventUseCase>();
            services.AddScoped<IGroupUseCase, GroupUseCase>();
            services.AddScoped<INotificationUseCase, NotificationUseCase>();
            services.AddScoped<IPermissionUseCase, PermissionUseCase>();
            services.AddScoped<IPositionUseCase, PositionUseCase>();
            services.AddScoped<IReportUseCase, ReportUseCase>();
            services.AddScoped<ISessionUseCase, SessionUseCase>();
            services.AddScoped<IUserUseCase, UserUseCase>();
            #endregion

            #region Repository
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

            services.AddScoped<IAppConfiguration, AppConfiguration>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
