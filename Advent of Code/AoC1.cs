using System;
using System.Collections.Generic;

namespace Advent_of_Code
{
    class AoC1
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<int> DepthList = new List<int>();
            int Increases = 0;

            foreach(string line in System.IO.File.ReadLines(@"C:\Users\bfransen\source\repos\Advent of Code\Advent of Code\input.txt"))
            {
                DepthList.Add(Int32.Parse(line));
                counter++;
            }

            for (int i = 0; i < counter-1; i++)
            {
                if(DepthList[i] < DepthList[i + 1])
                {
                    Increases++;
                }
            }

            Console.WriteLine("Amount of Increases: {0}.", Increases);
            Console.ReadLine();
        }
    }
}
