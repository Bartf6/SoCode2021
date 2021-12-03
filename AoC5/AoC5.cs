using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCodeLibraries;

namespace AoC5
{
    class AoC5
    {
        static void Main(string[] args)
        {
            Class1 adventLib = new Class1();
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\input.txt");
            List<string> BinaryList = adventLib.ConvertInputToStringList(newFilePath);
            List<int> BinaryValues = new List<int>();

            int BinaryLength = BinaryList[0].Length;

            for (int i = 0; i < BinaryLength; i++)
            {
                int increase1 = 0;
                int increase0 = 0;
                foreach(string binaryLine in BinaryList)
                {
                    char[] arr = binaryLine.ToCharArray(0,BinaryLength);
                    string temp =  arr[i].ToString();
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
                Console.Write(value.ToString());
            }
            Console.ReadLine();
        }
    }
}
