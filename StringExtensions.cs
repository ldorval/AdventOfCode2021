using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
    public static class StringExtensions
    {
        public static List<string> ToValueList(this string value)
        {
            return value.Split(',').ToList();
        }
        
    }
}