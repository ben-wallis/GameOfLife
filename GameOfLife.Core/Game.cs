using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GameOfLife.Core
{
    public class Game
    {
        private ICell[,] _preStepCells;

        public Game()
        {
            
        }

        public ICell[,] Cells { get; private set; }

        public void Initialise(int gameSize)
        {
            Cells = new ICell[gameSize, gameSize];
            for (ushort y = 0; y <= Cells.GetUpperBound(1); y++)
            {
                for (ushort x = 0; x <= Cells.GetUpperBound(0); x++)
                {
                    Cells[x, y] = new Cell { Position = new Position (x,y)};
                }
            }
        }

        public void Step()
        {
            Array.Copy(Cells, _preStepCells, Cells.Length);

            for (ushort y = 0; y < Cells.GetUpperBound(1); y++)
            {
                for (ushort x = 0; x < Cells.GetUpperBound(0); x++)
                {
                    Console.WriteLine("PreProcessing {0},{1} = {2}", x, y, Cells[x,y].Alive ? "Alive" : "Dead");
                    ProcessCell(Cells[x,y]);
                    Console.WriteLine("PostProcessing {0},{1} = {2}", x, y, Cells[x, y].Alive ? "Alive" : "Dead");
                }
            }
        }

        private void ProcessCell(ICell cell)
        {
            var preStepNeighbouringCells = GetPreStepNeighbouringCells(cell);

            //Console.WriteLine("x: {0} y: {1}", cell.Position.X, cell.Position.Y);
            var aliveNeighbours = preStepNeighbouringCells.Count(n => n.Alive);

            if (!cell.Alive)
            {
                if (aliveNeighbours == 3)
                {
                    cell.Alive = true;
                }
            }
            else
            {
                if (aliveNeighbours == 1)
                {
                    cell.Alive = false;
                }
                else if (aliveNeighbours > 4)
                {
                    cell.Alive = false;
                }
            }
        }

        private IEnumerable<ICell> GetPreStepNeighbouringCells(ICell cell)
        {
            var lowX = Math.Max(0, cell.Position.X - 1);
            var lowY = Math.Max(0, cell.Position.Y - 1);

            var highX = Math.Min(_preStepCells.GetUpperBound(0), cell.Position.X + 1);
            var highY = Math.Min(_preStepCells.GetUpperBound(1), cell.Position.Y + 1);

            var retList = new List<ICell>();

            for (var y = lowY; y <= highY; y++)
            {
                for (var x = lowX; x <= highX; x++)
                {
                    if (x != cell.Position.X || y != cell.Position.Y)
                    {
                        retList.Add(_preStepCells[x,y]);
                    }
                }
            }

            return retList;
        }
    }
}
