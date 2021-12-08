using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code
{
    class Day6
    {
        public List<int> starterFish = new();

        public void partOne()
        {
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag6.txt");
            string[] Lines = System.IO.File.ReadAllLines(newFilePath);

            string[] FishList = Lines[0].Split(',');
            for(int i = 0; i < FishList.Length; i++)
                starterFish.Add(Int32.Parse(FishList[i]));

            string result = passingDays(starterFish,80).Count.ToString();

            Console.WriteLine("Part one answer: " + result);
        }

        public void partTwo()
        {
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag6.txt");
            string[] Lines = System.IO.File.ReadAllLines(newFilePath);

            Dictionary<int,Int64> FishDict = new();
            for(int i = 0; i < 11; i++)
                FishDict.Add(i,0);
            foreach(int fish in starterFish)
                FishDict[fish]++;

            Dictionary<int,Int64> finalDict = passingDays2(FishDict,256);
            Int64 total = 0;
            for(int i = 0; i < 10; i++)
                total += finalDict[i];

            Console.WriteLine("Part two answer: " + total.ToString());
        }

        public List<int> passingDays(List<int> fishes, int days)
        {
            List<int> fishOut = new();
            foreach(int fish in fishes)
            {
                if(fish > 0)
                {
                    fishOut.Add(fish - 1);
                }
                else if(fish == 0)
                {
                    fishOut.Add(8);
                    fishOut.Add(6);
                }
            }
            int nextDay = days - 1;
            int doNothing = 0;
            if (nextDay % 10 == 0)
            {
                doNothing++;
            }

            if(nextDay < 1)
                return fishOut;
            else
                return passingDays(fishOut,nextDay);
        }

        public Dictionary<int,Int64> passingDays2(Dictionary<int,Int64> today,int days)
        {
            Dictionary<int,Int64> nextday = today;
            nextday[9] = nextday[0];
            nextday[7] += nextday[0];

            for (int i = 0; i < 10; i++)
            {
                nextday[i] = nextday[i + 1];
            }
            if (days == 1)
            {
                return nextday;
            }
            else
            {
                return passingDays2(nextday,days - 1);
            }
        }
    }
}
