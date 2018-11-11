using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities.Interfaces
{
    public interface IMovie
    {
        string Id { get; }
        string Titulo { get; }
        int Ano { get; }
        decimal Nota { get; }

        IMovie GetWinner(IMovie movie);
    }
}
