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
            Day5 day5 = new();
            Day6 day6 = new();
            Day7 day7 = new();

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

            Console.WriteLine("----------------------------");

            Console.WriteLine("*******Day 5 solution*******");
            day5.partOne();
            day5.partTwo();

            Console.WriteLine("----------------------------");

            Console.WriteLine("*******Day 6 solution*******");
            day6.partOne();
            day6.partTwo();

            Console.WriteLine("----------------------------");

            Console.WriteLine("*******Day 7 solution*******");
            day7.partOne();
            day7.partTwo();

            Console.ReadLine();
        }
    }
}
