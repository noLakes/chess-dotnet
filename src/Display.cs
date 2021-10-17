using System;
using System.Collections;
using System.Text;

namespace Chess
{
    class Display
    {
        public static void DrawArrayList(ArrayList list)
        {
            UTF8Encoding utf8 = new UTF8Encoding();

            foreach(string line in list)
            {
                Console.Write(line);
            }
        }

        public static string GetInput(string prompt, string[] format = null)
        {
            Console.Write($"{prompt} ");
            string answer = Console.ReadLine();

            return answer;
        }   

    }
}