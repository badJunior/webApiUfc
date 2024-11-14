using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFC.Services.Fighters;
using UFC.Services.Cards;
using UFC.Services.Winners;

namespace UFC.Services
{
    public static class ServicesExtensions
    {
        public static void RegisterServicesLayerDependencies(this IServiceCollection collection)
        {
           collection.AddSingleton<IFightersRepository, InMemoryFightersRepository>();
           collection.AddTransient<IFightersService, FightersService>();
           collection.AddSingleton<ICardsRepository, InMemoryCardsRepository>();
           collection.AddTransient<ICardsService, CardsService>();
           collection.AddTransient<IWinnersService, WinnsersService>();
        }

    }

    
}
