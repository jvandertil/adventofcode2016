using System;
using System.IO;
using System.Linq;

namespace Day01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2016 - Day 01 - Jos van der Til");
            Console.WriteLine("");

            var startPosition = new Coordinate(0, 0);
            var walker = new PathTrackingWalker(startPosition, Orientation.North);

            foreach (var movement in GetMovements())
            {
                char rotation = movement[0];

                switch (rotation)
                {
                    case 'L':
                        walker.RotateLeft();
                        break;

                    case 'R':
                        walker.RotateRight();
                        break;

                    default:
                        throw new FormatException($"Could not determine rotation for movement: {movement}");
                }

                int steps = int.Parse(movement.Substring(1));

                walker.Move(steps);
            }

            var firstCoordinateVisitedTwice = walker.GetLocationsVisitedMoreThanOnce().First();

            Console.WriteLine($"Walker location: {walker.Location}. Distance from start: {startPosition.ManhattanDistance(walker.Location)}");
            Console.WriteLine($"First coordinate visited twice: {firstCoordinateVisitedTwice}. Distance from start: {startPosition.ManhattanDistance(firstCoordinateVisitedTwice)}");
        }

        private static string[] GetMovements()
        {
            var input = File.ReadAllText("input.txt");
            var movements = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return movements;
        }
    }
}
