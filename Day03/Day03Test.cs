using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day03
{
    public class Day03Test
    {
        private string input = "00100\r\n11110\r\n10110\r\n10111\r\n10101\r\n01111\r\n00111\r\n11100\r\n10000\r\n11001\r\n00010\r\n01010";

        [Test]
        public void ExamplePart1()
        {
            Day03.SolvePart1(input).Should().Be(198);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day03.SolvePart1(InputReader.ReadAll("Day03.txt")));
        }

        [Test]
        public void ExamplePart2()
        {
            Day03.SolvePart2(input).Should().Be(230);
        }
        
        [Test]
        public void SolvePart2()
        {
            Console.Write(Day03.SolvePart2(InputReader.ReadAll("Day03.txt")));
        }
    }
}