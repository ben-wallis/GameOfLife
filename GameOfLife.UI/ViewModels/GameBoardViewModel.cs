using System.Windows.Controls;

using GameOfLife.Core;

namespace GameOfLife.UI.ViewModels
{
    internal class GameBoardViewModel : IGameBoardViewModel
    {
        public GameBoardViewModel()
        {
            Cells = new ICell[50,50];
            for (var y = 0; y <= Cells.GetUpperBound(1); y++)
            {
                for (var x = 0; x <= Cells.GetUpperBound(0); x++)
                {
                    Cells[x, y] = new Cell();
                }
            }
        }

        public ICell[,] Cells { get; private set; }

        public int GameBoardHeight
        {
            get
            {
                return Cells.GetUpperBound(1);
            }
        }
    }
}
