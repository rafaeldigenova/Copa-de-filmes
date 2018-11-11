using CopaDeFilmes.Domain.Entities;
using CopaDeFilmes.Domain.Entities.Interfaces;
using CopaDeFilmes.Domain.Services;
using System;
using System.Collections.Generic;

namespace CopaDeFilmes.Application
{
    public class ChampionshipService : IChampionshipService
    {
        public IRound RunChampionship(List<IMovie> movies)
        {
            var championship = new Championship();

            championship.Initialize(movies);

            return championship.Play();
        }
    }
}
