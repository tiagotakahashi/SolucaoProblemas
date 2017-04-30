namespace RockPaperScissors.Application.DTO
{
    public class Player
    {
        public string Name { get; set; }

        public string Move { get; set; }
        public Player(string name, string move)
        {
            Name = name;
            Move = move;
        } 
    }
}
