﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDemo
{
    class Command : ICommand
    {
        Action<object> executeMethod;
        Func<object, bool> canexecuteMethod;

        public Command(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return false;
        }

        public void Execute(object? parameter)
        {
            executeMethod(parameter);   
        }
    }
}
