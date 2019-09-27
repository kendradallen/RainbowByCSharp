using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMaker
{
    public class Rainbow
    {
        public static void MakeItGay(string text)
        {
            ConsoleColor[] gay = { ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkMagenta };

            char[] test = text.ToCharArray();
            byte box = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ' ')
                {
                    Console.ForegroundColor = gay[box++ % gay.Length];
                }
                Console.Write(test[i]);
            }
            Console.WriteLine();

        }
    }
}
