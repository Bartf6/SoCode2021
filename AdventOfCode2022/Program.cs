using System;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 day1 = new();
            Day2 day2 = new();

            Console.WriteLine("*******Day 1 solution*******");
            day1.PartOne();
            day1.PartTwo();

            Console.WriteLine("*******Day 2 solution*******");
            day2.PartOne();
            day2.PartTwo();
        }
    }
}
