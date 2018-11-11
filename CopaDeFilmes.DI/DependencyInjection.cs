using CopaDeFilmes.Application;
using CopaDeFilmes.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.DI
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IChampionshipService, ChampionshipService>();
        }
    }
}
