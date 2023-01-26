﻿using CommunityToolkit.Mvvm.Input;
using QuadraticInequalities.Commands;
using QuadraticInequalities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
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
            InequalityForms = new InequalityForms();
            CalculateInequalityCommand = new RelayCommand<object>(SetInequality);
            ChooseInequalitySymbolCommand = new RelayCommand<object>(SetSymbol);
        }

        public ICommand CalculateInequalityCommand { get; private set; }

        public ICommand ChooseInequalitySymbolCommand { get; private set; }

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
                Inequality.A = Inequality.LeftCoefficientA - Inequality.RightCoefficientA;
                Inequality.B = Inequality.LeftCoefficientB - Inequality.RightCoefficientB;
                Inequality.C = Inequality.LeftCoefficientC - Inequality.RightCoefficientC;
                double discriminant = DiscriminantCalculation.CalculateDiscriminant(Inequality.A, Inequality.B, Inequality.C);
                Discriminant = discriminant;
                X1 = UnknownXCalculation.CalculateX(Inequality.A, Inequality.B, discriminant, false);
                X2 = UnknownXCalculation.CalculateX(Inequality.A, Inequality.B, discriminant, true);

                ReducedInequalityForm = InequalityFormPreparation.GetReducedInequalityForm(Inequality);
                StandardInequalityForm = InequalityFormPreparation.GetFullInequalityForm(Inequality);
                Result = ResultCalculation.CalculateResult(Inequality);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
