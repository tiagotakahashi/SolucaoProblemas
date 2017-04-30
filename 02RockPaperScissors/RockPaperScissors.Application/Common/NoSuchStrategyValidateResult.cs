using System;
using System.Collections.Generic;
using RockPaperScissors.Application.Common.Interfaces;
using RockPaperScissors.Application.DTO;
using System.Linq;
using RockPaperScissors.Application.Exceptions;

namespace RockPaperScissors.Application.Common
{
    public class NoSuchStrategyValidateResult : IValidateResult
    {
        private List<Player> _listPlayer;

        public NoSuchStrategyValidateResult(List<Player> listPlayer)
        {
            _listPlayer = listPlayer;
        }

        public void Validate()
        {
            if (IsNotValidStrategy(_listPlayer))
                throw new NoSuchStrategyError("There is a or more invalid strategy. Allowed strategies are just 'R','S' or 'P'.");
        }

        public bool IsNotValidStrategy(List<Player> _listPlayer)
        {
            return (_listPlayer.Where(x => x.Move.Equals(Move.Invalid)).Count() >= 1);
        }
    }
}
