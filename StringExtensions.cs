using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021
{
    public static class StringExtensions
    {
        public static List<string> ToValueList(this string value)
        {
            return value.Split(',').ToList();
        }
        
        public static List<int> LinesToInts(this string value)
        {
            var lines = value.Split("\r\n").ToList();
            return lines.Select(x => Convert.ToInt32(x)).ToList();
        }
    }
}