﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ContRegApp.Commands;
using ContRegApp.Models;
using ContRegApp.Views;

namespace ContRegApp.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddUser addUserWin = new AddUser();
            addUserWin.Show();
        }
    }
}
