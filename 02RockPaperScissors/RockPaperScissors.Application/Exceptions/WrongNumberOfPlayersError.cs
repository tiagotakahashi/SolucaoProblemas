using System;

namespace RockPaperScissors.Application.Exceptions
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError(string message) : base(message) { }
    }
}
