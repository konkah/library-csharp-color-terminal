using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konkah.LibraryCSharpColorTerminal
{
    public class ConsoleColored
    {
        public static void WriteLine(string exemplo, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(exemplo);
            Console.ResetColor();
        }

        public static void Write(string exemplo, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(exemplo);
            Console.ResetColor();
        }
    }
}
