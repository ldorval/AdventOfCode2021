using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day04
{
    public class Day04Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day04.SolvePart1("Day04Example.txt".ReadStream()).Should().Be(4512);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day04.SolvePart1("Day04.txt".ReadStream()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day04.SolvePart2("Day04Example.txt".ReadStream()).Should().Be(1924);
        }

        [Test]
        public void SolvePart2()
        {
            Console.Write(Day04.SolvePart2("Day04.txt".ReadStream()));
        }
    }
}