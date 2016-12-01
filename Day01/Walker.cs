namespace Day01
{
    public class Walker
    {
        private int _orientation;

        public Coordinate Location { get; private set; }

        public Walker(Coordinate startLocation, Orientation startingOrientation)
        {
            Location = startLocation;
            _orientation = (int)startingOrientation;
        }

        public void RotateLeft()
        {
            _orientation -= 90;

            if (_orientation < 0)
            {
                _orientation = 270;
            }
        }

        public void RotateRight()
        {
            _orientation = (_orientation + 90) % 360;
        }

        public virtual void Move(int steps)
        {
            int x = Location.X;
            int y = Location.Y;

            switch (_orientation)
            {
                case 0:
                    Location = new Coordinate(x + steps, y);
                    break;

                case 90:
                    Location = new Coordinate(x, y + steps);
                    break;

                case 180:
                    Location = new Coordinate(x - steps, y);
                    break;

                case 270:
                    Location = new Coordinate(x, y - steps);
                    break;
            }
        }
    }
}