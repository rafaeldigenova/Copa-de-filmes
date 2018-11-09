using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CopaDeFilmes.Domain.Entities.Interfaces;

namespace CopaDeFilmes.Domain.Entities
{
    public class ChampionshipMovie : IChampionshipMovie
    {
        
        public virtual IChampionship Championship { get; set; }
        public virtual IMovie Movie { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int FinalPosition { get; set; }

        public ChampionshipMovie()
        {

        }
    }
}
