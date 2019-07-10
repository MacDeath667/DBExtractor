using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SpeechProWhiteTask.Model;
using SpeechProWhiteTask.ViewModel;

namespace SpeechProWhiteTask.Commands
{
    public class BuildBDTable : ICommand
    {
        private MainWindowVM _mainWindowVm;
        private string password;

        public BuildBDTable(MainWindowVM mainWindowVm)
        {
            _mainWindowVm = mainWindowVm;
        }

        public bool CanExecute(object parameter)
        {
            return (!string.IsNullOrWhiteSpace(_mainWindowVm.Server) &&
                    !string.IsNullOrWhiteSpace(_mainWindowVm.Username) &&
                    !string.IsNullOrWhiteSpace(_mainWindowVm.Database));
        }

        public void Execute(object parameter)
        {
            password = (parameter as PasswordBox)?.Password;

            _mainWindowVm.DataBases = new InfoExtractorDB().BuildDB( _mainWindowVm.Server, _mainWindowVm.Database, _mainWindowVm.Username, password);
        }

        public event EventHandler CanExecuteChanged //realtime check
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value; //snatched from StackOverflow
        }


    }
}
