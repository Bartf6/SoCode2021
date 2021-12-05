using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCodeLibraries;

namespace Advent_of_Code
{
    class Day1
    {
        public void partOne()
        {
            Class1 adventLib = new();
            List<int> DepthList = new List<int>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag1.txt");
            DepthList = adventLib.ConvertInputToIntList(newFilePath);

            int counter = DepthList.Count;
            int Increases = 0;

            for(int i = 0; i < counter - 1; i++)
            {
                if(DepthList[i] < DepthList[i + 1])
                {
                    Increases++;
                }
            }

            Console.WriteLine("Part one answer: {0}.",Increases);
        }

        public void partTwo()
        {
            Class1 adventLib = new();
            List<int> DepthList = new List<int>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag1.txt");
            DepthList = adventLib.ConvertInputToIntList(newFilePath);

            int counter = DepthList.Count;
            int Increases = 0;

            for(int i = 0; i < counter - 1; i++)
            {
                if(i + 3 == counter)
                {
                    break;
                }

                if(DepthList[i] < DepthList[i + 3])
                {
                    Increases++;
                }
            }

            Console.WriteLine("Part two answer: {0}.",Increases);
        }
    }
}
