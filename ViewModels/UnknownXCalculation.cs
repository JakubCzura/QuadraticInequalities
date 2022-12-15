﻿using System;

namespace QuadraticInequalities.ViewModels
{
    public class UnknownXCalculation
    {
        /// <summary>
        /// Calculate X
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <param name="discriminant">discriminant</param>
        /// <param name="subtractOrAddDiscriminant">False if discriminant must be subtracted from (-b). True if discriminant must be added to (-b).</param>
        /// <returns>Calculated X</returns>
        public static double CalculateX(double a, double b, double discriminant, bool subtractOrAddDiscriminant)
        {
            if (discriminant >= 0)
            {
                if (subtractOrAddDiscriminant == false)
                {
                    return (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                else
                {
                    return (-b + Math.Sqrt(discriminant)) / (2 * a);
                }
            }
            else
            {
                throw new ArgumentException("Negative discriminant is not allowed to calculate inequality");
            }
        }
    }
}