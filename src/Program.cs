using System;
using System.Text;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {   
            Board board = new Board();
            Display.DrawArrayList(board.Render());
        }
    }
}
