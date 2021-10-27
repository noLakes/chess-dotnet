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
                SetPlayers(true, true);
            }
            else
            {
                GetPlayerHumanity();
            }
        }

        private void Turn(int turn)
        {
            var CurrentPlayer = turn % 2 > 0 ? White : Black;
            Move move;
            while(true)
            {
                move = GetPlayerMove(CurrentPlayer);
                if(Board.IsLegalMove(move))
                {
                    //make move
                    turn++;
                    break;
                }
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
                white = Display.GetInput("White Player Human? [y/n]").ToLower();
            } while(white != "y" && white != "n");

            Console.WriteLine();
            do
            {
                black = Display.GetInput("Black Player Human? [y/n]").ToLower();
            } while(black != "y" && black != "n");

            SetPlayers(white=="y", black=="y");
        }
        
        private Move GetPlayerMove(Player player)
        {
            Move move;
            if(player.Human)
            {
                move = Move.GetMove();
            }
            else move = GetAiMove(player);
            return move;
        }

        private Move GetAiMove(Player player)
        {
            //dummy move
            return new Move(new int[] {1, 2}, new int[] {3, 4});
        }

        public Board board { get; private set; }
        public Player White { get; private set; }
        public Player Black { get; private set; }

        public int TurnCount = 1;
    }
}