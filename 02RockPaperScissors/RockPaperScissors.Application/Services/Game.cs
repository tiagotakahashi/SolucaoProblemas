using RockPaperScissors.Application.Common;
using RockPaperScissors.Application.Common.Interfaces;
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
        private IValidator validator;

        public Player rps_game_winner(List<Player> _listPlayer)
        {
            validator = new Validator();
            validator.Add(new WrongNumberOfPlayersValidateResult(_listPlayer));
            validator.Add(new NoSuchStrategyValidateResult(_listPlayer));
            validator.Validate();

            return PlayerWinner(_listPlayer);
        }        

        public Player PlayerWinner(List<Player> _listPlayer)
        {
            var playerOne = _listPlayer[0];
            var playerTwo = _listPlayer[1];


            if (playerOne == playerTwo)
                return playerOne;

            return playerOne * playerTwo;
        }
    }
}
