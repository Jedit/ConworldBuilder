using ConworldBuilder.Model.General;
using ConworldBuilder.Visualization.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConworldBuilder.Visualization.Languages {
    /// <summary>
    /// Interaction logic for LanguageMainWindow.xaml
    /// </summary>
    public partial class LanguageMainWindow : IForceCloseableWindow {
        private Model.Languages.Language openedLang = null;

        public LanguageMainWindow() {
            InitializeComponent();
            this.DataContext = Program.I;
            Program.I.PropertyChanged += (s, e) => {
                if (e.PropertyName == "ActiveConlang") {
                    LangPager.Reset();
                }
            };
            LangPager.MainWindow = this;
        }

        public bool IsForecedToClose { get; set; }

        public void Window_Closing(object sender, CancelEventArgs e) {
            if (IsForecedToClose)
                return;
            e.Cancel = true;
            Hide();
        }

        private void BtnWordTypes_Click(object sender, RoutedEventArgs e) {
            LangPager.GoTo(new WordTypes());
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            LangPager.GoTo(null);
        }

        private void BtnOpenConlang_Click(object sender, RoutedEventArgs e) {
            OpenConlangDialog ocd = new OpenConlangDialog();
            if (ocd.ShowDialog() == true) {
                if (ocd.dgLangs.SelectedItem != null) {
                    openedLang = (Model.Languages.Language)ocd.dgLangs.SelectedItem;
                    Program.I.ActiveConlang = Program.CloneModelPart(openedLang);
                }
            }
        }

        private void BtnNewConlang_Click(object sender, RoutedEventArgs e) {
            Model.Languages.Language lang = Model.Languages.Language.CreateNewLanguage();
            Program.I.ActiveWorld.Languages.Add(lang);
            openedLang = lang;
            Program.I.ActiveConlang = Program.CloneModelPart(lang);
        }

        private void BtnCloseConlang_Click(object sender, RoutedEventArgs e) {
            Program.I.ActiveConlang = null;
            openedLang = null;
        }

        private void BtnDeleteConlang_Click(object sender, RoutedEventArgs e) {
            Program.I.ActiveConlang = null;
            Program.I.ActiveWorld.Languages.Remove(openedLang);
            openedLang = null;
        }

        private void BtnSaveConlang_Click(object sender, RoutedEventArgs e) {
            Program.I.ActiveWorld.Languages.Remove(openedLang);
            openedLang = Program.I.ActiveConlang;
            Program.I.ActiveWorld.Languages.Insert(0, openedLang);
            Program.I.ActiveConlang = Program.CloneModelPart(openedLang);
        }

        private void BtnSaveAsConlang_Click(object sender, RoutedEventArgs e) {
            Program.I.ActiveConlang.Name += "_copy";
            openedLang = Program.I.ActiveConlang;
            Program.I.ActiveWorld.Languages.Insert(0, openedLang);
            Program.I.ActiveConlang = Program.CloneModelPart(openedLang);
        }

        private void BtnGeneral_Click(object sender, RoutedEventArgs e) {
            LangPager.GoTo(new General());
        }
    }
}
