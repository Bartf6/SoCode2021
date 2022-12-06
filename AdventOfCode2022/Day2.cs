using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCodeLibraries;

namespace AdventOfCode2022
{
    class Day2
    {
        public void PartOne()
        {
            Class1 adventLib = new();
            List<string> RockPaperScissors = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag2.txt");
            RockPaperScissors = adventLib.ConvertInputToStringList(newFilePath);

            var puzzleone = RockPaperScissors.Select(x => x switch
            {
                "A X" => 4,
                "A Y" => 8,
                "A Z" => 3,
                "B X" => 1,
                "B Y" => 5,
                "B Z" => 9,
                "C X" => 7,
                "C Y" => 2,
                "C Z" => 6,
            }).Sum();

            Console.WriteLine("Answer: " + puzzleone);
        }

        public void PartTwo()
        {
            Class1 adventLib = new();
            List<string> RockPaperScissors = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag2.txt");
            RockPaperScissors = adventLib.ConvertInputToStringList(newFilePath);

            var puzzleTwo = RockPaperScissors.Select(x => x switch
            {
                "A X" => 3,
                "A Y" => 4,
                "A Z" => 8,
                "B X" => 1,
                "B Y" => 5,
                "B Z" => 9,
                "C X" => 2,
                "C Y" => 6,
                "C Z" => 7,
            }).Sum();

            Console.WriteLine("Answer: " + puzzleTwo);
        }
    }
}