using QuadraticInequalities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticInequalities.ViewModels
{
    public class InequalityFormPreparation
    {
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
            return StringBuilder.ToString();
        }
    }
}
