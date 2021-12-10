using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day10
{
    public class Day10Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day10.SolvePart1("Day10Example.txt".ReadAll()).Should().Be(26397);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day10.SolvePart1("Day10.txt".ReadAll()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day10.SolvePart2("Day10Example.txt".ReadAll()).Should().Be(288957);
        }

        [Test]
        public void SolvePart2()
        {
            Console.Write(Day10.SolvePart2("Day10.txt".ReadAll()));
        }
    }
}
