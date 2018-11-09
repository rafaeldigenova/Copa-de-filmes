using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities.Interfaces
{
    public interface IMatch
    {
        IMovie MovieA { get; set; }
        IMovie MovieB { get; set; }

        IMovie Winner { get; set; }

        IMovie PlayMatch();
    }
}
