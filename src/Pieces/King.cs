using System;

namespace Chess
{
    class King : Piece
    {
        public King(bool IsWhite) : base(IsWhite)
        {
            SetSymbol(IsWhite ? "\u2654" : "\u265A");

            Moves = new int[8, 2] {
                         {-1, 1}, {0, 1}, {1, 1}, {1, 0},
                         {1, -1}, {0, -1}, {-1, -1}, {-1, 0}
                         };
        }
    }
}