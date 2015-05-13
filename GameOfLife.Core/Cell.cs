namespace GameOfLife.Core
{
    public class Cell : ICell
    {
        public bool Alive { get; set; }
        public Position Position { get; set; }
    }
}
