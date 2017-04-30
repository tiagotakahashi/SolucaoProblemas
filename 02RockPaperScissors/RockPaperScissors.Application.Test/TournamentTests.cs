using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Application.DTO;
using RockPaperScissors.Application.Services;
using System.Collections.Generic;

namespace RockPaperScissors.Application.Test
{
    [TestClass]
    public class TournamentTests
    {
        [TestMethod]
        public void Richard_Winner_Tournament()
        {
            var listrounds = new List<Player>[2][];
            listrounds[0] = new List<Player>[2]
                            {
                                new List<Player>()
                                {
                                    new Player("Armando", "P"),
                                    new Player("Dave", "S")
                                },
                                new List<Player>()
                                {
                                    new Player("Richard", "R"),
                                    new Player("Michael", "S")
                                }
                            };

            listrounds[1] = new List<Player>[2]
                            {
                                new List<Player>()
                                {
                                    new Player("Allen", "S"),
                                    new Player("Omer", "P")
                                },
                                new List<Player>()
                                {
                                    new Player("David E.", "R"),
                                    new Player("Richard X.", "P")
                                }
                            };

            var tour = new Tournament();

            Assert.AreEqual(tour.rps_tournament_winner(listrounds).Name, "Richard");
        }

        [TestMethod]
        public void Eddy_Winner_Tournament()
        {
            var listrounds = new List<Player>[2][];
            listrounds[0] = new List<Player>[2]
                            {
                                new List<Player>()
                                {
                                    new Player("Armando", "R"),
                                    new Player("Dave", "S")
                                },
                                new List<Player>()
                                {
                                    new Player("Richard", "P"),
                                    new Player("Michael", "S")
                                }
                            };

            listrounds[1] = new List<Player>[2]
                            {
                                new List<Player>()
                                {
                                    new Player("Allen", "R"),
                                    new Player("Eddy", "P")
                                },
                                new List<Player>()
                                {
                                    new Player("David E.", "R"),
                                    new Player("Joshua F.", "P")
                                }
                            };

            var tour = new Tournament();

            Assert.AreEqual(tour.rps_tournament_winner(listrounds).Name, "Eddy");
        }
    }
}
