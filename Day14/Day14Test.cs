using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day14
{
    public class Day14Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day14.Solve("Day14Example.txt".ReadAll(), 10).Should().Be(1588);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day14.Solve("Day14.txt".ReadAll(), 10));
        }
        
        [Test]
        public void ExamplePart2()
        {
            Day14.Solve("Day14Example.txt".ReadAll(), 40).Should().Be(2188189693529);
        }

        [Test]
        public void SolvePart2()
        {
            Console.Write(Day14.Solve("Day14.txt".ReadAll(), 40));
        }
    }
}