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

        private void SetPiece(Piece piece)
        {
            this.piece = piece;
        }

        public Piece GetPiece()
        {
            return piece;
        }

        private Piece piece;
        private int x;
        private int y;
    }
}