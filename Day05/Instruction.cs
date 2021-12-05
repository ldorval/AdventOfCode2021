using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode2021.Day05
{
    public class Instruction
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public IEnumerable<Point> GetAllPoints()
        {
            var incrementX = Start.X > End.X ? -1 : 1;
            var incrementY = Start.Y > End.Y ? -1 : 1;
            var distanceX = Math.Abs(Start.X - End.X) + 1;
            var distanceY = Math.Abs(Start.Y - End.Y) + 1;

            if (Start.Y == End.Y)
                return Enumerable.Range(0, distanceX).Select(x => new Point(Start.X + incrementX * x, Start.Y));
                
            if (Start.X == End.X)
                return Enumerable.Range(0, distanceY).Select(x => new Point{X = Start.X, Y = Start.Y + incrementY * x});

            var distanceDiagonale = Math.Max(distanceX, distanceY);
            return Enumerable.Range(0, distanceDiagonale).Select(x => new Point{X = Start.X + incrementX * x, Y = Start.Y + incrementY * x});
        }

        public static Instruction FromLine(string line)
        {
            var sections = line.Split("->");
            return new Instruction
            {
                Start = new Point {X = int.Parse(sections[0].Split(",")[0]), Y = int.Parse(sections[0].Split(",")[1])},
                End = new Point {X = int.Parse(sections[1].Split(",")[0]), Y = int.Parse(sections[1].Split(",")[1])}
            };
        }
    }
}