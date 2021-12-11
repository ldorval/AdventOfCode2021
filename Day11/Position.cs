namespace AdventOfCode2021.Day11
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Energy { get; set; }

        public Position(int x, int y, int energy)
        {
            X = x;
            Y = y;
            Energy = energy;
        }

        public bool IsFlashing()
        {
            return Energy > 9;
        }
    }
}