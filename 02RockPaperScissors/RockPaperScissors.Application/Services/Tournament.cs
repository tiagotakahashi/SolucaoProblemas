using RockPaperScissors.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Application.Services
{
    public class Tournament
    {
        public Player rps_tournament_winner(List<Player>[][] listRounds)
        {
            var winnerOneRound = new List<Player>();

            foreach (var rounds in listRounds)
            {
                var winnerSecondRound = new List<Player>();
                foreach (var round in rounds)
                {
                    winnerSecondRound.Add(VerifyRoundWinner(round));
                }
                winnerOneRound.Add(VerifyRoundWinner(winnerSecondRound));
            }

            return VerifyRoundWinner(winnerOneRound);
        }

        public Player VerifyRoundWinner(List<Player> players)
        {
            return new Game().rps_game_winner(players);
        }
    }
}
