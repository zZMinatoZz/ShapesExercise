using System.Collections.Generic;
using ShapesExercise.models;

namespace ShapesExercise.repositories
{
    public interface IDataRepository
    {
        string[] ReadFile(string fileName);
        Shape GetDataOfShapesFromString(string rawData);

    }
}