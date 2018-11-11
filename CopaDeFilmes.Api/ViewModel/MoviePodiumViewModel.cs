using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Api.ViewModel
{
    public class MoviePodiumViewModel
    {
        public int posicao { get; set; }
        public string titulo { get; set; }

        public MoviePodiumViewModel(int posicao, string titulo)
        {
            this.posicao = posicao;
            this.titulo = titulo;
        }
    }
}
