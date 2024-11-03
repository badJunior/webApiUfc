using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFC.Services.Fighters;

namespace UFC.Services
{
    public static class ServicesExtensions
    {
        public static void RegisterServicesLayerDependencies(this IServiceCollection collection)
        {
           collection.AddSingleton<IFightersRepository, InMemoryFightersRepository>();
          collection.AddTransient<IFightersService, FightersService>();
        }
    }

    
}
