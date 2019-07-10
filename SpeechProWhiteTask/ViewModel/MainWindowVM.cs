using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using SpeechProWhiteTask.Commands;
using SpeechProWhiteTask.Model;
using SpeechProWhiteTask.Utils;

namespace SpeechProWhiteTask.ViewModel
{
    public class MainWindowVM : BaseNotifyPropertyChanged
    {
        private string _server;
        private string _database;
        private string _username;
        private ObservableCollection<Database> _databases;

        public string Server
        {
            get { return _server; }
            set
            {
                _server = value;
                OnPropertyChanged();
            }
        }

        public string Database
        {
            get { return _database; }
            set
            {
                _database = value;
                OnPropertyChanged();
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Database> DataBases
        {
            get => _databases;
            set
            {
                _databases = value;
                OnPropertyChanged();
            }
        }
        public ICommand BuildDbCommand { get; }

        public MainWindowVM()
        {
            BuildDbCommand = new BuildBDTable(this);
            Server = "DESKTOP-B915095";
            Username = "sa";
            Database = "master";
        }
    }
}