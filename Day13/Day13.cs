using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode2021.Day13
{
    public class Day13
    {
        private List<Point> dots;
        private List<(string axis, int position)> instructions;

        public Day13(string input)
        {
            dots = input.Split("\r\n\r\n")[0].Split("\r\n")
                .Select(x => new Point(int.Parse(x.Split(",")[0]), int.Parse(x.Split(",")[1])))
                .ToList();

            instructions = input.Split("\r\n\r\n")[1].Split("\r\n")
                .Select(x => x.Replace("fold along ", ""))
                .Select(x => (axis: x.Split("=")[0], position: int.Parse(x.Split("=")[1])))
                .ToList();
        }

        public int SolvePart1()
        {
            Fold(instructions.First());
            return dots.Distinct().Count();
        }

        public void SolvePart2()
        {
            instructions.ForEach(Fold);
            for (var y = 0; y <= dots.Max(p => p.Y); y++)
            {
                var line = "";
                for (var x = 0; x <= dots.Max(p => p.X); x++)
                    line += dots.Any(p => p.X == x && p.Y == y) ? "#" : " ";

                Console.WriteLine(line);
            }
        }

        private void Fold((string axis, int position) instruction)
        {
            if (instruction.axis == "y")
            {
                var maxY = dots.Max(x => x.Y);
                dots = dots
                    .Where(p => p.Y > instruction.position)
                    .Select(p => new Point(p.X, maxY - p.Y))
                    .Concat(dots.Where(p => p.Y < instruction.position))
                    .ToList();
            }
            else
            {
                var maxX = dots.Max(x => x.X);
                dots = dots
                    .Where(p => p.X > instruction.position)
                    .Select(p => new Point(maxX - p.X, p.Y))
                    .Concat(dots.Where(p => p.X < instruction.position))
                    .ToList();
            }
        }
    }
}