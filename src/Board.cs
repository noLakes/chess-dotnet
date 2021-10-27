using System;
using System.Collections;

namespace Chess
{
    class Board
    {
        public Board()
        {
            SetBoard();
        }
        private void SetBoard()
        {
            Cells = new Cell[8][];

            for (int row = 0; row < Cells.Length; row++)
            {
                Cells[row] = new Cell[8];

                for (int col = 0; col < Cells[row].Length; col++)
                {
                    switch (row)
                    {
                        case 0:
                        case 7:
                            switch (col)
                            {
                                case 0:
                                case 7:
                                    Cells[row][col] = new Cell(row, col, new Rook(row == 0));
                                    break;
                                case 1:
                                case 6:
                                    Cells[row][col] = new Cell(row, col, new Knight(row == 0));
                                    break;
                                case 2:
                                case 5:
                                    Cells[row][col] = new Cell(row, col, new Bishop(row == 0));
                                    break;
                                case 3:
                                    Cells[row][col] = new Cell(row, col, new Queen(row == 0));
                                    break;
                                case 4:
                                    Cells[row][col] = new Cell(row, col, new King(row == 0));
                                    break;
                            }
                            break;
                        case 1:
                        case 6:
                            Cells[row][col] = new Cell(row, col, new Pawn(row == 1));
                            break;
                        default:
                            Cells[row][col] = new Cell(row, col, null);
                            break;

                    }
                }
            }
        }

        public static bool IsLegalMove(Move move)
        {
            // dummy
            return true;
        }
        public Cell GetCell(int row, int col)
        {
          return Cells[row][col];
        }

        public ArrayList Render()
        {
            ArrayList BoardText = new ArrayList();

            for (int i = 0; i < Cells.Length; i++)
            {
                BoardText.Add($"{8 - i} ");

                for (int j = 0; j < Cells[i].Length; j++)
                {
                    var piece = Cells[i][j].GetPiece();
                    BoardText.Add( piece is null ? "[ ]" : $"[{piece.GetSymbol()}]");
                }
                BoardText.Add("\n");
            }

            BoardText.Add("   a  b  c  d  e  f  g  h\n");
            return BoardText;
        }

        // Cells is a jagged array of containing 8 sub arrays of 8 cells (8x8)
        public Cell[][] Cells { get; private set; }
    }
}