using System;
using System.Collections.Generic;

namespace AoC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<int> DepthList = new List<int>();
            int Increases = 0;

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\bfransen\source\repos\Advent of Code\Advent of Code\input.txt"))
            {
                DepthList.Add(Int32.Parse(line));
                counter++;
            }

            for (int i = 0; i < counter - 1; i++)
            {
                if(i+3 == counter)
                {
                    break;
                }

                if (DepthList[i] < DepthList[i+3])
                {
                    Increases++;
                }
            }

            Console.WriteLine("Amount of Increases: {0}.", Increases);
            Console.ReadLine();
        }
    }
}
