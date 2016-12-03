using System;
using System.IO;

namespace Day03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            PartOne(input);
            PartTwo(input);
        }

        private static void PartOne(string[] input)
        {
            int[] values = InputParser.ParseRows(input);

            Console.WriteLine("Part one, valid triangles: {0}", CountValidTriangles(values));
        }

        private static void PartTwo(string[] input)
        {
            int[] values = InputParser.ParseColumns(input);

            Console.WriteLine("Part two, valid triangles: {0}", CountValidTriangles(values));
        }

        private static int CountValidTriangles(int[] values)
        {
            int count = 0;

            for (int i = 0; i < values.Length;)
            {
                if (TriangleValidator.Validate(values[i++], values[i++], values[i++]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
