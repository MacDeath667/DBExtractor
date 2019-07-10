using System;
using System.Collections.ObjectModel;

namespace SpeechProWhiteTask.Model
{
    public class Table
    {
        public string Name { get; set; }
        public ObservableCollection<Column> Columns { get; set; }
    }
}
