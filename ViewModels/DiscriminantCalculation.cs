using System;

namespace QuadraticInequalities.ViewModels
{
    public class DiscriminantCalculation
    {
        /// <summary>
        /// Calculate discriminant
        /// </summary>
        /// <param name="a">Coefficient A</param>
        /// <param name="b">Coefficient B</param>
        /// <param name="c">Coefficient C</param>
        /// <returns>Calculated discriminant</returns>
        public static double CalculateDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}