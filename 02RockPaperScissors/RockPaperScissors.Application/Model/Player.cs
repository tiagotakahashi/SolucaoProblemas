using System;

namespace RockPaperScissors.Application.DTO
{
    public enum Move
    {
        Invalid = 0,
        Rock = 'R',
        Paper = 'P',
        Scissors = 'S'
    }

    public class Player
    {
        public string Name { get; set; }

        public Move Move { get; set; }
        public Player(string name, string move)
        {
            Name = name;
            //Move moveAux;
            //if (Move.TryParse(move, true, out moveAux))
            //    Move = moveAux;
            char moveAux;
            if (char.TryParse(move, out moveAux))
            {
                Move = (Move)moveAux;
                Move = Enum.IsDefined(typeof(Move), Move) ? Move : Move.Invalid;
            }            
        } 
    }
}
