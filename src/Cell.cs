using System;

namespace Chess
{
  class Cell
  {
    public Cell(int xCoord, int yCoord, Piece piece)
    {
      this.x = xCoord;
      this.y = yCoord;
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
    public int x { get; private set; }
    public int y { get; private set; }
  }
}