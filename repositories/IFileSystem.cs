using System.Collections.Generic;
using ShapesExercise.models;

namespace ShapesExercise.repositories
{
    public interface IFileSystem
    {
        string[] ReadFromFile(string fileName);

        void WriteToFile(string fileName, List<Shape> shapes);

    }
}