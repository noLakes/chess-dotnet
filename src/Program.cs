using System;


namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
            Game game = new Game(true);
            Display.DrawArrayList(game.board.Render());
            */
            Move test = Move.GetMove();

            Console.WriteLine($"Start: {test.Start[0]}/{test.Start[1]} End: {test.End[0]}/{test.End[1]}");
        }
    }
}
