using QuadraticInequalities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private Inequality inequality;
        public Inequality Inequality
        {
            get { return inequality; }
            set { inequality = value; OnPropertyChanged(nameof(Inequality)); }
        }
    }
}
