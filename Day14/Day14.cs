using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day14
{
    public class Day14
    {
        public static long Solve(string input, int steps)
        {
            var template = input.Split("\r\n\r\n")[0];
            var rules = input.Split("\r\n\r\n")[1]
                .Split("\r\n")
                .Select(x => (pair: x.Split(" -> ")[0], insertion: x.Split(" -> ")[1]))
                .ToList();

            var pairCount = PairsInString(template);

            for (var i = 0; i < steps; i++)
            {
                pairCount = ExecuteRules(rules, pairCount);
            }
            
            var letterCount = new Dictionary<char, long> {{template.Last(), 1}};
            foreach (var count in pairCount)
            {
                letterCount[count.Key.First()] = letterCount.ContainsKey(count.Key.First()) ? letterCount[count.Key.First()] + count.Value : count.Value;
            }
            
            return letterCount.Max(x => x.Value) - letterCount.Min(x => x.Value);
        }

        private static Dictionary<string, long> ExecuteRules(List<(string pair, string insertion)> rules, Dictionary<string, long> pairCount)
        {
            var newPairCount = new Dictionary<string, long>();
            foreach (var rule in rules)
            {
                if (!pairCount.ContainsKey(rule.pair))
                    pairCount.Add(rule.pair, 0);

                var firstPairKey = rule.pair.First() + rule.insertion;
                newPairCount[firstPairKey] = newPairCount.ContainsKey(firstPairKey) ? newPairCount[firstPairKey] + pairCount[rule.pair] : pairCount[rule.pair];

                var secondPairKey = rule.insertion + rule.pair.Last();
                newPairCount[secondPairKey] = newPairCount.ContainsKey(secondPairKey) ? newPairCount[secondPairKey] + pairCount[rule.pair] : pairCount[rule.pair];
            }

            return newPairCount;
        }

        private static Dictionary<string, long> PairsInString(string template)
        {
            return Enumerable
                .Range(0, template.Length - 1)
                .Select(i => new string(template.Skip(i).Take(2).ToArray()))
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.LongCount());
        }
    }
}