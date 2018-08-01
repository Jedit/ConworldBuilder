using ConworldBuilder.Model.Languages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.General {
    class World {
        private static World activeWorld;

        public static World Active {
            get {
                if(activeWorld == null) {
                    activeWorld = new World();
                }
                return activeWorld;
            }
        }

        public ObservableCollection<Language> Languages { get; }

        private World() {
            Languages = new ObservableCollection<Language>();
        }

        public bool AddLanguage(Language language) {// irelevant?
            if (this.Languages.Contains(language))
                return false;
            Languages.Add(language);
            return true;
        }

    }
}
