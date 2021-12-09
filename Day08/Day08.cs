using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day08
{
    public class Day08
    {
        public static int SolvePart1(string input)
        {
            return input.Split("\r\n")
                .SelectMany(x => x.Split(" | ")[1].Split(" "))
                .Count(x => x.Length == 2 || x.Length == 3 || x.Length == 4 || x.Length == 7);
        }

        public static int SolvePart2(string input)
        {
            return input.Split("\r\n")
                .Select(x => (patterns: x.Split(" | ")[0].Split(" ").ToList(), values: x.Split(" | ")[1].Split(" ").ToList()))
                .Select(LineValue)
                .Sum();
        }

        private static int LineValue((List<string> patterns, List<string> values) line)
        {
            var map = ReferenceMap(line);
            return int.Parse(string.Join("", line.values
                .Select(x => map.Single(y => Sort(y.Value) == Sort(x)).Key)));
        }

        private static Dictionary<string, string> ReferenceMap((List<string> patterns, List<string> values) line)
        {
            var map = new Dictionary<string, string>
            {
                {"1", line.patterns.First(x => x.HasLength(2))},
                {"4", line.patterns.First(x => x.HasLength(4))},
                {"7", line.patterns.First(x => x.HasLength(3))},
                {"8", line.patterns.First(x => x.HasLength(7))}
            };

            map.Add("3", line.patterns.Single(x => x.HasLength(5) && x.HasCommonSidesWith(map["1"], 2)));
            map.Add("9", line.patterns.Single(x => x.HasLength(6) && x.HasCommonSidesWith(map["4"], 4)));
            map.Add("6", line.patterns.Single(x => x.HasLength(6) && x.HasCommonSidesWith(map["7"], 2)));
            map.Add("5", line.patterns.Single(x => x.HasLength(5) && x.HasCommonSidesWith(map["6"], 5)));
            map.Add("2", line.patterns.Single(x => x.HasLength(5) && x.HasCommonSidesWith(map["4"], 2)));
            map.Add("0", line.patterns.Single(x => x.HasLength(6) && x.HasCommonSidesWith(map["5"], 4)));

            return map;
        }

        private static string Sort(string toSort)
        {
            return string.Join("", toSort.OrderBy(x => x));
        }
    }
}