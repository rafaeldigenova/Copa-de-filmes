using CopaDeFilmes.Domain.Entities;
using CopaDeFilmes.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Services
{
    public interface IChampionshipService
    {
        IRound RunChampionship(List<IMovie> movies);
    }
}
