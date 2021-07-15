using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ShapesExercise.Helpers;
using ShapesExercise.models;

namespace ShapesExercise.repositories
{
    public class DataRepository : IDataRepository
    {
        private const string rectangle = "RECT";
        private const string circle = "CIRC";
        private const string triangle = "TRIA";


        public string[] ReadFile(string fileName)
        {
            return File.ReadAllLines(fileName);
        }


        public Shape GetDataOfShapesFromString(string rawData)
        {

            string dataInsideParenthesis = StringHandler.GetStringInsideParenthesis(rawData);

            string[] dataAfterSplitComma = StringHandler.SplitStringFollowComma(dataInsideParenthesis);

            string[] dataAfterSplitWhiteSpace = dataAfterSplitComma.Select(data => StringHandler.SplitStringFollowWhiteSpace(data.Trim()))
                                                                    .SelectMany(a => a).ToArray();


            var dataOfShape = StringHandler.ConvertElementFromStringToDouble(dataAfterSplitWhiteSpace);

            string nameShape = rawData.Substring(0, 4);

            switch (nameShape)
            {
                case rectangle:
                    return new Rectangle(dataOfShape[0], dataOfShape[1], dataOfShape[2], dataOfShape[3]);
                case circle:
                    return new Circle(dataOfShape[0], dataOfShape[1], dataOfShape[2]);
                case triangle:
                    Coordinate[] coordinates = {
                        new Coordinate(dataOfShape[0], dataOfShape[1]),
                        new Coordinate(dataOfShape[2], dataOfShape[3]),
                        new Coordinate(dataOfShape[4], dataOfShape[5])
                    };

                    return new Triangle(coordinates);
                default:
                    return null;
            }

        }


    }
}