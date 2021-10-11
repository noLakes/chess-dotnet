using System;
using System.Collections;

namespace Chess
{
    class Display
    {

        public static void DrawBoard(Board board)
        {
            ArrayList Text = RenderBoard(board);   

            foreach(string line in Text)
            {
                Console.Write(line);
            }
        }

        private static ArrayList RenderBoard(Board board)
        {
            ArrayList BoardText = new ArrayList();

            for (int i = 0; i < board.Cells.Length; i++)
            {
                BoardText.Add($"{8 - i} ");

                for (int j = 0; j < board.Cells[i].Length; j++)
                {
                    var piece = board.Cells[i][j].piece;
                    BoardText.Add( piece is null ? "[ ]" : piece.GetSymbol());
                }
                BoardText.Add("\n");
            }

            BoardText.Add("   a  b  c  d  e  f  g  h\n");
            return BoardText;
        }
    }
}