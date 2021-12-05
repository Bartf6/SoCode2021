using AdventOfCodeLibraries;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code
{
    class Day2
    {
        public void partOne()
        {
            Class1 input = new Class1();
            List<string> StringList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag2.txt");

            StringList = input.ConvertInputToStringList(newFilePath);

            int Depth = 0;
            int Horizontal = 0;

            foreach(string line in StringList)
            {
                string[] subs = line.Split(' ');
                string Direction = subs[0];
                int Amount = Int32.Parse(subs[1]);

                switch(Direction)
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

            //Console.WriteLine("Diepte: " + Depth);
            //Console.WriteLine("Horizontaal: " + Horizontal);
            Console.WriteLine("Part one answer: " + (Horizontal * Depth));
        }

        public void partTwo()
        {
            Class1 input = new Class1();
            List<string> StringList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag2.txt");

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

            //Console.WriteLine("Diepte: " + Depth);
            //Console.WriteLine("Horizontaal: " + Horizontal);
            //Console.WriteLine("Mikpunt: " + Aim);
            Console.WriteLine("Part two answer: " + (Horizontal * Depth));
        }
    }
}
