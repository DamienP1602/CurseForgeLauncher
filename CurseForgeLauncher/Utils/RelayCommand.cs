﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurseForgeLauncher
{
    public class RelayCommand : ICommand
    {
        public Action<object>? execute = null;
        public Func<object, bool>? canExecute = null;
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public RelayCommand(Action<object>? _execute, Func<object, bool>? _canExecutge = null)
        {
            execute = _execute;
            canExecute = _canExecutge;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute?.Invoke(parameter);
        }
    }
}
