using System.Collections.Generic;

namespace AdventOfCode2021.Day04
{
    public class WinningCard
    {
        public int WinningNumber { get; set; }
        public List<int> NumbersDrawnWhenCardWon { get; set; }
        public List<int> Card { get; set; }
    }
}