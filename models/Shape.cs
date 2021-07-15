namespace ShapesExercise.models
{
    public abstract class Shape
    {
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public Coordinate[] Coordinates { get; set; }
        
        public abstract void MoveLeft(double units);
        

        public abstract void MoveRight(double units);
        

        public abstract void MoveUp(double units);
        

        public abstract void MoveDown(double units);
        
        public abstract void Rotate(double degrees);

        public abstract void Transform(double units);
        
    }
}