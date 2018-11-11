using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDeFilmes.Api.ViewModel;
using CopaDeFilmes.Application;
using CopaDeFilmes.Domain.Entities;
using CopaDeFilmes.Domain.Entities.Interfaces;
using CopaDeFilmes.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CopaDeFilmes.Api.Controllers
{
    [AllowAnonymous]
    [Route("teste/[controller]")]
    [ApiController]
    public class ChampionshipController : ControllerBase
    {
        private readonly IChampionshipService _championshipService;

        public ChampionshipController(IChampionshipService championshipService)
        {
            _championshipService = championshipService;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<IRound> Post([FromBody] List<MovieViewModel> movies)
        {
            var championshipResult = _championshipService.RunChampionship(movies.Select(x => new Movie()
            {
                Ano = x.ano,
                Id = x.id,
                Nota = x.nota,
                Titulo = x.titulo
            }).ToList<IMovie>());

            var finalMatch = championshipResult.Matches.First();

            return Ok(new List<MoviePodiumViewModel>()
            {
                new MoviePodiumViewModel(1, finalMatch.Winner.Titulo),
                new MoviePodiumViewModel(2, finalMatch.Loser.Titulo),
            });
        }

        [HttpOptions]
        public ActionResult<IRound> Options()
        {
            return Ok();
        }

    }
}
