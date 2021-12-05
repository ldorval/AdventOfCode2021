using System.Collections.Generic;
using System.Drawing;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2021.Day05
{
    public class InstructionTest
    {
        [Test]
        public void GetsAllHorizontalPointsForward()
        {
            new Instruction {Start = new Point(1, 1), End = new Point(3, 1)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(1, 1), new(2, 1), new(3, 1)
            });
        }

        [Test]
        public void GetsAllHorizontalPointsBackward()
        {
            new Instruction {Start = new Point(3, 1), End = new Point(1, 1)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(3, 1), new(2, 1), new(1, 1)
            });
        }
        
        [Test]
        public void GetsAllVerticalPointsForward()
        {
            new Instruction {Start = new Point(1, 1), End = new Point(1, 3)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(1, 1), new(1, 2), new(1, 3)
            });
        }

        [Test]
        public void GetsAllVerticalPointsBackward()
        {
            new Instruction {Start = new Point(1, 3), End = new Point(1, 1)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(1, 3), new(1, 2), new(1, 1)
            });
        }

        [Test]
        public void GetsAllDiagonalPointsTopLeftToBottomRight()
        {
            new Instruction {Start = new Point(1, 1), End = new Point(3, 3)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(1, 1), new(2, 2), new(3, 3)
            });
        }

        [Test]
        public void GetsAllDiagonalPointsBottomRightToTopLeft()
        {
            new Instruction {Start = new Point(3, 3), End = new Point(1, 1)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(3, 3), new(2, 2), new(1, 1)
            });
        }

        [Test]
        public void GetsAllDiagonalPointsBottomLeftToTopRight()
        {
            new Instruction {Start = new Point(1, 3), End = new Point(3, 1)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(1, 3), new(2, 2), new(3, 1)
            });
        }

        [Test]
        public void GetsAllDiagonalPointsTopRightToBottomLeft()
        {
            new Instruction {Start = new Point(3, 1), End = new Point(1, 3)}.GetAllPoints().Should().BeEquivalentTo(new List<Point>
            {
                new(3, 1), new(2, 2), new(1, 3)
            });
        }
    }
}