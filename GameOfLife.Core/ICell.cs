namespace GameOfLife.Core
{
    public interface ICell
    {
        bool Alive { get; set; }
        Position Position { get; set; }
    }
}