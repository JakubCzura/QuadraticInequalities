using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticInequalities.ViewModels
{
    public class CoefficientCalculation
    {
        /// <summary>
        /// Subtracts right coefficient from left coefficient
        /// </summary>
        /// <param name="leftCoefficient">Left coefficient</param>
        /// <param name="rightCoefficient">Right coefficient</param>
        /// <returns>Result of subtraction right coefficient from left coefficient</returns>
        public static double CalcuateCoefficient(double leftCoefficient, double rightCoefficient)
        {
            return leftCoefficient - rightCoefficient;
        }
    }
}
