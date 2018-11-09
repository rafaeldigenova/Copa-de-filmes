using CopaDeFilmes.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities.Interfaces
{
    public interface IRound
    {
        ICollection<IMovie> Movies { get; set; }
        ICollection<IMatch> Matches { get; set; }
        RoundType Type { get; set; }

        IEnumerable<IMovie> PlayRound();

        void SetupRound(IEnumerable<IMovie> movies);
    }
}
