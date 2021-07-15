
namespace ShapesExercise.models
{
    public class Rectangle : Shape
    {


        public Rectangle(double x, double y, double w, double h)
        {
            XCoordinate = x;
            YCoordinate = y;
            Width = w;
            Height = h;
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
            System.Console.WriteLine("Currently not apply for rectangle");
        }

        public override void Transform(double units)
        {
            Width *= units;
        }
    }


}