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
            return value
                .Split("\r\n")
                .Select(x => Convert.ToInt32(x))
                .ToList();
        }
        
        public static List<string> LinesToString(this string value)
        {
            return value.Split("\r\n").ToList();
        }
    }
}