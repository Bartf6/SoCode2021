using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCodeLibraries;

namespace AdventOfCode2022
{
    class Day1
    {
        public void PartOne()
        {
            Class1 adventLib = new();
            List<string> FoodList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag1.txt");
            FoodList = adventLib.ConvertInputToStringList(newFilePath);

            int counter = FoodList.Count;
            int highestFood = 0;
            int currentFood = 0;

            for(int i = 0; i < counter - 1; i++)
            {
                if(FoodList[i] == "")
                {
                    if(highestFood < currentFood)
                    {
                        highestFood = currentFood;
                    }
                    currentFood = 0;
                }
                else
                {
                    currentFood = currentFood + Convert.ToInt32(FoodList[i]);
                }
            }

            Console.WriteLine(highestFood);
        }

        public void PartTwo()
        {
            Class1 adventLib = new();
            List<string> FoodList = new List<string>();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\InputDag1.txt");
            FoodList = adventLib.ConvertInputToStringList(newFilePath);

            List<int> totalFood = new List<int>();

            int counter = FoodList.Count;
            int currentFood = 0;

            for(int i = 0; i < counter - 1; i++)
            {
                if(FoodList[i] == "")
                {
                    totalFood.Add(currentFood);
                    currentFood = 0;
                }
                else
                {
                    currentFood = currentFood + Convert.ToInt32(FoodList[i]);
                }
            }

            int totalElfs = totalFood.Count;
            totalFood.Sort();
            int topThree = totalFood[totalElfs - 1] + totalFood[totalElfs - 2] + totalFood[totalElfs - 3];
            Console.WriteLine("Total: " + topThree);
        }
    }
}
