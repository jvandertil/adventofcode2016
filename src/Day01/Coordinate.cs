using System;

namespace Day01
{
    public struct Coordinate
    {
        public int X { get; }

        public int Y { get; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";

        public int ManhattanDistance(Coordinate startCoordinate)
        {
            int x = Math.Abs(X) + Math.Abs(startCoordinate.X);
            int y = Math.Abs(Y) + Math.Abs(startCoordinate.Y);

            return Math.Abs(x + y);
        }

        private bool Equals(Coordinate other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Coordinate)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}