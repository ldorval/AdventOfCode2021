using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day10
{
    public class Day10
    {
        private static Dictionary<char, char> Symbols = new() {{'(', ')'}, {'[', ']'}, {'{', '}'}, {'<', '>'}};
        private static Dictionary<char, int> IllegalSymbolScore = new() { {')', 3}, {']', 57}, {'}', 1197}, {'>', 25137} };
        private static Dictionary<char, int> MissingSymbolScore = new() { {')', 1}, {']', 2}, {'}', 3}, {'>', 4} };

        public static int SolvePart1(string input)
        {
            return input.LinesToString()
                .Select(FirstIllegalSymbolFromLine)
                .Where(x => x.HasValue)
                .Select(x => x.Value)
                .Select(x => IllegalSymbolScore[x])
                .Sum();
        }

        public static long SolvePart2(string input)
        {
            var scores = input.LinesToString()
                .Where(HasIllegalSymbols)
                .Select(MissingSymbols)
                .Select(CalculateCompletionScore)
                .OrderBy(x => x)
                .ToList();

            return scores[scores.Count / 2];
        }

        private static string MissingSymbols(string line)
        {
            var openerStack = new Stack<char>();
            
            foreach (var c in line)
            {
                if (Symbols.Keys.Contains(c))
                    openerStack.Push(c);
                else
                    openerStack.Pop();
            }

            var missingSymbols = string.Empty;
            while (openerStack.Count > 0)
            {
                char openingSymbol = openerStack.Pop();
                missingSymbols += Symbols[openingSymbol];
            }

            return missingSymbols;
        }

        private static long CalculateCompletionScore(string missingSymbols)
        {
            return missingSymbols
                .Select(x => MissingSymbolScore[x])
                .Aggregate(0L, (t, x) => t * 5 + x);
        }

        private static bool HasIllegalSymbols(string line)
        {
            return !FirstIllegalSymbolFromLine(line).HasValue;
        }

        private static char? FirstIllegalSymbolFromLine(string line)
        {
            var openerStack = new Stack<char>();
            
            foreach (var c in line)
            {
                if (Symbols.Keys.Contains(c))
                    openerStack.Push(c);
                else if (ClosingDoesntMatchOpening(c, openerStack.Pop()))
                    return c;
            }

            return null;
        }

        private static bool ClosingDoesntMatchOpening(char c, char matchingOpener)
        {
            return Symbols.First(x => x.Value == c).Key != matchingOpener;
        }
    }
}