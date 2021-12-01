using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day01
{
    public class Day01
    {
        public static int Part1(string input)
        {
            return CountIncreases(input.LinesToInts());
        }

        public static int Part2(string input)
        {
            var readings = input.LinesToInts();
            return CountIncreases(readings
                .Select((_, i) => i)
                .SkipLast(2)
                .Select(i => readings.Skip(i).Take(3).Sum())
                .ToList());
        }

        private static int CountIncreases(IList<int> readings)
        {
            return readings
                .SkipLast(1)
                .Select((x, i) => (reading: x, nextReading: readings[i + 1]))
                .Count(x => x.nextReading > x.reading);
        }
    }
}