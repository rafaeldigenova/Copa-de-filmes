using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CopaDeFilmes.Domain.Entities.Interfaces;

namespace CopaDeFilmes.Domain.Entities
{
    public class Match : IMatch
    {
        public IMovie MovieA { get; set; }
        public IMovie MovieB { get; set; }
        public IMovie Winner { get; set; }

        public DateTime? MatchDate { get; set; }

        public Match(IMovie movieA, IMovie movieB)
        {
            MovieA = movieA;
            MovieB = movieB;
        }

        public IMovie PlayMatch()
        {
            Winner = MovieA.GetWinner(MovieB);
            MatchDate = DateTime.Now;

            return Winner;
        }
    }
}
