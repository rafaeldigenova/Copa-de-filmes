using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CopaDeFilmes.Domain.Entities.Interfaces;
using CopaDeFilmes.Domain.Enums;

namespace CopaDeFilmes.Domain.Entities
{
    public class Round : IRound
    {
        public ICollection<IMovie> Movies { get; set; }
        public ICollection<IMatch> Matches { get; set; }
        public RoundType Type { get; set; }

        public Round()
        {
            Movies = new List<IMovie>();
            Matches = new List<IMatch>();
        }

        public void SetupRound(IEnumerable<IMovie> movies)
        {
            switch (movies.Count())
            {
                case 8:
                    Type = RoundType.QuarterFinals;
                    break;
                case 4:
                    Type = RoundType.SemiFinals;
                    break;
                case 2:
                    Type = RoundType.Final;
                    break;
                default:
                    //Todo: trocar exception por notification pattern (performance)
                    throw new Exception("Número inválido de times");
            }

            Movies = movies.OrderBy(x => x.Titulo).ToList();

            SetupMatches();
        }

        private void SetupMatches()
        {
            for(var i = 0; i <= (Movies.Count - 1)/2; i++)
            {
                Matches.Add(new Match(Movies.ElementAt(i)
                                    , Movies.ElementAt((Movies.Count - 1) - i)));
            }
        }

        public IEnumerable<IMovie> PlayRound()
        {
            return Matches.Select(x => x.PlayMatch());
        }
    }
}
