using System;
using System.IO;

namespace Day02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            Console.WriteLine("Solution part one: {0}", SolvePartOne(input));
            Console.WriteLine("Solution part two: {0}", SolvePartTwo(input));
        }

        private static string SolvePartOne(string[] input)
        {
            var walker = new KeyPadWalker(KeyPads.PartOneKeyPad, new Position(1, 1, 0, 2));

            string solution = walker.WalkKeyPad(input);

            return solution;
        }

        private static string SolvePartTwo(string[] input)
        {
            var walker = new KeyPadWalker(KeyPads.PartTwoKeyPad, new Position(0, 2, 0, 4));

            string solution = walker.WalkKeyPad(input);

            return solution;
        }
    }
}
