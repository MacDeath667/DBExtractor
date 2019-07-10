using System;
using System.Collections.ObjectModel;
using System.Windows.Documents;

namespace SpeechProWhiteTask.Model
{
    public class Database
    {
        public string Name { get; set; }
        public ObservableCollection<Table> Tables { get; set; }

        public Database()
        {
            Name = "DB";
            Tables = new ObservableCollection<Table>();
        }
    }
}
