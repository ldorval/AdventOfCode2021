using System;
using System.Linq;

namespace AdventOfCode2021.Day07
{
    public class Day07
    {
        public static int SolvePart1(string input)
        {
            int FuelCost(int positionA, int positionB) => Math.Abs(positionA - positionB);
            return Solve(input, FuelCost);
        }
        
        public static int SolvePart2(string input)
        {
            int FuelCost(int positionA, int positionB) => Convert.ToInt32(Math.Abs(positionA - positionB) / 2.0 * (Math.Abs(positionA - positionB) + 1));
            return Solve(input, FuelCost);
        }

        private static int Solve(string input, Func<int, int, int> fuelCost)
        {
            var positions = input.ToInts();
            var costs = Enumerable.Range(0, positions.Max() + 1)
                .Select(x => positions
                    .Select(x1 => fuelCost(x, x1))
                    .Sum());

            return costs.Min();
        }
    }
}