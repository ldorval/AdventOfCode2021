using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day12
{
    public class Day12Test
    {
        [Test]
        public void Example1Part1()
        {
            new Day12().SolvePart1("Day12Example1.txt".ReadAll()).Should().Be(10);
        }
        
        [Test]
        public void Example2Part1()
        {
            new Day12().SolvePart1("Day12Example2.txt".ReadAll()).Should().Be(19);
        }
        
        [Test]
        public void Example3Part1()
        {
            new Day12().SolvePart1("Day12Example3.txt".ReadAll()).Should().Be(226);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(new Day12().SolvePart1("Day12.txt".ReadAll()));
        }

        [Test]
        public void Example1Part2()
        {
            new Day12().SolvePart2("Day12Example1.txt".ReadAll()).Should().Be(36);
        }
        
        [Test]
        public void Example2Part2()
        {
            new Day12().SolvePart2("Day12Example2.txt".ReadAll()).Should().Be(103);
        }
        
        [Test]
        public void Example3Part2()
        {
            new Day12().SolvePart2("Day12Example3.txt".ReadAll()).Should().Be(3509);
        }
        
        [Test]
        public void SolvePart2()
        {
            Console.Write(new Day12().SolvePart2("Day12.txt".ReadAll()));
        }
    }
}