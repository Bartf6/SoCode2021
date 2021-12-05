using System;
using System.Collections.Generic;

namespace Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 day1 = new();
            Day2 day2 = new();
            Day3 day3 = new();
            Day4 day4 = new();

            Console.WriteLine("*******Day 1 solution*******");
            day1.partOne();
            day1.partTwo();

            Console.WriteLine("----------------------------");

            Console.WriteLine("*******Day 2 solution*******");
            day2.partOne();
            day2.partTwo();

            Console.WriteLine("----------------------------");

            Console.WriteLine("*******Day 3 solution*******");
            day3.partOne();
            day3.partTwo();

            Console.WriteLine("----------------------------");

            Console.WriteLine("*******Day 4 solution*******");
            day4.partOne();
            day4.partTwo();

            Console.ReadLine();
        }
    }
}
