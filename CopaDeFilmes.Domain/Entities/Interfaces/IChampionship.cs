using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities.Interfaces
{
    public interface IChampionship
    {
        ICollection<IRound> Rounds { get; set; }

        ICollection<IChampionshipMovie> ChampionshipMovies { get; set; }

        void Play();
    }
}
