using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentsMVVM
{
    public class MyCommand : ICommand
    {
        private readonly Action _execute;

        public MyCommand(Action executeMethod)
        {
            _execute = executeMethod;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
