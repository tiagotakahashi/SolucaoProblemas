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
            char moveAux;
            if (char.TryParse(move, out moveAux))
            {
                Move = (Move)moveAux;
                Move = Enum.IsDefined(typeof(Move), Move) ? Move : Move.Invalid;
            }            
        }
        
        public static Player operator *(Player p1, Player p2)
        {            
            switch (p1.Move)
            {
                case Move.Rock:
                    return p2.Move == Move.Scissors ? p1 : p2;
                    break;
                case Move.Paper:
                    return p2.Move == Move.Rock ? p1 : p2;
                    break;
                case Move.Scissors:
                    return p2.Move == Move.Paper ? p1 : p2;
                    break;
                default:
                    return p1;
                    break;
            }
        }

        public static bool operator ==(Player p1, Player p2) {
            return p1.Move == p2.Move;
        }

        public static bool operator !=(Player p1, Player p2)
        {
            return p1.Move != p2.Move;
        }

        public override bool Equals (object obj)
        {
            return this.Move == ((Player)obj).Move;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
