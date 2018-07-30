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
        }

        private void BtnWordTypes_Click(object sender, RoutedEventArgs e) {
            pageMain.Source = new Uri("WordTypes.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            pageMain.Source = null;
        }
    }
}
