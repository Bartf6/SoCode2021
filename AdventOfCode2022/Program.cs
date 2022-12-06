using System;

namespace AdventOfCode2022
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

            Console.WriteLine("*******Day 1 solution*******");
            day1.PartOne();
            day1.PartTwo();

            Console.WriteLine("*******Day 2 solution*******");
            day2.PartOne();
            day2.PartTwo();

            Console.WriteLine("*******Day 3 solution*******");
            day3.PartOne();
            day3.PartTwo();

            Console.WriteLine("*******Day 4 solution*******");
            day4.PartOne();
            day4.PartTwo();

            Console.WriteLine("*******Day 5 solution*******");
            day5.PartOne();
            day5.PartTwo();

            Console.WriteLine("*******Day 6 solution*******");
            day6.PartOne();
            day6.PartTwo();
        }
    }
}
