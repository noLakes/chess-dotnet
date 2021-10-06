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
            
            for (int i = 0; i < Cells.GetLength(0); i ++)
            {
                Cells[i] = new Cell[8];

                for (int j = 0; j < Cells.GetLength(1); j ++)
                {
                    Cells[i][j] = new Cell();
                }
            }

        }

        // Cells is a jagged array of containing 8 sub arrays of 8 cells (8x8)
        private Cell[][] Cells;
    }
}