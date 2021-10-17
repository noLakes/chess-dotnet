using System;

namespace Chess
{
    class Move
    {
        public Move(int[] start, int[] end)
        {
            this.Start = start;
            this.End = end;
        }

        public static Move GetMove()
        {
            bool legal = false;
            string input;
            while(!legal)
            {
                input = Display.GetInput("Enter your move (eg: a4 b5)");

                // check if input is legal. need a way to scan string for legal chars
                if(input.ToCharArray().Length == 5 && )
                {

                }
            }
        }

        private static bool IsLegalChar(char c)
        {
            return LegalChars.Contains(c);
        }

        private static int MapChar(char c)
        {
            int pos;
            pos = c switch
                {
                    'a' => 0,
                    'b' => 1,
                    'c' => 2,
                    'd' => 3,
                    'e' => 4,
                    'f' => 5,
                    'g' => 6,
                    'h' => 7,
                    _ => c - 1
                };                
            return pos;
        }

        public int[] Start { get; private set; }
        public int[] End { get; private set; }

        private static string LegalChars = "abcdefgh12345678";
    }
}