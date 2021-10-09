using System;

namespace Chess
{
    class Knight : Piece
    {
        public Knight(bool IsWhite) : base(IsWhite)
        {
            Moves = new int[8, 2] {
                         {-1, 2}, {1, 2}, {-2, 1}, {2, 1},
                         {-1, -2}, {-2, -1}, {1, -2}, {2, -1}
                         };
        }
    }
}