using AdventOfCodeLibraries;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code
{
    class Day3
    {
        public void partOne()
        {
            Class1 adventLib = new Class1();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag3.txt");
            List<string> BinaryList = adventLib.ConvertInputToStringList(newFilePath);
            List<int> BinaryValues = new List<int>();
            string result = string.Empty;

            int BinaryLength = BinaryList[0].Length;

            for(int i = 0; i < BinaryLength; i++)
            {
                int increase1 = 0;
                int increase0 = 0;
                foreach(string binaryLine in BinaryList)
                {
                    char[] arr = binaryLine.ToCharArray(0,BinaryLength);
                    string temp = arr[i].ToString();
                    if(Int32.Parse(temp) == 0)
                    {
                        increase0++;
                    }
                    else
                    {
                        increase1++;
                    }
                }
                if(increase0 < increase1)
                {
                    BinaryValues.Add(1);
                }
                else
                {
                    BinaryValues.Add(0);
                }
            }

            foreach(int value in BinaryValues)
            {
                result += value.ToString();
            }

            Console.WriteLine("Part one answer: " + result);
        }

        public void partTwo()
        {
            Class1 adventLib = new Class1();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag3.txt");
            List<string> BinaryList = adventLib.ConvertInputToStringList(newFilePath);

            string result1 = string.Empty;
            string result2 = string.Empty;

            result1 = recursiveOxygen(BinaryList,0,12,true);
            result2 = recursiveOxygen(BinaryList,0,12,false);
            Console.WriteLine("Part two answer: " + "Oxygen: " + result1 + " - CO2: " + result2);
        }

        public string recursiveOxygen(List<string> RecursiveList,int index,int BinaryLength,bool mostCommon = true)
        {
            List<string> OxygenGeneratorRating = new List<string>();
            if(mostCommon)
            {
                if(RecursiveList.Count == 2)
                {
                    var item1 = RecursiveList[0].ToCharArray(0,BinaryLength);
                    if(Int32.Parse(item1[index].ToString()) == 1)
                    {
                        return RecursiveList[0];
                    }
                    else
                    {

                        return RecursiveList[1];
                    }
                }
                else if(RecursiveList.Count == 1)
                {
                    return RecursiveList[0];
                }
            }
            else
            {
                if(RecursiveList.Count == 2)
                {
                    var item1 = RecursiveList[0].ToCharArray(0,BinaryLength);
                    if(Int32.Parse(item1[index].ToString()) == 0)
                    {
                        return item1.ToString();
                    }
                    else
                    {
                        return RecursiveList[1];
                    }
                }
                else if(RecursiveList.Count == 1)
                {
                    return RecursiveList[0];
                }
            }

            int increase1 = 0;
            int increase0 = 0;
            int MostBinaryValues = 0;
            foreach(string Rline in RecursiveList)
            {
                char[] arr = Rline.ToCharArray(0,BinaryLength);
                string temp = arr[index].ToString();
                if(Int32.Parse(temp) == 0)
                {
                    increase0++;
                }
                else
                {
                    increase1++;
                }

            }

            if(mostCommon)
            {
                if(increase0 < increase1)
                {
                    MostBinaryValues = 1;
                }
                else if(increase0 > increase1)
                {
                    MostBinaryValues = 0;
                }
                else if(increase0 == increase1)
                {
                    MostBinaryValues = 1;
                }
            }
            else
            {
                if(increase0 < increase1)
                {
                    MostBinaryValues = 0;
                }
                else if(increase0 > increase1)
                {
                    MostBinaryValues = 1;
                }
                else if(increase0 == increase1)
                {
                    MostBinaryValues = 0;
                }
            }

            foreach(string Bline in RecursiveList)
            {
                char[] TempArr = Bline.ToCharArray(0,BinaryLength);
                string temp = TempArr[index].ToString();

                if(Int32.Parse(temp) == MostBinaryValues)
                {
                    OxygenGeneratorRating.Add(Bline);
                }
            }

            return recursiveOxygen(OxygenGeneratorRating,index + 1,BinaryLength,mostCommon);
        }

    }
}
