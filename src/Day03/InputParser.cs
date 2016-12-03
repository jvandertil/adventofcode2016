using System;
using System.Linq;

namespace Day03
{
    public static class InputParser
    {
        public static int[] ParseRows(string[] input)
        {
            int[] values = new int[input.Length * 3];

            for (int i = 0, j = 0; i < input.Length; i++)
            {
                int[] inputInts = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                values[j++] = inputInts[0];
                values[j++] = inputInts[1];
                values[j++] = inputInts[2];
            }

            return values;
        }

        public static int[] ParseColumns(string[] input)
        {
            int[] values = new int[input.Length * 3];

            for (int i = 0; i < input.Length; ++i)
            {
                int[] inputInts = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                values[i] = inputInts[0];
                values[input.Length + i] = inputInts[1];
                values[input.Length * 2 + i] = inputInts[2];
            }

            return values;
        }
    }
}