using ShapesExercise.Helpers;

namespace ShapesExercise.models
{
    public class Triangle: Shape
    {

        public Triangle(Coordinate[] coordinate)
        {
            Coordinates = coordinate;
        }

        public override void MoveLeft(double units)
        {
            foreach (var item in Coordinates)
            {
                item.XCoordinate -= units;
            }
        }

        public override void MoveRight(double units)
        {
            foreach (var item in Coordinates)
            {
                item.XCoordinate += units;
            }
        }

        public override void MoveUp(double units)
        {
            foreach (var item in Coordinates)
            {
                item.YCoordinate += units;
            }
        }

        public override void MoveDown(double units)
        {
            foreach (var item in Coordinates)
            {
                item.YCoordinate -= units;
            }
        }

        public override void Rotate(double degrees)
        {
            Coordinate centerOfTriangle = new Coordinate((Coordinates[0].XCoordinate + Coordinates[1].XCoordinate + Coordinates[2].XCoordinate) / 3, 
                                                            (Coordinates[0].YCoordinate + Coordinates[1].YCoordinate + Coordinates[2].YCoordinate) / 3);


            Coordinates[0] = Formulae.RotatePoint(Coordinates[0], centerOfTriangle, degrees);
            Coordinates[1] = Formulae.RotatePoint(Coordinates[1], centerOfTriangle, degrees);
            Coordinates[2] = Formulae.RotatePoint(Coordinates[2], centerOfTriangle, degrees);

        }

        public override void Transform(double units)
        {
            System.Console.WriteLine("Currently not apply for triangle");
        }
    }
}