using System;

namespace Chess
{
  class Cell
  {
    public Cell(int row, int col, Piece piece)
    {
      this.Row = row;
      this.Col = col;
      SetPiece(piece);
    }

    public void SetPiece(Piece piece)
    {
      this.piece = piece;
    }

    public Piece GetPiece()
    {
        return piece;
    }

    private Piece piece;
    public int Row { get; private set; }
    public int Col { get; private set; }
  }
}