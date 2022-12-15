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

        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public double LeftCoefficientA { get; set; }

        public double LeftCoefficientB { get; set; }

        public double LeftCoefficientC { get; set; }

        public double RightCoefficientA { get; set; }

        public double RightCoefficientB { get; set; }

        public double RightCoefficientC { get; set; }
        
        public double X1 { get; set; }

        public double X2 { get; set; }

        public double Discriminant { get; set; }

        public string Symbol { get; set; }

        public string Result { get; set; }
       
    }
}
