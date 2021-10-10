using System;

namespace Chess
{
    class Knight : Piece
    {
        public Knight(bool IsWhite) : base(IsWhite)
        {
            SetSymbol(IsWhite ? "\u2658" : "\u265E");

            Moves = new int[8, 2] {
                         {-1, 2}, {1, 2}, {-2, 1}, {2, 1},
                         {-1, -2}, {-2, -1}, {1, -2}, {2, -1}
                         };
        }
    }
}