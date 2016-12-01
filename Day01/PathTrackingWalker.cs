using System.Collections.Generic;

namespace Day01
{
    public class PathTrackingWalker : Walker
    {
        private readonly HashSet<Coordinate> _visitedLocations;
        private readonly List<Coordinate> _locationsVisitedMoreThanOnce;

        public PathTrackingWalker(Coordinate startLocation, Orientation startingOrientation)
            : base(startLocation, startingOrientation)
        {
            _visitedLocations = new HashSet<Coordinate>();
            _locationsVisitedMoreThanOnce = new List<Coordinate>(16);
        }

        public override void Move(int steps)
        {
            for (int i = 0; i < steps; ++i)
            {
                base.Move(1);

                if (_visitedLocations.Contains(Location))
                {
                    _locationsVisitedMoreThanOnce.Add(Location);
                }
                else
                {
                    _visitedLocations.Add(Location);
                }
            }
        }

        public IEnumerable<Coordinate> GetLocationsVisitedMoreThanOnce()
        {
            return _locationsVisitedMoreThanOnce;
        }
    }
}