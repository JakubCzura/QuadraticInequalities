using CommunityToolkit.Mvvm.Input;
using QuadraticInequalities.Models;
using System;
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
            InequalityForms = new InequalityForms();
            CalculateInequalityCommand = new RelayCommand<object>(SetInequality);
            ChooseInequalitySymbolCommand = new RelayCommand<object>(SetSymbol);
            ResetLeftCoefficientsCommand = new RelayCommand(ResetLeftCoefficients);
            ResetRightCoefficientsCommand = new RelayCommand(ResetRightCoefficients);
            ResetCoefficientsCommand = new RelayCommand(ResetCoefficients);
        }

        public ICommand CalculateInequalityCommand { get; private set; }

        public ICommand ChooseInequalitySymbolCommand { get; private set; }

        public ICommand ResetLeftCoefficientsCommand { get; private set; }
        public ICommand ResetRightCoefficientsCommand { get; private set; }
        public ICommand ResetCoefficientsCommand { get; private set; }

        private Inequality inequality;

        public Inequality Inequality
        {
            get { return inequality; }
            set { inequality = value; OnPropertyChanged(); }
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

        public string StandardInequalityForm
        {
            get { return InequalityForms.StandardInequalityForm; }
            set { InequalityForms.StandardInequalityForm = value; OnPropertyChanged(); }
        }

        public string ReducedInequalityForm
        {
            get { return InequalityForms.ReducedInequalityForm; }
            set { InequalityForms.ReducedInequalityForm = value; OnPropertyChanged(); }
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

        public double X1
        {
            get { return Inequality.X1; }
            set { Inequality.X1 = value; OnPropertyChanged(); }
        }

        public double X2
        {
            get { return Inequality.X2; }
            set { Inequality.X2 = value; OnPropertyChanged(); }
        }

        public double Discriminant
        {
            get { return Inequality.Discriminant; }
            set { Inequality.Discriminant = value; OnPropertyChanged(); }
        }

        public string Result
        {
            get { return Inequality.Result; }
            set { Inequality.Result = value; OnPropertyChanged(); }
        }

        public void SetInequality(object parameter)
        {
            try
            {
                Inequality.A = CoefficientCalculation.CalcuateCoefficient(Inequality.LeftCoefficientA, Inequality.RightCoefficientA);
                Inequality.B = CoefficientCalculation.CalcuateCoefficient(Inequality.LeftCoefficientB, Inequality.RightCoefficientB);
                Inequality.C = CoefficientCalculation.CalcuateCoefficient(Inequality.LeftCoefficientC, Inequality.RightCoefficientC);
                Discriminant = DiscriminantCalculation.CalculateDiscriminant(Inequality.A, Inequality.B, Inequality.C);
                X1 = UnknownXCalculation.CalculateX(Inequality.A, Inequality.B, Discriminant, false);
                X2 = UnknownXCalculation.CalculateX(Inequality.A, Inequality.B, Discriminant, true);
                ReducedInequalityForm = InequalityFormPreparation.GetReducedInequalityForm(Inequality);
                StandardInequalityForm = InequalityFormPreparation.GetFullInequalityForm(Inequality);
                Result = ResultCalculation.CalculateResult(Inequality);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetLeftCoefficients()
        {
            LeftCoefficientA = 0;
            LeftCoefficientB = 0;
            LeftCoefficientC = 0;
        }

        public void ResetRightCoefficients()
        {
            RightCoefficientA = 0;
            RightCoefficientB = 0;
            RightCoefficientC = 0;
        }

        public void ResetCoefficients()
        {
            ResetLeftCoefficients();
            ResetRightCoefficients();
        }

        public void SetSymbol(object parameter)
        {
            try
            {
                if (parameter != null)
                {
                    string symbol = parameter.ToString();
                    if (String.IsNullOrWhiteSpace(symbol) == false)
                    {
                        Inequality.Symbol = symbol;
                        StandardInequalityForm = InequalityFormPreparation.GetFullInequalityForm(Inequality);
                    }
                }
            }
            catch
            {
                Inequality.Symbol = ">=";
                MessageBox.Show("Inequality symbol - parameter exception. Default symbol set");
            }
        }
    }
}