using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day01
{
    public class Day01Test
    {
        private string input = "199\r\n200\r\n208\r\n210\r\n200\r\n207\r\n240\r\n269\r\n260\r\n263";
        
        [Test]
        public void ExamplePart1()
        {
            Day01.Part1(input).Should().Be(7);
        }

        [Test]
        public void SolutionPart1()
        {
            Console.Write(Day01.Part1("Day01.txt".ReadAll()));
        }

        [Test]
        public void ExamplePart2()
        {
            Day01.Part2(input).Should().Be(5);
        }
        
        [Test]
        public void SolutionPart2()
        {
            Console.Write(Day01.Part2("Day01.txt".ReadAll()));
        }
    }
}