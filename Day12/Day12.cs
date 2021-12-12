using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day12
{
    public class Day12
    {
        private List<List<string>> paths = new();
        private List<(string A, string B)> connections;
        private bool CanVisitOneSmallCaveTwice;

        public int SolvePart1(string input)
        {
            return Solve(input);
        }

        public int SolvePart2(string input)
        {
            CanVisitOneSmallCaveTwice = true;
            return Solve(input);
        }

        private int Solve(string input)
        {
            connections = input.LinesToString()
                .Select(x => (A: x.Split("-")[0], B: x.Split("-")[1]))
                .ToList();

            FindPaths(new List<string> {"start"});
            return paths.Count;
        }

        private void FindPaths(List<string> currentPath)
        {
            var currentCave = currentPath.Last();
            connections
                .Where(x => x.A == currentCave || x.B == currentCave)
                .Select(x => x.A == currentCave ? x.B : x.A)
                .Where(x => x != "start")
                .Where(x => CanVisitCave(currentPath, x))
                .Select(x => new List<string>(currentPath) {x})
                .ToList()
                .ForEach(x =>
                {
                    if (x.Last() == "end")
                        paths.Add(x);
                    else 
                        FindPaths(x);
                });
        }

        private bool CanVisitCave(List<string> currentPath, string possibility)
        {
            if (possibility == "end") return true;
            if (possibility == possibility.ToUpper()) return true;
            var wasAlreadyVisited = currentPath.Contains(possibility);
            
            if (CanVisitOneSmallCaveTwice)
            {
                return !wasAlreadyVisited || currentPath
                    .Where(x => x == x.ToLower())
                    .GroupBy(x => x)
                    .All(x => x.Count() == 1);
            }
            
            return possibility == possibility.ToLower() && !wasAlreadyVisited;
        }
    }
}