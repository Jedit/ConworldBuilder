using ConworldBuilder.Model.Timeline;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConworldBuilder.Model.General {
    [JsonObject(MemberSerialization.OptIn)]
    class Program : INotifyPropertyChanged {
        public static readonly String EXEPATH = Directory.GetParent(Assembly.GetExecutingAssembly().Location).ToString() + "\\";

        [JsonProperty("activeCalendar")]
        private ICalendar activeCalendar;

        public static ICalendar ActiveCalendar {
            get {
                if (I.activeCalendar == null)
                    I.activeCalendar = new BasicCalendar();
                return I.activeCalendar;
            }
            set {
                I.activeCalendar = value;
            }
        }

        private static Program instance = null;

        public static Program I {
            get {
                if (instance == null) {
                    instance = new Program();
                }
                return instance;
            }
        }

        private Visualization.Conworld.ConworldMainWindow conworldMainWindow;
        public Visualization.Conworld.ConworldMainWindow ConworldMainWindow {
            get {
                if (conworldMainWindow == null)
                    conworldMainWindow = new Visualization.Conworld.ConworldMainWindow();
                return conworldMainWindow;
            }
            set {
                conworldMainWindow = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Visualization.Languages.LanguageMainWindow languageMainWindow;
        public Visualization.Languages.LanguageMainWindow LanguageMainWindow {
            get {
                if (languageMainWindow == null)
                    languageMainWindow = new Visualization.Languages.LanguageMainWindow();
                return languageMainWindow;
            }
            set {
                languageMainWindow = value;
            }
        }

        private World activeWorld;
        public World ActiveWorld {
            get {
                return activeWorld;
            }
            set {
                //TODO all the saving and etc...
                activeWorld = value;
                OnPropertyChanged("ActiveWorld");
                OnPropertyChanged("IsActiveWorld");
            }
        }
        public bool IsActiveWorld {
            get {
                return (ActiveWorld != null);
            }
        }

        private Languages.Language activeConlang;
        public Languages.Language ActiveConlang {
            get {
                return activeConlang;
            }
            set {
                activeConlang = value;
                OnPropertyChanged("ActiveConlang");
                OnPropertyChanged("IsActiveConlang");
            }
        }
        public bool IsActiveConlang {
            get {
                return (ActiveConlang != null);
            }
        }

        private Program() {

        }

        public static void Init() {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings {
                Formatting = Formatting.Indented,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            try {
                Program program = JsonConvert.DeserializeObject<Program>(File.ReadAllText(EXEPATH + "Program_Setting.json"));
                instance = program;
            }
            catch (Exception) {
                MessageBox.Show("Error loading program configuration!");
            }
        }

        public static void LoadWorld(string path) {
            try {
                World world = JsonConvert.DeserializeObject<World>(File.ReadAllText(path));
                Program.I.ActiveWorld = world;
            }
            catch (Exception) {
                MessageBox.Show("Invalid world file or error reading it.");
            }
        }

        internal static void SaveWorld(string fileName) {
            try {
                string s = JsonConvert.SerializeObject(Program.I.ActiveWorld);
                File.WriteAllText(fileName, s);
            }
            catch (Exception) {
                MessageBox.Show("Error saving world as \"" + fileName + "\"");
            }
        }

        internal static T CloneModelPart<T>(T source) {
            string s = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(s);
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
