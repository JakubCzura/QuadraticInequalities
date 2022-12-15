using QuadraticInequalities.Models;
using QuadraticInequalities.ViewModels;
using QuadraticInequalities.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuadraticInequalities.Commands
{
    public class ChooseInequalitySymbolCommand : BaseCommand, ICommand
    {
        public ChooseInequalitySymbolCommand(MainWindowVM mainWindowVM)
        {
            MainWindowVM = mainWindowVM;
        }
        public MainWindowVM MainWindowVM { get; set; }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            try
            {
                if (parameter != null)
                {
                    string symbol= parameter.ToString();
                    if(String.IsNullOrWhiteSpace(symbol) == false)
                    {
                        MainWindowVM.Symbol = symbol;
                    }                   
                }
            }
            catch
            {
                MainWindowVM.Symbol = ">=";
                MessageBox.Show("Inequality symbol - parameter exception. Default symbol set");
            }
        }
    }
}
