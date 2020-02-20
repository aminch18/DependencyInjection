using DependencyInjection.Contracts;
using DependencyInjection.Entities;
using DependencyInjection.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder();
                //.AddJsonFile("appsettings.json",
                //             optional: false);

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfigurationRoot>(Configuration);
            services.AddSingleton<IWeapon, Gun>();
            services.AddSingleton<IWeapon, ShotGun>();
            services.AddSingleton<IWeapon, MachineGun>();
            services.AddScoped<ISoldierService, SoldierService>();
        }
    }
}
