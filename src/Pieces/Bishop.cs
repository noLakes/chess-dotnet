using System;

namespace Chess
{
    class Bishop : Piece
    {
        public Bishop(bool IsWhite) : base(IsWhite)
        {
            SetSymbol(IsWhite ? "\u2657" : "\u265D");

            Moves = new int[28, 2] {
                         {-1, 1}, {-2, 2}, {-3, 3}, {-4, 4}, {-5, 5}, {-6, 6}, {-7, 7},
                         {1, -1}, {2, -2}, {3, -3}, {4, -4}, {5, -5}, {6, -6}, {7, -7},
                         {1, 1}, {2, 2}, {3, 3}, {4, 4}, {5, 5}, {6, 6}, {7, 7},
                         {-1, -1}, {-2, -2}, {-3, -3}, {-4, -4}, {-5, -5}, {-6, -6}, {-7, -7}
                         };
        }
    }
}