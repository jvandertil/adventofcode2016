namespace Day02
{
    public struct Position
    {
        private readonly int _lowerLimit;
        private readonly int _upperLimit;

        public int X { get; }

        public int Y { get; }

        public Position(int x, int y, int lowerLimit, int upperLimit)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;

            X = x;
            Y = y;
        }

        public Position GoLeft()
        {
            return X == _lowerLimit ? this : new Position(X - 1, Y, _lowerLimit, _upperLimit);
        }

        public Position GoUp()
        {
            return Y == _lowerLimit ? this : new Position(X, Y - 1, _lowerLimit, _upperLimit);
        }

        public Position GoRight()
        {
            return X == _upperLimit ? this : new Position(X + 1, Y, _lowerLimit, _upperLimit);
        }

        public Position GoDown()
        {
            return Y == _upperLimit ? this : new Position(X, Y + 1, _lowerLimit, _upperLimit);
        }
    }
}