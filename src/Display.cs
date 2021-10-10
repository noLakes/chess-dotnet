using System;
using System.Collections;

namespace Chess
{
    class Display
    {

        public void DrawBoard(Board board)
        {
            ArrayList BoardText = new ArrayList();

            for (int i = 0; i < board.Cells.Length; i++)
            {
                BoardText.Add($"{8 - i} ");

                for (int j = 0; j < board.Cells[i].Length; j++)
                {
                    var piece = board.Cells[i][j].piece;
                    // add empty cell or cell with piece. maybe add another method with switch to get piece text?
                    BoardText.Add( piece is null ? "[ ]" : "[P]");
                }
                BoardText.Add("\n");
            }
        }
    }
}