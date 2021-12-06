using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day06
{
    public class Day06Test
    {
        private string input = "3,4,3,1,2";
        
        [Test]
        public void Example()
        {
            Day06.Solve(input, 80).Should().Be(5934);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day06.Solve("Day06.txt".ReadAll(), 80));
        }
        
        [Test]
        public void ExamplePart2()
        {
            Day06.Solve(input, 256).Should().Be(26984457539);
        }
        
        [Test]
        public void SolvePart2()
        {
            Console.Write(Day06.Solve("Day06.txt".ReadAll(), 256));
        }
    }
}