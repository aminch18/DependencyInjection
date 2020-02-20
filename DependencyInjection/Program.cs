using DependencyInjection.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var soldierService = serviceProvider.GetService<ISoldierService>();
            soldierService.Shoot();

        }
    }
   
}
