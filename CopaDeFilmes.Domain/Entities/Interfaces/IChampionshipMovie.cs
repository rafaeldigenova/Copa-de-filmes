using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities.Interfaces
{
    public interface IChampionshipMovie
    {
        IChampionship Championship { get; set; }
        IMovie Movie { get; set; }

        int Wins { get; set; }
        int Losses { get; set; }

        int FinalPosition { get; set; }
    }
}
