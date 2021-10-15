using System;

namespace Chess
{
    class Player
    {
        public Player(bool isWhite, bool human)
        {
            this.IsWhite = isWhite;
            this.Human = human;
        }

        public bool IsWhite { get; private set; }
        public bool Human { get; private set; }
    }
}