namespace ShapesExercise.models
{
    public class Coordinate
    {
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        public Coordinate()
        {
            
        }
        public Coordinate(double x, double y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}