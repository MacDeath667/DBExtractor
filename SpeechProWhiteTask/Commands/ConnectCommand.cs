using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SpeechProWhiteTask.ViewModel;

namespace SpeechProWhiteTask.Commands
{
    class ConnectCommand : ICommand
    {
        private readonly MainWindowVM _MainWindowVm;

        public ConnectCommand(MainWindowVM MainWindowVM)
        {
            _MainWindowVm = MainWindowVM;
        }
        
        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrWhiteSpace(_MainWindowVm.Server) &&
                   !string.IsNullOrWhiteSpace(_MainWindowVm.Username) &&
                   !string.IsNullOrWhiteSpace(_MainWindowVm.Database);

        }

        public void Execute(object parameter)
        {
            //BuildBDTable(_MainWindowVm);
        }

        public event EventHandler CanExecuteChanged //realtime check
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value; //snatched from StackOverflow
        }
    }
}
