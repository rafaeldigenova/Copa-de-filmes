using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CopaDeFilmes.Domain.Entities.Interfaces;

namespace CopaDeFilmes.Domain.Entities
{
    public class Championship : IChampionship
    {
        public ICollection<IRound> Rounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<IChampionshipMovie> ChampionshipMovies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Play()
        {
            
        }
    }
}
