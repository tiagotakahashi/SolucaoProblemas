using RockPaperScissors.Application.DTO;
using RockPaperScissors.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Application.Services
{
    public class Game
    {
        public Player rps_game_winner(List<Player> _listPlayer)
        {
            if (IsValidNumberOfPlayers(_listPlayer))
                throw new WrongNumberOfPlayersError("Wrong number of players. Allowed just two players!");
            else if (IsValidStrategy(_listPlayer))
                throw new NoSuchStrategyError("There is a or more invalid strategy. Allowed strategies are just 'R','S' or 'P'.");
            else
                return PlayerWinner(_listPlayer);
        }

        public bool IsValidNumberOfPlayers(List<Player> _listPlayer)
        {
            return _listPlayer.Count() != 2;
        }

        public bool IsValidStrategy(List<Player> _listPlayer)
        {
            return !(_listPlayer.Where(x => x.Move.Equals("R") || x.Move.Equals("S") || x.Move.Equals("P")).Count().Equals(2));
        }

        public Player PlayerWinner(List<Player> _listPlayer)
        {
            var playerOne = _listPlayer[0];
            var playerTwo = _listPlayer[1];

            return ((playerOne.Move.Equals("R") && playerTwo.Move.Equals("S")) ||
                    (playerOne.Move.Equals("S") && playerTwo.Move.Equals("P")) ||
                    (playerOne.Move.Equals("P") && playerTwo.Move.Equals("R")) ||
                    (playerOne.Move.Equals(playerTwo.Move))) ? playerOne : playerTwo;
        }
    }
}
