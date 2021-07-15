namespace ShapesExercise.models
{
    public class Circle: Shape
    {
        

        public Circle(double x, double y, double r)
        {
            XCoordinate = x;
            YCoordinate = y;
            Radius = r;
        }

        public override void MoveLeft(double units)
        {
            XCoordinate -= units;
        }

        public override void MoveRight(double units)
        {
            XCoordinate += units;
        }

        public override void MoveUp(double units)
        {
            YCoordinate += units;
        }

        public override void MoveDown(double units)
        {
            YCoordinate -= units;
        }

        public override void Rotate(double degrees)
        {
            System.Console.WriteLine("Currently not apply for circle");
        }

        public override void Transform(double units)
        {
            Radius += units/2;
        }
    }
}