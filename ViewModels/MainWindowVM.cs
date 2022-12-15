using QuadraticInequalities.Commands;
using QuadraticInequalities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuadraticInequalities.ViewModels
{
    /// <summary>
    /// View model for MainWindow.xaml
    /// </summary>
    public class MainWindowVM : BaseViewModel
    {
        public MainWindowVM()
        {
            Inequality = new Inequality();
            InequalityForms= new InequalityForms();
            CalculateInequality = new CalculateInequality(Inequality, InequalityForms);
            ChooseInequalitySymbolCommand = new ChooseInequalitySymbolCommand(this);
        }

        public ICommand CalculateInequality { get; set; }

        public ICommand ChooseInequalitySymbolCommand { get; set; }

        private Inequality inequality;
        public Inequality Inequality
        {
            get { return inequality; }
            set { inequality = value; OnPropertyChanged(nameof(Inequality));}
        }

        private Inequality reducedInequality;
        public Inequality ReducedInequality
        {
            get { return reducedInequality; }
            set { reducedInequality = value; OnPropertyChanged(); }
        }

        private InequalityForms inequalityForms;

        public InequalityForms InequalityForms
        {
            get { return inequalityForms; }
            set { inequalityForms = value; OnPropertyChanged(); }
        }

        public double LeftCoefficientA
        {
            get { return Inequality.LeftCoefficientA; }
            set { Inequality.LeftCoefficientA = value; OnPropertyChanged(); }
        }

        public double LeftCoefficientB
        {
            get { return Inequality.LeftCoefficientB; }
            set { Inequality.LeftCoefficientB = value; OnPropertyChanged(); }
        }

        public double LeftCoefficientC
        {
            get { return Inequality.LeftCoefficientC; }
            set { Inequality.LeftCoefficientC = value; OnPropertyChanged(); }
        }

        public double RightCoefficientA
        {
            get { return Inequality.RightCoefficientA; }
            set { Inequality.RightCoefficientA = value; OnPropertyChanged(); }
        }

        public double RightCoefficientB
        {
            get { return Inequality.RightCoefficientB; }
            set { Inequality.RightCoefficientB = value; OnPropertyChanged(); }
        }

        public double RightCoefficientC
        {
            get { return Inequality.RightCoefficientC; }
            set { Inequality.RightCoefficientC = value; OnPropertyChanged(); }
        }

        public string Symbol
        {
            get { return Inequality.Symbol; }
            set { Inequality.Symbol = value; OnPropertyChanged(); }
        }
    }
}
