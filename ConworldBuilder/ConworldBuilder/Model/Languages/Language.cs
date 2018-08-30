using ConworldBuilder.Model.Timeline;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    [JsonObject(MemberSerialization.OptIn)]
    class Language : INotifyPropertyChanged {
        [JsonProperty("name")]
        private string name;
        [JsonProperty("romanization")]
        private Romanization romanization;
        [JsonProperty("timePeriod")]
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

        public Romanization Romanization {
            get {
                return romanization;
            }
            set {
                romanization = value;
                OnPropertyChanged("Romanization");
            }
        }

        public TimeInterval TimePeriod {
            get {
                return timePeriod;
            }
            set {
                timePeriod = value;
                OnPropertyChanged("TimePeriod");
            }
        }

        [JsonProperty("wordTypes")]
        public ObservableCollection<WordType> WordTypes { get; private set; }

        [JsonProperty("words")]
        public ObservableCollection<Word> Words { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Language() {
            WordTypes = new ObservableCollection<WordType>();
            Words = new ObservableCollection<Word>();
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public static Language CreateNewLanguage() {
            Language lang = new Language {
                Name = "New Conlang",
                TimePeriod = new TimeInterval()
            };
            return lang;
        }
    }
}
