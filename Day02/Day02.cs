using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day02
{
    public class Day02
    {
        public static int SolvePart1(string input)
        {
            var coordinates = Solve(input);
            return coordinates.x * coordinates.aim;
        }

        public static int SolvePart2(string input)
        {
            var coordinates = Solve(input);
            return coordinates.x * coordinates.depth;
        }

        private static (int x, int depth, int aim) Solve(string input)
        {
            var coordinates = (x: 0, depth: 0, aim: 0);
            GetInstructions(input)
                .ForEach(instruction =>
                {
                    if (instruction.direction == "forward")
                    {
                        coordinates.x += instruction.distance;
                        if (coordinates.aim != 0) coordinates.depth += instruction.distance * coordinates.aim;
                    }
                    else if (instruction.direction == "up") coordinates.aim -= instruction.distance;
                    else if (instruction.direction == "down") coordinates.aim += instruction.distance;
                });

            return coordinates;
        }  

        private static List<(string direction, int distance)> GetInstructions(string input)
        {
            return input.LinesToString()
                .Select(x => (direction: x.Split(' ')[0], distance: Convert.ToInt32(x.Split(' ')[1])))
                .ToList();
        }
    }
}