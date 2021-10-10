using System;

namespace Chess
{
    class Pawn : Piece
    {
        public Pawn(bool IsWhite) : base(IsWhite)
        {
            SetSymbol(IsWhite ? "x" : "y");

            if(IsWhite)
            {
                Moves = new int[4, 2] { {-1, 1}, {1, 1}, {0, 2}, {0, 1} };
            }
            else
            {
                Moves = new int[4, 2] { {-1, -1}, {1, -1}, {0, -2}, {0, -1} };
            }
        }
    }
}