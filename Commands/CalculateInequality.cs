using QuadraticInequalities.Models;
using QuadraticInequalities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuadraticInequalities.Commands
{
    public class CalculateInequality : BaseCommand, ICommand
    {
        public CalculateInequality(Inequality inequality, InequalityForms inequalityForms)
        {
            Inequality = inequality;
            InequalityForms = inequalityForms;
        }

        Inequality Inequality { get; set; }

        InequalityForms InequalityForms { get; set; }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Inequality.A = Inequality.LeftCoefficientC - Inequality.RightCoefficientC;
            Inequality.B = Inequality.LeftCoefficientB - Inequality.RightCoefficientB;
            Inequality.C = Inequality.LeftCoefficientC - Inequality.RightCoefficientC;
            double discriminant = DiscriminantCalculation.CalculateDiscriminant(Inequality.A, Inequality.B, Inequality.C);
            Inequality.Discriminant = discriminant;
            Inequality.X1 = UnknownXCalculation.CalculateX(Inequality.A, Inequality.B, discriminant, false);
            Inequality.X2 = UnknownXCalculation.CalculateX(Inequality.A, Inequality.B, discriminant, true);

            InequalityForms.ReducedInequalityForm = InequalityFormPreparation.GetReducedInequalityForm(Inequality);
        }
    }
}
