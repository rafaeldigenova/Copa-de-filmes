using CopaDeFilmes.Domain.Entities;
using CopaDeFilmes.Domain.Entities.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CopaDeFilmes.Test
{
    [TestClass]
    public class MovieTests
    {
        private IMovie _movieBase;

        [TestInitialize]
        public void Initialize()
        {
            _movieBase = new Movie("1", "Deadpool 2", 2018, 8.5m);
        }

        [TestMethod]
        public void AssertThatMovieLosesAgainstBetterRatedMovie()
        {
            var movieToTestAgainst = new Movie("2", "Vingadores: Guerra Infinita", 2018, 9m);

            var winner = _movieBase.GetWinner(movieToTestAgainst);

            Assert.AreEqual(winner.Id, movieToTestAgainst.Id);
        }

        [TestMethod]
        public void AssertThatMovieWinsAgainstBetterRatedMovie()
        {
            var movieToTestAgainst = new Movie("3", "Pantera Negra", 2018, 7.5m);

            var winner = _movieBase.GetWinner(movieToTestAgainst);

            Assert.AreEqual(winner.Id, _movieBase.Id);
        }

        [TestMethod]
        public void AssertThatMovieLosesAgainstEquallyRatedMovieWithAlphabetycalPriority()
        {
            var movieToTestAgainst = new Movie("5", "A Barraca do Beijo", 2018, 8.5m);

            var winner = _movieBase.GetWinner(movieToTestAgainst);

            Assert.AreEqual(winner.Id, movieToTestAgainst.Id);
        }

        [TestMethod]
        public void AssertThatMovieWinsAgainstEquallyRatedMovieWithoutAlphabetycalPriority()
        {
            var movieToTestAgainst = new Movie("5", "Oito Mulheres e um Segredo", 2018, 8.5m);

            var winner = _movieBase.GetWinner(movieToTestAgainst);

            Assert.AreEqual(winner.Id, _movieBase.Id);
        }

    }
}
