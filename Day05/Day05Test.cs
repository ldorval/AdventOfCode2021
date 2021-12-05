using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day05
{
    public class Day05Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day05.SolvePart1("Day05Example.txt".ReadAll()).Should().Be(5);
        }

        [Test]
        public void SolutionPart1()
        {
            Console.Write(Day05.SolvePart1("Day05.txt".ReadAll()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day05.SolvePart2("Day05Example.txt".ReadAll()).Should().Be(12);
        }

        [Test]
        public void SolutionPart2()
        {
            Console.Write(Day05.SolvePart2("Day05.txt".ReadAll()));
        }
    }
}