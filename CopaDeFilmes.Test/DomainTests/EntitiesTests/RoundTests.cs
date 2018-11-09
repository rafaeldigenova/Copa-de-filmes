using CopaDeFilmes.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CopaDeFilmes.Test
{
    [TestClass]
    public class RoundTests
    {
        private IMovie _movieBase;

        [TestInitialize]
        public void Initialize()
        {
            _movieBase = new Movie("1", "Deadpool 2", 2018, 8.5m);
        }

        [TestMethod]
        public void AssertUseCase1ReturnExpectedWinners()
        {
            var movies = new List<Movie>()
            {
                new Movie("tt3606756","Os Incríveis 2",2018,8.5m),
                new Movie("tt4881806","Jurassic World: Reino Ameaçado",2018,6.7m),
                new Movie("tt5164214","Oito Mulheres e um Segredo",2018,6.3m),
                new Movie("tt7784604","Hereditário",2018,7.8m),
                new Movie("tt4154756","Vingadores: Guerra Infinita",2018,8.8m),
                new Movie("tt5463162","Deadpool 2",2018,8.1m),
                new Movie("tt3778644","Han Solo: Uma História Star Wars",2018,7.2m),
                new Movie("tt3501632","Thor: Ragnarok",2017,7.9m)
            };

            var expectedWinners = new List<string> { "tt4154756", "tt3501632", "tt3606756", "tt4881806" }
                .OrderBy(x => x);

            var round = new Round();

            round.SetupRound(movies);

            var winners = round.PlayRound();

            var orderedWinnersIds = winners.Select(x => x.Id).OrderBy(x => x);

            Assert.AreEqual(string.Join("",expectedWinners), string.Join("",orderedWinnersIds));
        }

        [TestMethod]
        public void AssertUseCase2ReturnExpectedWinners()
        {
            var movies = new List<Movie>()
            {
                new Movie("tt3606756","Os Incríveis 2",2018,8.5m),
                new Movie("tt4881806","Jurassic World: Reino Ameaçado",2018,6.7m),
                new Movie("tt4154756","Vingadores: Guerra Infinita",2018,8.8m),
                new Movie("tt3501632","Thor: Ragnarok",2017,7.9m)
            };

            var expectedWinners = new List<string> { "tt3606756", "tt4154756" }
                .OrderBy(x => x);

            var round = new Round();

            round.SetupRound(movies);

            var winners = round.PlayRound();

            var orderedWinnersIds = winners.Select(x => x.Id).OrderBy(x => x);

            Assert.AreEqual(string.Join("", expectedWinners), string.Join("", orderedWinnersIds));
        }

        [TestMethod]
        public void AssertUseCase3ReturnExpectedWinners()
        {
            var movies = new List<Movie>()
            {
                new Movie("tt3606756","Os Incríveis 2",2018,8.5m),
                new Movie("tt4154756","Vingadores: Guerra Infinita",2018,8.8m),
            };

            var expectedWinners = new List<string> { "tt4154756" }
                .OrderBy(x => x);

            var round = new Round();

            round.SetupRound(movies);

            var winners = round.PlayRound();

            var orderedWinnersIds = winners.Select(x => x.Id).OrderBy(x => x);

            Assert.AreEqual(string.Join("", expectedWinners), string.Join("", orderedWinnersIds));
        }

    }
}
