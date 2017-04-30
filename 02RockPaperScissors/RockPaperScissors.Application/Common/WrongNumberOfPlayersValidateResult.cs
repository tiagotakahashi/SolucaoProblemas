using RockPaperScissors.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Application.DTO;
using RockPaperScissors.Application.Exceptions;

namespace RockPaperScissors.Application.Common
{
    public class WrongNumberOfPlayersValidateResult : IValidateResult
    {
        private List<Player> _listPlayer;

        public WrongNumberOfPlayersValidateResult(List<Player> listPlayer)
        {
            _listPlayer = listPlayer;
        }

        public void Validate()
        {
            if (IsNotValidNumberOfPlayers(_listPlayer))
                throw new WrongNumberOfPlayersError("Wrong number of players. Allowed just two players!");
        }

        public bool IsNotValidNumberOfPlayers(List<Player> _listPlayer)
        {
            return _listPlayer.Count() != 2;
        }
    }
}
