using QuadraticInequalities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticInequalities.ViewModels
{
    public class XComparer
    {
        /// <summary>
        /// Compares X1 and X2 and swaps their values if X2 if bigger than X1
        /// </summary>
        /// <param name="inequality">Inequality to calculate</param>
        public static void CompareX(Inequality inequality)
        {
            if(inequality.X1 > inequality.X2)
            {
                (inequality.X1, inequality.X2) = (inequality.X2, inequality.X1);
            }
        }
    }
}
