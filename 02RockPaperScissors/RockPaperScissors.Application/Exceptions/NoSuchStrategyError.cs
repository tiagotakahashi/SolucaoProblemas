using System;

namespace RockPaperScissors.Application.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string message) : base(message) { }
    }
}
