using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day05
{
    public class Day05
    {
        public static int SolvePart1(string input)
        {
            return GetInstructions(input)
                .Where(x => x.Start.X == x.End.X || x.Start.Y == x.End.Y)
                .SelectMany(x => x.GetAllPoints())
                .GroupBy(x => x)
                .Count(x => x.Count() >= 2);
        }

        public static int SolvePart2(string input)
        {
            return GetInstructions(input)
                .SelectMany(x => x.GetAllPoints())
                .GroupBy(x => x)
                .Count(x => x.Count() >= 2);
        }

        private static IEnumerable<Instruction> GetInstructions(string input)
        {
            return input
                .Split("\r\n")
                .Select(Instruction.FromLine);
        }
    }
}