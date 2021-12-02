using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCodeLibraries;

namespace AoC3
{
    class AoC3
    {
        static void Main(string[] args)
        {
            Class1 input = new Class1();
            List<string> StringList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\input.txt");

            StringList = input.ConvertInputToStringList(newFilePath);

            int Depth = 0;
            int Horizontal = 0;

            foreach(string line in StringList)
            {
                string[] subs = line.Split(' ');
                string Direction = subs[0];
                int Amount = Int32.Parse(subs[1]);

                switch (Direction)
                {
                    case "forward":
                        Horizontal = Horizontal + Amount;
                        break;
                    case "up":
                        Depth = Depth - Amount;
                        break;
                    case "down":
                        Depth = Depth + Amount;
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
