using System;
using System.Collections.Generic;
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
            var walker = new Walker(startPosition, 0);


            var locationSet = new HashSet<Coordinate>();

            Coordinate firstCoordinateVisitedTwice = null;

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
                }

                int steps = int.Parse(movement.Substring(1));

                for (int i = 0; i < steps; ++i)
                {
                    walker.Move(1);

                    if (locationSet.Contains(walker.Location))
                    {
                        if (firstCoordinateVisitedTwice == null)
                        {
                            firstCoordinateVisitedTwice = walker.Location;
                        }
                    }
                    else
                    {
                        locationSet.Add(walker.Location);
                    }
                }
            }

            Console.WriteLine("Walker location: {0}. Distance from start: {1}", walker.Location, walker.Location.TotalDistance(startPosition));
            Console.WriteLine("First coordinate visited twice: {0}. Distance from start: {1}", firstCoordinateVisitedTwice, firstCoordinateVisitedTwice.TotalDistance(startPosition));
        }

        private static string[] GetMovements()
        {
            var input = File.ReadAllText("input.txt");
            var movements = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            return movements;
        }
    }
}
