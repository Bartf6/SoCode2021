using System;

namespace AoC4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Depth = 0;
            int Horizontal = 0;
            int Aim = 0;

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\bfransen\source\repos\Advent of Code\AoC4\input.txt"))
            {
                string s = line;
                string[] subs = s.Split(' ');
                switch (subs[0])
                {
                    case "forward":
                        Horizontal = Horizontal + Int32.Parse(subs[1]);
                        Depth = Depth + (Int32.Parse(subs[1]) * Aim);
                        break;
                    case "up":
                        Aim = Aim - Int32.Parse(subs[1]);
                        break;
                    case "down":
                        Aim = Aim + Int32.Parse(subs[1]);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("Diepte: " + Depth);
            Console.WriteLine("Horizontaal: " + Horizontal);
            Console.WriteLine("Mikpunt: " + Aim);
            Console.WriteLine("Vermenigvuldiging: " + (Horizontal * Depth));
            Console.ReadLine();
        }
    }
}
