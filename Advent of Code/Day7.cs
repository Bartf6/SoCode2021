using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code
{
    class Day7
    {

        public void partOne()
        {
            string newFilePath = Path.Combine(Environment.CurrentDirectory + @"\..\..\..\inputDag6.txt");
            string[] Lines = System.IO.File.ReadAllLines(newFilePath);

            string[] places = Lines[0].Split(',');
            List<int> HorizontalPlaces = new();

            foreach(string line in places)
            {
                HorizontalPlaces.Add(Int32.Parse(line));
                Console.WriteLine(line);
            }
        }

        public void partTwo()
        {

        }

    }
}
