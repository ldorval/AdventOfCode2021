using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public static class InputReader
    {
        public static string ReadAll(string file)
        {
            return File.ReadAllText(PathFrom(file));
        }

        public static List<string> ReadLines(string file)
        {
            return File.ReadAllLines(PathFrom(file)).ToList();
        }

        private static string PathFrom(string file)
        {
            return $"../../../../AdventOfCode2020/{file}";
        }

        public static List<int> ReadLinesInt(string file)
        {
            var lines = ReadLines(file);
            return lines.Select(x => Convert.ToInt32(x)).ToList();
        }

        public static List<long> ReadLinesLong(string file)
        {
            var lines = ReadLines(file);
            return lines.Select(x => Convert.ToInt64(x)).ToList();
        }

        public static List<int> ReadIntCsv(string file)
        {
            var input = File.ReadAllText(PathFrom(file));
            return input.Split(',').Select(x => Convert.ToInt32(x)).ToList();
        }

        public static List<string> ReadCsv(string file)
        {
            var input = File.ReadAllText(PathFrom(file));
            return input.Split(',').ToList();
        }
    }
}