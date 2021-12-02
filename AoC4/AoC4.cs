using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCodeLibraries;

namespace AoC4
{
    class AoC4
    {
        static void Main(string[] args)
        {
            Class1 input = new Class1();
            List<string> StringList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\input.txt");

            StringList = input.ConvertInputToStringList(newFilePath);

            int Depth = 0;
            int Horizontal = 0;
            int Aim = 0;

            foreach(string line in StringList)
            {
                string[] subs = line.Split(' ');
                string Direction = subs[0];
                int Amount = Int32.Parse(subs[1]);

                switch(Direction)
                {
                    case "forward":
                        Horizontal = Horizontal + Amount;
                        Depth = Depth + (Amount * Aim);
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
