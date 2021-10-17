using System;

namespace Chess
{
    class Game
    {
        public Game(bool defaultGame = false)
        {
            board = new Board();
            if(defaultGame)
            {
                SetPlayers(true, false);
            }
            else
            {
                GetPlayerHumanity();
            }
        }

        private void SetPlayers(bool humanWhite, bool humanBlack)
        {
            White = new Player(true, humanWhite);
            Black = new Player(false, humanBlack);
        }

        private void GetPlayerHumanity()
        {
            string white;
            string black;
            
            do
            {
                white = Display.GetInput("White Player Human? [y/n]");
            } while(white != "y" && white != "n");

            Console.WriteLine();
            do
            {
                black = Display.GetInput("Black Player Human? [y/n]");
            } while(black != "y" && black != "n");

            SetPlayers(white=="y", black=="y");
        }
        

        public Board board { get; private set; }
        public Player White { get; private set; }
        public Player Black { get; private set; }
    }
}