using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Application.Exceptions;
using RockPaperScissors.Application.Services;
using RockPaperScissors.Application.DTO;
using System.Collections.Generic;

namespace RockPaperScissors.Application.Test
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Error_Wrong_Number_Of_Players_3_Players()
        {
            new Game().rps_game_winner(new List<Player>()
                                        {
                                            new Player("Mark","S"),
                                            new Player("Dimy","R"),
                                            new Player("Andy","P")
                                        });
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Error_Wrong_Number_Of_Players_1_Player()
        {
            new Game().rps_game_winner(new List<Player>()
                                       {
                                           new Player("Andy","P")
                                       });
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError))]
        public void Error_No_Such_Strategy_CaseInsensitive()
        {
            new Game().rps_game_winner(new List<Player>()
                                        {
                                            new Player("Mark","f"),
                                            new Player("Dimy","S")
                                        });
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError))]
        public void Error_No_Such_Strategy_WrongStrategySelected()
        {
            new Game().rps_game_winner(new List<Player>()
                                        {
                                            new Player("Mark","A"),
                                            new Player("Dimy","R")
                                        });
        }

        [TestMethod]
        public void Players_Same_Move()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "R"), new Player("Dimy", "R") }).Name, "Mark");
        }

        [TestMethod]
        public void PlayerOne_Winner_Rock()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "R"), new Player("Dimy", "S") }).Name, "Mark");
        }

        [TestMethod]
        public void PlayerOne_Winner_Scissors()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "S"), new Player("Dimy", "P") }).Name, "Mark");
        }

        [TestMethod]
        public void PlayerOne_Winner_Paper()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "P"), new Player("Dimy", "R") }).Name, "Mark");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Rock()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "S"), new Player("Dimy", "R") }).Name, "Dimy");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Scissors()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "P"), new Player("Dimy", "S") }).Name, "Dimy");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Paper()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<Player>() { new Player("Mark", "R"), new Player("Dimy", "P") }).Name, "Dimy");
        }
    }
}
