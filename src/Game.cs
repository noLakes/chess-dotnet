using System;

namespace Chess
{
    class Game
    {
        public Game()
        {
            board = new Board();
        }

        public void SetPlayers(bool humanWhite, bool humanBlack)
        {
            White = new Player(true, humanWhite);
            Black = new Player(false, humanBlack);
        }

        public Board board { get; private set; }
        public Player White { get; private set; }
        public Player Black { get; private set; }
    }
}