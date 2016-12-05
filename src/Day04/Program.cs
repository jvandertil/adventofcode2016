using System;
using System.IO;
using System.Linq;

namespace Day04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt").Select(RoomParser.GetRoomDescription).ToArray();

            PartOne(input);
            PartTwo(input);
        }

        private static void PartOne(RoomDescription[] input)
        {
            int sectorIdSum = input.Where(x => x.Validate()).Select(x => x.SectorId).Sum();

            Console.WriteLine("Solution part one: {0}", sectorIdSum);
        }

        private static void PartTwo(RoomDescription[] input)
        {
            var roomWithNorth = input.Where(x => x.Decrypt().Contains("north")).Select(x => x.SectorId).Single();

            Console.WriteLine("Solution part two: {0}", roomWithNorth);
        }
    }
}
