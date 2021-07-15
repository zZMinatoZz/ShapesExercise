using System.Collections.Generic;
using System.IO;
using System.Linq;
using ShapesExercise.models;

namespace ShapesExercise.repositories
{
    public class FileSystem : IFileSystem
    {
        public string[] ReadFromFile(string fileName)
        {
            return File.ReadAllLines(fileName);
        }

        public void WriteToFile(string fileName, List<Shape> shapes)
        {
            List<string> allLines = new List<string>();

            foreach (var shape in shapes)
            {
                if (shape.GetType() == typeof(Rectangle))
                {
                    allLines.Add($"RECT({shape.XCoordinate} {shape.YCoordinate}, {shape.Width} {shape.Height})");
                }
                else if (shape.GetType() == typeof(Circle))
                {
                    allLines.Add($"CIRC({shape.XCoordinate} {shape.YCoordinate}, {shape.Radius})");
                }
                else
                {
                    allLines.Add($"TRIA({shape.Coordinates[0].XCoordinate} {shape.Coordinates[0].YCoordinate}, {shape.Coordinates[1].XCoordinate} {shape.Coordinates[1].YCoordinate}, {shape.Coordinates[2].XCoordinate} {shape.Coordinates[2].YCoordinate})");
                }
            }

            File.WriteAllLines(fileName, allLines);
        }
    }
}