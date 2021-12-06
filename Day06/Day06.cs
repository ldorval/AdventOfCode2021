using System.Linq;

namespace AdventOfCode2021.Day06
{
    public class Day06
    {
        public static long Solve(string input, int days)
        {
            var fishes = input.ToInts();
            var timeLeft = Enumerable.Range(0, 9)
                .Select(x => fishes.LongCount(y => y == x))
                .ToArray();
            
            for (var i = 0; i < days; i++)
            {
                var buffer = new long[9];
                buffer[6] = buffer[8] = timeLeft[0];

                for (var j = 0; j < 8; j++)
                    buffer[j] += timeLeft[j + 1];

                timeLeft = buffer;
            }

            return timeLeft.Sum();
        }
    }
}