using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace CommandDemo
{
    
    class ViewModel
    {
        public ICommand myProperty { get; set; }
        public ViewModel() {
            myProperty = new Command(ExecuteMethod, canExecuteMethod);
        }
        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod(object parameter)
        {
            MessageBox.Show("No Code Behind!");
        }
    }
}
