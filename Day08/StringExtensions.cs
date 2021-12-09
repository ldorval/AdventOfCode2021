using System.Linq;

namespace AdventOfCode2021.Day08
{
    public static class StringExtensions
    {
        public static bool HasLength(this string s, int expectedLength)
        {
            return s.Length == expectedLength;
        }

        public static bool HasCommonSidesWith(this string s, string reference, int expectedCommonSides)
        {
            return s.Count(reference.Contains) == expectedCommonSides;
        }
    }
}