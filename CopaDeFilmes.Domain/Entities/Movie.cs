using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Domain.Entities
{
    public class Movie : IMovie
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public decimal Nota { get; set; }

        public Movie(string id, string titulo, int ano, decimal nota)
        {
            Titulo = titulo;
            Id = id;
            Ano = ano;
            Nota = nota;
        }

        public Movie()
        {

        }

        public IMovie GetWinner(IMovie movie)
        {
            var tempList = new List<IMovie> { this, movie };

            tempList = tempList.OrderByDescending(x => x.Nota).ThenBy(x => x.Titulo).ToList();

            return tempList.First();
        }
    }
}
