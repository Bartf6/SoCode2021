using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCodeLibraries;

namespace AdventOfCode2022
{
    class Day6
    {
        public void PartOne()
        {
            Class1 adventLib = new();
            List<string> output = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag6.txt");
            output = adventLib.ConvertInputToStringList(newFilePath);

            int sequenceBeginsAfter = 0;

            for(int i = 0; i < output[0].Length; i++)
            {
                var seq = output[0].Substring(i,4);
                if(seq.ToCharArray().Distinct().Count() == 4)
                {
                    sequenceBeginsAfter = i + 4;
                    break;
                }
            }

            Console.WriteLine("Answer: " + sequenceBeginsAfter);
        }

        public void PartTwo()
        {
            Class1 adventLib = new();
            List<string> output = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag6.txt");
            output = adventLib.ConvertInputToStringList(newFilePath);

            int sequenceBeginsAfter = 0;

            for(int i = 0; i < output[0].Length; i++)
            {
                var seq = output[0].Substring(i,14);
                if(seq.ToCharArray().Distinct().Count() == 14)
                {
                    sequenceBeginsAfter = i + 14;
                    break;
                }
            }

            Console.WriteLine("Answer: " + sequenceBeginsAfter);
        }
    }
}

