using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticInequalities.Models
{
    public class Inequality
    {
        public int Id { get; set; } 

        public double LeftCoefficientA { get; set; }

        public double LeftCoefficientB { get; set; }

        public double LeftCoefficientC { get; set; }

        public double RightCoefficientA { get; set; }

        public double RightCoefficientB { get; set; }

        public double RightCoefficientC { get; set; }
             
        public string Symbol { get; set; }
       
    }
}
