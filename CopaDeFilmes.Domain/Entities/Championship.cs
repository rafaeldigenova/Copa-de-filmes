using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CopaDeFilmes.Domain.Entities.Interfaces;

namespace CopaDeFilmes.Domain.Entities
{
    public class Championship : IChampionship
    {
        public ICollection<IMovie> Movies { get; set; }
        public ICollection<IRound> Rounds { get; set; }
        public ICollection<IChampionshipMovie> ChampionshipMovies { get; set; }

        public Championship()
        {
            Movies = new List<IMovie>();
            Rounds = new List<IRound>();
            ChampionshipMovies = new List<IChampionshipMovie>();
        }

        public void Initialize(List<IMovie> movies)
        {
            Movies = movies;
        }

        public IRound Play()
        {
            IRound round;
            List<IMovie> roundWinners = Movies.ToList();

            do
            {
                round = new Round();
                round.SetupRound(roundWinners);
                roundWinners = round.PlayRound().ToList();
                Rounds.Add(round);
            } while (round.Type != Enums.RoundType.Final);

            return round;

        }
    }
}
