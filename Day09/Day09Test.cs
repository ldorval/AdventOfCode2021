using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day09
{
    public class Day09Test
    {
        private string input = "2199943210\r\n3987894921\r\n9856789892\r\n8767896789\r\n9899965678";
        
        [Test]
        public void ExamplePart1()
        {
            Day09.SolvePart1(input).Should().Be(15);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day09.SolvePart1("Day09.txt".ReadAll()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day09.SolvePart2(input).Should().Be(1134);
        }

        [Test]
        public void SolvePart2()
        {
            Console.Write(Day09.SolvePart2("Day09.txt".ReadAll()));
        }
    }
}