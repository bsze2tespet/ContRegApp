﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ContRegApp.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action<object> _Execute { get; set; }
        public Predicate<object> _CanExecute { get; set; }
        public RelayCommand(Action<object> ExecuteMethod, Predicate<object> CanExecuteMethod )
        {

            _Execute = ExecuteMethod;
            _CanExecute = CanExecuteMethod;

        }

        public bool CanExecute(object? parameter)
        {
            return
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
