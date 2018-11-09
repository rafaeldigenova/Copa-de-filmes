using CopaDeFilmes.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities.Interfaces
{
    public interface IRound
    {
        ICollection<IMatch> Matches { get; set; }
        RoundType Type { get; set; }

        IEnumerable<IMovie> PlayRound();
    }
}
