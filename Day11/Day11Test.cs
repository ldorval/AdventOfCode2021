using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day11
{
    public class Day11Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day11.Part1("Day11Example.txt".ReadAll()).Should().Be(1656);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day11.Part1("Day11.txt".ReadAll()));
        }
        
        [Test]
        public void ExamplePart2()
        {
            Day11.Part2("Day11Example.txt".ReadAll()).Should().Be(195);
        }
        
        [Test]
        public void SolvePart2()
        {
            Console.Write(Day11.Part2("Day11.txt".ReadAll()));
        }
    }
}