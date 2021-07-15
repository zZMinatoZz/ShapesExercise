using System;
using System.Linq;

namespace ShapesExercise.Helpers
{
    public static class StringHandler
    {
        public static string GetStringInsideParenthesis(string stringData)
        {
            return stringData.Split('(', ')')[1];
        }

        public static string[] SplitStringFollowComma(string stringData)
        {
            return stringData.Split(',');
        }

        public static string[] SplitStringFollowWhiteSpace(string stringData)
        {
            return stringData.Split(' ');
        }

        public static double[] ConvertElementFromStringToDouble(string[] stringData)
        {
            try
            {
                return stringData.Select(item => double.Parse(item.ToString())).ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}