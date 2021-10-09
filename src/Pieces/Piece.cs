using System;

namespace Chess
{
    class Piece
    {
        public Piece(bool IsWhite)
        {
            Color = IsWhite ? "White" : "Black";
        }

        public int[,] Moves;
        public string Color { get; private set; }
    }
}