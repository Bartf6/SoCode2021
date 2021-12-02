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
                string Direction = subs[0];
                int Amount = Int32.Parse(subs[1]);

                switch (Direction)
                {
                    case "forward":
                        Horizontal = Horizontal + Amount;
                        Depth = Depth + Amount;
                        break;
                    case "up":
                        Aim = Aim - Amount;
                        break;
                    case "down":
                        Aim = Aim + Amount;
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
