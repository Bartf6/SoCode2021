using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCodeLibraries;
namespace AoC6
{
    class AoC6
    {
        private readonly int BinaryLength = 12;

        static void Main(string[] args)
        {
            AoC6 test = new AoC6();
            Class1 adventLib = new Class1();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\input.txt");
            List<string> BinaryList = adventLib.ConvertInputToStringList(newFilePath);

            Console.WriteLine(test.recursiveOxygen(BinaryList,0,true));
            Console.WriteLine(test.recursiveOxygen(BinaryList,0,false));
            Console.ReadLine();
        }

        public string recursiveOxygen(List<string> RecursiveList,int index, bool mostCommon=true)
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
            foreach (string Rline in RecursiveList)
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
                else if (increase0 == increase1)
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
                else if (increase0 == increase1)
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

            return recursiveOxygen(OxygenGeneratorRating,index + 1, mostCommon);
        }
    }
}
