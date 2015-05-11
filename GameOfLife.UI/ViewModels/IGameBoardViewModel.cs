using GameOfLife.Core;

namespace GameOfLife.UI.ViewModels
{
    internal interface IGameBoardViewModel
    {
        ICell[,] Cells { get; }
        int GameBoardHeight { get; }
    }
}