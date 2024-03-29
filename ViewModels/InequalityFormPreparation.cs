﻿using QuadraticInequalities.Models;
using System.Text;

namespace QuadraticInequalities.ViewModels
{
    public class InequalityFormPreparation
    {
        /// <summary>
        /// Reduces form of inequality
        /// </summary>
        /// <param name="inequality">Original inequality</param>
        /// <returns>Reduced form of inequality like ax^2+bx+c>0</returns>
        public static string GetReducedInequalityForm(Inequality inequality)
        {
            StringBuilder StringBuilder = new();
            if (inequality.A == 0 && inequality.B == 0 && inequality.C == 0)
            {
                StringBuilder.Append(inequality.C);
            }
            else
            {
                if (inequality.A != 0)
                {
                    StringBuilder.Append($"{inequality.A}x^2");
                }
                if (inequality.B != 0)
                {
                    StringBuilder.Append(inequality.B < 0 ? inequality.B : $"+{inequality.B}");
                    StringBuilder.Append('x');
                }
                if (inequality.C != 0)
                {
                    StringBuilder.Append(inequality.C < 0 ? inequality.C : $"+{inequality.C}");
                }
            }
            StringBuilder.Append(inequality.Symbol);
            StringBuilder.Append('0');
            return StringBuilder.ToString();
        }

        /// <summary>
        /// Creates full form of inequality
        /// </summary>
        /// <param name="inequality">Original inequality</param>
        /// <returns>Full form of inequality</returns>
        public static string GetFullInequalityForm(Inequality inequality)
        {
            StringBuilder StringBuilder = new();
            if (inequality.LeftCoefficientA == 0 && inequality.LeftCoefficientB == 0 && inequality.LeftCoefficientC == 0)
            {
                StringBuilder.Append(inequality.LeftCoefficientC);
            }
            else
            {
                if (inequality.LeftCoefficientA != 0)
                {
                    StringBuilder.Append($"{inequality.LeftCoefficientA}x^2");
                }
                if (inequality.LeftCoefficientB != 0)
                {
                    StringBuilder.Append(inequality.LeftCoefficientB < 0 ? inequality.LeftCoefficientB : $"+{inequality.LeftCoefficientB}");
                    StringBuilder.Append('x');
                }
                if (inequality.LeftCoefficientC != 0)
                {
                    StringBuilder.Append(inequality.LeftCoefficientC < 0 ? inequality.LeftCoefficientC : $"+{inequality.LeftCoefficientC}");
                }
            }
            StringBuilder.Append(inequality.Symbol);
            if (inequality.RightCoefficientA == 0 && inequality.RightCoefficientB == 0 && inequality.RightCoefficientC == 0)
            {
                StringBuilder.Append(inequality.RightCoefficientC);
            }
            else
            {
                if (inequality.RightCoefficientA != 0)
                {
                    StringBuilder.Append($"{inequality.RightCoefficientA}x^2");
                }
                if (inequality.RightCoefficientB != 0)
                {
                    StringBuilder.Append(inequality.RightCoefficientB < 0 ? inequality.RightCoefficientB : $"+{inequality.RightCoefficientB}");
                    StringBuilder.Append('x');
                }
                if (inequality.RightCoefficientC != 0)
                {
                    StringBuilder.Append(inequality.RightCoefficientC < 0 ? inequality.RightCoefficientC : $"+{inequality.RightCoefficientC}");
                }
            }
            return StringBuilder.ToString();
        }
    }
}