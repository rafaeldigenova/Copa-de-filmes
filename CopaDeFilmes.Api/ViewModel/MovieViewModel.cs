using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Api.ViewModel
{
    public class MovieViewModel
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public decimal nota { get; set; }
    }
}
