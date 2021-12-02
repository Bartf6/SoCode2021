using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeLibraries
{
    public class Class1
    {
        public List<string> ConvertInputToStringList(string FileUrl)
        {
            List<string> lines = new List<string>();

            foreach(string line in System.IO.File.ReadLines(FileUrl))
            {
                lines.Add(line);
            }

            return lines;
        }

        public List<int> ConvertInputToIntList(string FileUrl)
        {
            List<int> lines = new List<int>();

            foreach(string line in System.IO.File.ReadLines(FileUrl))
            {
                lines.Add(Int32.Parse(line));
            }

            return lines;
        }
    }
}
