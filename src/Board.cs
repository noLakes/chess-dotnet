using System;

namespace Chess
{
    public class Board
    {
        public Board()
        {
            FillBoard();
        }

        private void FillBoard()
        {
            Cells = new Cell[8][];
            
            for (int i = 0; i < Cells.Length; i ++)
            {
                Cells[i] = new Cell[8];
                for (int j = 0; j < Cells[i].Length; j ++)
                {
                    Cells[i][j] = new Cell(i, j, null);
                }
            }
        }

        // Cells is a jagged array of containing 8 sub arrays of 8 cells (8x8)
        public readonly Cell[][] Cells;
    }
}