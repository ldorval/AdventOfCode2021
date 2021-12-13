using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day13
{
    public class Day13Test
    {
        [Test]
        public void Example()
        {
            new Day13("Day13Example.txt".ReadAll()).SolvePart1().Should().Be(17);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(new Day13("Day13.txt".ReadAll()).SolvePart1());
        }
        
        [Test]
        public void SolvePart2()
        {
            new Day13("Day13.txt".ReadAll()).SolvePart2();
        }
    }
}
