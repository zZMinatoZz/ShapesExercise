using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ShapesExercise.models;
using ShapesExercise.repositories;

namespace ShapesExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            IFileSystem fileSystem = new FileSystem();
            IDataRepository repo = new DataRepository();

            string[] dataFromFile = fileSystem.ReadFromFile("Shapes.txt");

            List<Shape> Shapes = new List<Shape>();

            foreach (var item in dataFromFile)
            {
                Shapes.Add(repo.GetDataOfShapesFromString(item));
            }


            // 1
            foreach (var shape in Shapes)
            {
                
                if (typeof(Rectangle) == shape.GetType())
                {
                    shape.MoveRight(5);
                }
            }

            // 2
            foreach (var shape in Shapes)
            {
                if (typeof(Circle) == shape.GetType())
                {
                    shape.Transform(2);
                }
            }

            // 3
            foreach (var shape in Shapes)
            {
                shape.MoveUp(2);
                shape.MoveLeft(2);
            }

            // 4
            foreach (var shape in Shapes)
            {
                if (typeof(Triangle) == shape.GetType()) {
                    shape.Rotate(45);
                }
            }

            // 5
            foreach (var shape in Shapes)
            {
                if (typeof(Rectangle) == shape.GetType())
                {
                    shape.Transform(2);
                }
            }

            fileSystem.WriteToFile("Shapes.txt", Shapes);
        }

    }
}
