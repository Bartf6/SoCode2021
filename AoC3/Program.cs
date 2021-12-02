using System;

namespace AoC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Depth = 0;
            int Horizontal = 0;

            foreach(string line in System.IO.File.ReadLines(@"C:\Users\bfransen\source\repos\Advent of Code\AoC3\input.txt"))
            {
                string s = line;
                string[] subs = s.Split(' ');
                switch (subs[0])
                {
                    case "forward":
                        Horizontal = Horizontal + Int32.Parse(subs[1]);
                        break;
                    case "up":
                        Depth = Depth - Int32.Parse(subs[1]);
                        break;
                    case "down":
                        Depth = Depth + Int32.Parse(subs[1]);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("Diepte: " + Depth);
            Console.WriteLine("Horizontaal: " + Horizontal);
            Console.WriteLine("Vermenigvuldiging: " + (Horizontal * Depth));
            Console.ReadLine();
        }
    }
}
