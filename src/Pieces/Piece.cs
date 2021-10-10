using System;

namespace Chess
{
    class Piece
    {
        public Piece(bool white)
        {
            IsWhite = white;  
        }

        public string GetSymbol()
        {
            return Symbol;
        }

        protected void SetSymbol(string symbol)
        {
            Symbol = symbol;
        }

        public int[,] Moves;
        public bool IsWhite { get; private set; }
        private string Symbol;
    }
}