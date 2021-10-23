using System;
using System.Text.RegularExpressions;

namespace Chess
{
    class Move
    {
        public int[] Start { get; private set; }
        public int[] End { get; private set; }

        private static string LegalChars = "abcdefgh12345678";
        private static Regex MoveFormat = new Regex(@"^[a-zA-Z]\d\s?[a-zA-Z]\d");

        public Move(int[] start, int[] end)
        {
            this.Start = start;
            this.End = end;
        }

        public static Move GetMove()
        {
            bool legal = false;
            string input;
            Move move = new Move(new int[2], new int[2]);

            while(!legal)
            {
                input = Display.GetInput("Enter your move:").Replace(" ",string.Empty);

                if(MoveFormat.IsMatch(input) && IsLegalChar(input))
                {   
                    move.Start[0] = MapCharToInt(input[0]);
                    move.Start[1] = MapCharToInt(input[1]);
                    move.End[0] = MapCharToInt(input[2]);
                    move.End[1] = MapCharToInt(input[3]);
                    legal = true;
                }
                if(!legal) Console.WriteLine("Please enter a valid move in the format: a4 b5");
            }
            return move;
        }

        private static bool IsLegalChar(char c)
        {
            return LegalChars.Contains(c);
        }

        private static bool IsLegalChar(string input)
        {
            bool pass = true;
            foreach(char c in input)
            {
                if(!LegalChars.Contains(c)) pass = false;
            }
            return pass;
        }

        public static int MapCharToInt(char c)
        {
            int pos;
            if (char.IsDigit(c))
            {
                pos = (c - '0') - 1;
            }
            else 
            {
                pos = "abcdefgh".IndexOf(c);  
            }  
            return pos;
        }

        public static char MapIntToChar(int i)
        {
            char pos;
            pos = i switch
                {
                    0 => 'a',
                    1 => 'b',
                    2 => 'c',
                    3 => 'd',
                    4 => 'e',
                    5 => 'f',
                    6 => 'g',
                    7 => 'h',
                    _ => 'x'
                };                
            return pos;
        }
    }
}