using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCodeLibraries;

namespace AdventOfCode2022
{
    class Day5
    {
        public void PartOne()
        {
            List<Stack<char>> stacks = new List<Stack<char>>();
            string[] InputParse(ref List<Stack<char>> stacks)
            {
                var input = File.ReadAllLines("..\\..\\..\\InputDag5.txt");
                for(int i = 0; i < 9; i++)
                    stacks.Add(new Stack<char>());
                for(int i = 7; i >= 0; i--)
                {
                    int indexOfStack = 0;
                    var line = input[i].ToCharArray();
                    for(int j = 1; j < line.Length; j += 4)
                    {
                        if(char.IsLetter(line[j]))
                        {
                            stacks[indexOfStack].Push(line[j]);
                        }
                        indexOfStack++;
                    }
                }
                return input;
            }
            var input = InputParse(ref stacks);
            // Part 1
            for(int i = 10; i < input.Length; i++)
            {
                var values = input[i].Split(" ");
                int[] ints = { int.Parse(values[1]),int.Parse(values[3]),int.Parse(values[5]) };
                for(int j = 0; j < ints[0]; j++)
                {
                    char res = stacks[ints[1] - 1].Pop();
                    stacks[ints[2] - 1].Push(res);
                }
            }
            Console.Write("Answer: ");
            foreach(var stack in stacks)
                Console.Write(stack.Pop());
            Console.WriteLine();
        }

        public void PartTwo()
        {
            List<Stack<char>> stacks = new List<Stack<char>>();
            string[] InputParse(ref List<Stack<char>> stacks)
            {
                var input = File.ReadAllLines("..\\..\\..\\InputDag5.txt");
                for(int i = 0; i < 9; i++)
                    stacks.Add(new Stack<char>());
                for(int i = 7; i >= 0; i--)
                {
                    int indexOfStack = 0;
                    var line = input[i].ToCharArray();
                    for(int j = 1; j < line.Length; j += 4)
                    {
                        if(char.IsLetter(line[j]))
                        {
                            stacks[indexOfStack].Push(line[j]);
                        }
                        indexOfStack++;
                    }
                }
                return input;
            }
            var input = InputParse(ref stacks);

            //part 2
            for(int i = 10; i < input.Length; i++)
            {
                var values = input[i].Split(" ");
                int[] ints = { int.Parse(values[1]),int.Parse(values[3]),int.Parse(values[5]) };
                Stack<char> tmp = new Stack<char>();
                for(int j = 0; j < ints[0]; j++)
                {
                    char res = stacks[ints[1] - 1].Pop();
                    tmp.Push(res);
                }
                foreach(var elem in tmp)
                    stacks[ints[2] - 1].Push(elem);
            }
            Console.Write("Answer: ");
            foreach(var stack in stacks)
                Console.Write(stack.Pop());
            Console.WriteLine();
        }
    }
}
