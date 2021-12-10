using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode2021.Day09
{
    public class Day09
    {
        public static int SolvePart1(string input)
        {
            var points = input.ToIntMap();
            return LowPoints(points).Sum(point => points[point.Y][point.X] + 1);
        }

        public static int SolvePart2(string input)
        {
            var points = input.ToIntMap();

            return LowPoints(points)
                .Select(lowPoint => AdjacentPointsInBasin(points, lowPoint))
                .Select(x => x.Distinct())
                .Select(x => x.Count())
                .OrderByDescending(x => x)
                .Take(3)
                .Aggregate((a, b) => a * b);
        }

        private static List<Point> AdjacentPointsInBasin(List<List<int>> points, Point currentPoint)
        {
            var pointsInBasin = new List<Point> {currentPoint};
            var validAdjacentPoints = Adjacents(points, currentPoint.X, currentPoint.Y)
                .Where(point => points[point.Y][point.X] != 9)
                .Where(point => points[point.Y][point.X] > points[currentPoint.Y][currentPoint.X]);

            foreach (var adjacent in validAdjacentPoints)
            {
                pointsInBasin.Add(adjacent);
                pointsInBasin.AddRange(AdjacentPointsInBasin(points, adjacent));
            }

            return pointsInBasin;
        }

        private static IEnumerable<Point> LowPoints(List<List<int>> points) =>
            Enumerable
                .Range(0, points.Count)
                .SelectMany(y => Enumerable.Range(0, points[y].Count), (y, x) => new Point(x, y))
                .Where(point => points[point.Y][point.X] < Adjacents(points, point.X, point.Y).Select(point => points[point.Y][point.X]).Min());

        private static IEnumerable<Point> Adjacents(List<List<int>> points, int x, int y)
        {
            if (x != 0) yield return new Point(x - 1, y);
            if (y != 0) yield return new Point(x, y - 1);
            if (x != points[0].Count - 1) yield return new Point(x + 1, y);
            if (y != points.Count - 1) yield return new Point(x, y + 1);
        }
    }
}