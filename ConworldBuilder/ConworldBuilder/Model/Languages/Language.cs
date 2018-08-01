using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class Language : INotifyPropertyChanged {
        public static Language Active { get; set; }

        private string name;
        private Romanization romanization;

        public string Name { get {
                return name;
            } set {
                name = value;
                OnPropertyChanged("Name");
            } }

        public Romanization Romanization { get {
                return romanization;
            }
            set {
                romanization = value;
                OnPropertyChanged("Romanization");
            }
        }

        public ObservableCollection<WordType> WordTypes { get; private set; }

        public ObservableCollection<Word> Words { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Language() {
            WordTypes = new ObservableCollection<WordType>();
            Words = new ObservableCollection<Word>();
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
