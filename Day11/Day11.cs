using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day11
{
    public class Day11
    {
        public static int Part1(string input)
        {
            var map = input.ToIntMap().SelectMany(ToPosition).ToList();
            return Enumerable.Range(0, 100)
                .Sum(_ => RunStep(map).flashingCount);
        }

        public static int Part2(string input)
        {
            var map = input.ToIntMap().SelectMany(ToPosition).ToList();
            return Enumerable
                .Range(1, 300)
                .Select(i => i)
                .First(_ => RunStep(map).allFlashing);
        }

        private static (int flashingCount, bool allFlashing) RunStep(List<Position> map)
        {
            var flashingCount = 0;
            map.ForEach(x => x.Energy += 1);
            var flashingFishes = map.Where(x => x.IsFlashing()).ToList();

            while (flashingFishes.Any())
            {
                flashingCount += flashingFishes.Count;
                flashingFishes.ForEach(f => IncreaseAdjacents(map, f));
                flashingFishes = map.Where(p => p.IsFlashing()).ToList();
            }

            return (flashingCount, flashingCount == 100);
        }

        private static void IncreaseAdjacents(List<Position> map, Position f)
        {
            f.Energy = 0;
            map.Where(p => p.X == f.X - 1 && p.Y == f.Y - 1
                           || p.X == f.X - 1 && p.Y == f.Y
                           || p.X == f.X - 1 && p.Y == f.Y + 1
                           || p.X == f.X && p.Y == f.Y - 1
                           || p.X == f.X && p.Y == f.Y + 1
                           || p.X == f.X + 1 && p.Y == f.Y - 1
                           || p.X == f.X + 1 && p.Y == f.Y
                           || p.X == f.X + 1 && p.Y == f.Y + 1)
                .Where(p => p.Energy != 0)
                .ToList()
                .ForEach(p => p.Energy += 1);
        }

        private static IEnumerable<Position> ToPosition(IEnumerable<int> line, int y)
        {
            return line.Select((e, x) => new Position(x, y, e));
        }
    }
}