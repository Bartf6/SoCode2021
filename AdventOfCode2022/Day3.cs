using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCodeLibraries;

namespace AdventOfCode2022
{
    class Day3
    {
        public void PartOne()
        {
            Class1 adventLib = new();
            List<string> BackPack = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag3.txt");
            BackPack = adventLib.ConvertInputToStringList(newFilePath);

            String ItemPriority = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int score = 0;

            foreach(var item in BackPack)
            {
                string firsthalf = item.Substring(0,(int)(item.Length / 2));
                string secondHalf = item.Substring((int)(item.Length / 2) , (int)(item.Length / 2));

                char[] string1 = firsthalf.ToCharArray();
                char[] string2 = secondHalf.ToCharArray();

                IEnumerable<char> common = string1.Intersect(string2);

                score = score + ItemPriority.IndexOf(common.First()) + 1;
            }

            Console.WriteLine("Total: " + score);
        }
        public void PartTwo()
        {
            Class1 adventLib = new();
            List<string> BackPack = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag3.txt");
            BackPack = adventLib.ConvertInputToStringList(newFilePath);

            String ItemPriority = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int score = 0;

            for (int i = 0; i < BackPack.Count; i += 3)
            {
                char[] firstLine = BackPack[i].ToCharArray();
                char[] secondLine = BackPack[i + 1].ToCharArray();
                char[] thridLine = BackPack[i + 2].ToCharArray();

                IEnumerable<char> firstCommon = firstLine.Intersect(secondLine);
                IEnumerable<char> secondCommon = secondLine.Intersect(thridLine);
                IEnumerable<char> result = firstCommon.Intersect(secondCommon);

                score = score + ItemPriority.IndexOf(result.First()) + 1;
            }

            Console.WriteLine("Total: " + score);
        }
    }
}