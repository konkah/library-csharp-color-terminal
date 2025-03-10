using Konkah.LibraryCSharpColorTerminal;

namespace ConsoleCSharpColorTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String exemplo = "exemplo vermelho";
            String exemplo1 = "exemplo azul";

            ConsoleColored.WriteLine(exemplo, ConsoleColor.Red);
            ConsoleColored.WriteLine(exemplo1, ConsoleColor.Blue);

            ConsoleColored.Write(exemplo, ConsoleColor.Blue);
            Console.Write(" ");
            ConsoleColored.Write(exemplo1, ConsoleColor.Red);
        }
    }
}
