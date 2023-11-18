using System;

namespace SmthThatIDoNotWantToDo.Extensions
{
    internal static class DoubleExtensions
    {
        public static bool EqualsWithPercision(this double a, double b, double percision = CalculationConsts.Percision)
        {
            return Math.Abs(a - b) <= percision;
        }
    }
}
