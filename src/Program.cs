using System;
using System.Text;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {   
            Game game = new Game(true);
            Display.DrawArrayList(game.board.Render());
        }
    }
}
