using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day03
{
    public class Day03
    {
        public static int SolvePart1(string input)
        {
            var gamma = string.Empty;
            var numbers = input.Split("\r\n").ToList();

            for (var i = 0; i < numbers.First().Length; i++)
            {
                var zeroCount = CountAtPosition(numbers, '0', i);
                gamma += zeroCount > numbers.Count / 2 ? "0" : "1";
            }

            var epsilon = new string(gamma.Select(x => x == '0' ? '1' : '0').ToArray());
            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }

        public static int SolvePart2(string input)
        {
            var numbers = input.Split("\r\n");
            char MostCommon (List<string> n, char p, char s, int i) => CountAtPosition(n, p, i) >= CountAtPosition(n, s, i) ? p : s;
            char LeastCommon (List<string> n, char p, char s, int i) => CountAtPosition(n, p, i) <= CountAtPosition(n, s, i) ? p : s;
            return GetRating(numbers, '1', '0', MostCommon) * GetRating(numbers, '0', '1', LeastCommon);
        }

        private static int GetRating(string[] numbers, char primary, char secondary, Func<List<string>, char, char, int, char> seachFunc)
        {
            var remainingNumbers = new List<string>(numbers);
            var i = 0;
            
            while (remainingNumbers.Count > 1)
            {
                var filter = seachFunc(remainingNumbers, primary, secondary, i);
                remainingNumbers = remainingNumbers.Where(x => x[i] == filter).ToList();
                i++;
            }

            return Convert.ToInt32(remainingNumbers.Single(), 2);
        }

        private static int CountAtPosition(List<string> numbers, char number, int position)
        {
            return numbers.Count(x => x[position] == number);
        }
    }
}