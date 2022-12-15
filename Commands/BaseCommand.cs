using System;
using System.Windows.Input;

namespace QuadraticInequalities.Commands
{
    public class BaseCommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}