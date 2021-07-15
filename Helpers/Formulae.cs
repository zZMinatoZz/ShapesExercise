using System;
using ShapesExercise.models;

namespace ShapesExercise.Helpers
{
    public static class Formulae
    {
        public static Coordinate RotatePoint(Coordinate coordinatePoint, Coordinate centerPoint, double angleDegrees)
        {
            double angleInRadians = angleDegrees * (Math.PI / 180);
            double cosRad = Math.Cos(angleInRadians);
            double sinRad = Math.Sin(angleInRadians);

            return new Coordinate
            {
                XCoordinate = cosRad * (coordinatePoint.XCoordinate - centerPoint.XCoordinate)
                                    - sinRad * (coordinatePoint.YCoordinate - centerPoint.YCoordinate) + centerPoint.XCoordinate,
                YCoordinate = sinRad * (coordinatePoint.XCoordinate - centerPoint.XCoordinate)
                                    - cosRad * (coordinatePoint.YCoordinate - centerPoint.YCoordinate) + centerPoint.YCoordinate
            };
        }
    }
}