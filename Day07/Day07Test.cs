using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day07
{
    public class Day07Test
    {
        private string input = "16,1,2,0,4,2,7,1,2,14";
        
        [Test]
        public void ExamplePart1()
        {
            Day07.SolvePart1(input).Should().Be(37);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day07.SolvePart1("Day07.txt".ReadAll()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day07.SolvePart2(input).Should().Be(168);
        }

        [Test]
        public void SolvePart2()
        {
            Console.Write(Day07.SolvePart2("Day07.txt".ReadAll()));
        }
    }
}