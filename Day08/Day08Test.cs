using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day08
{
    public class Day08Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day08.SolvePart1("Day08Example.txt".ReadAll()).Should().Be(26);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day08.SolvePart1("Day08.txt".ReadAll()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day08.SolvePart2("Day08Example.txt".ReadAll()).Should().Be(61229);
        }

        [Test]
        public void SolvePart2()
        {
            Console.Write(Day08.SolvePart2("Day08.txt".ReadAll()));
        }
    }
}