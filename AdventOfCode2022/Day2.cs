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

            int Myhighscore = 0;
            int OppHighscore = 0;

            //foreach(String str in RockPaperScissors)
            //{
            //    string[] result = str.Split(" ");

            //    if(result[1] == "B")
            //    {
            //        OppHighscore = OppHighscore + 3;
            //    }
            //    else if(result[1] == "A")
            //    {
            //        OppHighscore = OppHighscore + 1;
            //    }
            //    else
            //    {
            //        OppHighscore = OppHighscore + 2;
            //    }

            //    if(result[1] == "Y")
            //    {
            //        Myhighscore = Myhighscore + 3;
            //    }
            //    else if(result[1] == "X")
            //    {
            //        Myhighscore = Myhighscore + 1;
            //    }
            //    else
            //    {
            //        Myhighscore = Myhighscore + 2;
            //    }

            //    if(result[0] == "A" && result[1] == "X" || result[0] == "B" && result[1] == "Y" || result[0] == "C" && result[1] == "Z")
            //    {
            //        Myhighscore = Myhighscore + 3;
            //        OppHighscore = OppHighscore + 3;
            //    }
            //    else if(result[0] == "A" && result[1] == "Y" || result[0] == "B" && result[1] == "Z" || result[0] == "C" && result[1] == "X")
            //    {
            //        Myhighscore = Myhighscore + 6;
            //    }
            //    else
            //    {
            //        OppHighscore = OppHighscore + 6;
            //    }
            //}

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


            Console.WriteLine(" MyTotal: " + puzzleone);
            Console.WriteLine(" OppTotal: " + OppHighscore);
        }

        public void PartTwo()
        {
            Class1 adventLib = new();
            List<string> FoodList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag2.txt");
            FoodList = adventLib.ConvertInputToStringList(newFilePath);

            Console.WriteLine("Total: " + 2);
        }
    }
}


//var puzzleOne = input.Select(x => x switch
//{
//    "A X" => 4,
//    "A Y" => 8,
//    "A Z" => 3,
//    "B X" => 1,
//    "B Y" => 5,
//    "B Z" => 9,
//    "C X" => 7,
//    "C Y" => 2,
//    "C Z" => 6,
//}).Sum();
//var puzzleTwo = input.Select(x => x switch
//{
//    "A X" => 3,
//    "A Y" => 4,
//    "A Z" => 8,
//    "B X" => 1,
//    "B Y" => 5,
//    "B Z" => 9,
//    "C X" => 2,
//    "C Y" => 6,
//    "C Z" => 7,
//}).Sum();