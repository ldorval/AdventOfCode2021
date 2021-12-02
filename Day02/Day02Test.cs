using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day02
{
    public class Day02Test
    {
        private string input = "forward 5\r\ndown 5\r\nforward 8\r\nup 3\r\ndown 8\r\nforward 2";
        
        [Test]
        public void ExamplePart1()
        {
            Day02.SolvePart1(input).Should().Be(150);
        }

        [Test]
        public void SolvePart1()
        {
            Console.Write(Day02.SolvePart1(InputReader.ReadAll("Day02.txt")));
        }

        [Test]
        public void ExamplePart2()
        {
            Day02.SolvePart2(input).Should().Be(900);
        }
        
        [Test]
        public void SolvePart2()
        {
            Console.Write(Day02.SolvePart2(InputReader.ReadAll("Day02.txt")));
        }
    }
}