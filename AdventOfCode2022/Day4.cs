using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCodeLibraries;

namespace AdventOfCode2022
{
    class Day4
    {
        public void PartOne()
        {
            Class1 adventLib = new();
            List<string> Pairs = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag4.txt");
            Pairs = adventLib.ConvertInputToStringList(newFilePath);

            int pairsCounter = 0;

            foreach(var item in Pairs)
            {
                String[] strList = item.Split(",", StringSplitOptions.None);
                string firstAmount = strList[0];
                string secondAmount = strList[1];

                String[] firstOperators = firstAmount.Split("-",StringSplitOptions.None);
                String[] secondOperators = secondAmount.Split("-",StringSplitOptions.None);

                int firstPairFirstItem = Convert.ToInt32(firstOperators[0]);
                int firstPairSecondItem = Convert.ToInt32(firstOperators[1]);
                int secondPairFirstItem = Convert.ToInt32(secondOperators[0]);
                int secondPairSecondItem = Convert.ToInt32(secondOperators[1]);

                if (firstPairFirstItem <= secondPairFirstItem && firstPairSecondItem >= secondPairSecondItem || 
                    secondPairFirstItem <= firstPairFirstItem && secondPairSecondItem >= firstPairSecondItem)
                {
                    pairsCounter++;
                }
                
            }

            Console.WriteLine("Answer: " + pairsCounter);

        }

        public void PartTwo()
        {
            Class1 adventLib = new();
            List<string> Pairs = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag4.txt");
            Pairs = adventLib.ConvertInputToStringList(newFilePath);

            int pairsCounter = 0;

            foreach(var item in Pairs)
            {
                String[] strList = item.Split(",",StringSplitOptions.None);
                string firstAmount = strList[0];
                string secondAmount = strList[1];

                String[] firstOperators = firstAmount.Split("-",StringSplitOptions.None);
                String[] secondOperators = secondAmount.Split("-",StringSplitOptions.None);

                int firstPairFirstItem = Convert.ToInt32(firstOperators[0]);
                int firstPairSecondItem = Convert.ToInt32(firstOperators[1]);
                int secondPairFirstItem = Convert.ToInt32(secondOperators[0]);
                int secondPairSecondItem = Convert.ToInt32(secondOperators[1]);
                                
                if(firstPairFirstItem <= secondPairFirstItem && firstPairSecondItem >= secondPairSecondItem || 
                    secondPairFirstItem <= firstPairFirstItem && secondPairSecondItem >= firstPairSecondItem ||
                    firstPairFirstItem >= secondPairFirstItem && firstPairFirstItem <= secondPairSecondItem ||
                    firstPairSecondItem >= secondPairFirstItem && firstPairSecondItem <= secondPairSecondItem
                   )
                {
                    pairsCounter++;
                }

            }


            Console.WriteLine("Answer: " + pairsCounter);
        }
    }
}
