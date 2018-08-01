using ConworldBuilder.Model.General;
using System;
using System.Collections.Generic;
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
    public partial class LanguageMainWindow : Window {
        public LanguageMainWindow() {
            InitializeComponent();
            if (!World.Active.Languages.Contains(Model.Languages.Language.Active)) {
                Model.Languages.Language.Active = null;
            }
            if (Model.Languages.Language.Active == null) {
                if (World.Active.Languages.Count <= 0) {
                    World.Active.Languages.Add(new Model.Languages.Language());
                }
                Model.Languages.Language.Active = World.Active.Languages[0];
            }
            LangPager.MainWindow = this;
        }

        private void BtnWordTypes_Click(object sender, RoutedEventArgs e) {
            LangPager.GoTo(new WordTypes());
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            LangPager.GoTo(null);
        }
    }
}
