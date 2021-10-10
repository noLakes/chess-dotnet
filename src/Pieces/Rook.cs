using System;

namespace Chess
{
    class Rook : Piece
    {
        public Rook(bool IsWhite) : base(IsWhite)
        {
            SetSymbol(IsWhite ? "\u2656" : "\u265C");

            Moves = new int[28, 2] {
                         {0, 1}, {0, 2}, {0, 3}, {0, 4}, {0, 5}, {0, 6}, {0, 7},
                         {0, -1}, {0, -2}, {0, -3}, {0, -4}, {0, -5}, {0, -6}, {0, -7},
                         {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}, {6, 0}, {7, 0},
                         {-1, 0}, {-2, 0}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}
                         };
        }
    }
}