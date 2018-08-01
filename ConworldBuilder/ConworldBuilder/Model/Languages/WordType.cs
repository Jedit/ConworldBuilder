using ConworldBuilder.Model.Timeline;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class WordType : INotifyPropertyChanged {
        private string name;
        private TimeInterval timePeriod;
        private string note;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public ObservableCollection<WordTypeProperty> Properties { get; private set; }

        public TimeInterval TimePeriod {
            get {
                return timePeriod;
            }
            set {
                timePeriod = value;
                OnPropertyChanged("TimePeriod");
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

        public event PropertyChangedEventHandler PropertyChanged;

        public WordType() {
            Properties = new ObservableCollection<WordTypeProperty>();
            Name = "New Word Type";
            Note = "No notes.";
            TimePeriod = new TimeInterval();
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
