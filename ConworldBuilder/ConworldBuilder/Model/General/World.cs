using ConworldBuilder.Model.Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.General {
    [JsonObject(MemberSerialization.OptIn)]
    class World : INotifyPropertyChanged {
        private string name;

        [JsonProperty("name")]
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        [JsonProperty("languages")]
        public ObservableCollection<Language> Languages { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private World() {
            Languages = new ObservableCollection<Language>();
        }

        public bool AddLanguage(Language language) {// irelevant?
            if (this.Languages.Contains(language))
                return false;
            Languages.Add(language);
            return true;
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public static World CreateNewWorld() {
            World world = new World {
                Name = "New Conworld"
            };

            return world;
        }

    }
}
