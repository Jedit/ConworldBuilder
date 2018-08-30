using ConworldBuilder.Model.Timeline;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class WordTypeProperty : INotifyPropertyChanged {
        private string name;
        private string note;
        private bool isDefinedByDict;
        private TimeInterval timePeriod;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Note {
            get {
                return note;
            }
            set {
                note = value;
                OnPropertyChanged("Note");
            }
        }
        public bool IsDefinedByDict {
            get {
                return isDefinedByDict;
            }
            set {
                isDefinedByDict = value;
                OnPropertyChanged("IsDefinedByDict");
            }
        }
        public ObservableCollection<IWordTypePropertyOption> Options { get; set; }

        public TimeInterval TimePeriod {
            get {
                return timePeriod;
            }
            set {
                timePeriod = value;
                OnPropertyChanged("TimePeriod");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public WordTypeProperty(TimeInterval period = null) {
            Name = "New Property";
            Note = "No notes";
            IsDefinedByDict = false;
            TimePeriod = period ?? new TimeInterval();
            Options = new ObservableCollection<IWordTypePropertyOption>();
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
