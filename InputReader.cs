using System.IO;

namespace AdventOfCode2021
{
    public static class InputReader
    {
        public static string ReadAll(this string file)
        {
            return File.ReadAllText(PathFrom(file));
        }
        
        private static string PathFrom(this string file)
        {
            return $"../../../Inputs/{file}";
        }
    }
}