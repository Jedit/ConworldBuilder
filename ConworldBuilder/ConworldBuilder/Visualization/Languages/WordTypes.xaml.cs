using ConworldBuilder.Model.General;
using ConworldBuilder.Model.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConworldBuilder.Visualization.Languages {
    /// <summary>
    /// Interaction logic for WordTypes.xaml
    /// </summary>
    public partial class WordTypes : Page {
        public WordTypes() {
            InitializeComponent();
            dgMain.ItemsSource = Program.I.ActiveConlang.WordTypes;
        }

        private void BtnAdd_Click(object sender, System.Windows.RoutedEventArgs e) {
            Program.I.ActiveConlang.WordTypes.Add(new Model.Languages.WordType());
        }

        private void BtnRemove_Click(object sender, System.Windows.RoutedEventArgs e) {
            if (dgMain.SelectedItem != null) {
                Program.I.ActiveConlang.WordTypes.Remove((Model.Languages.WordType)dgMain.SelectedItem);
            }
        }

        private void BtnEdit_Click(object sender, System.Windows.RoutedEventArgs e) {
            if (dgMain.SelectedItem == null)
                return;
            LangPager.GoTo(new WordType((Model.Languages.WordType)dgMain.SelectedItem));
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            DataGridRow row = (DataGridRow)sender;
            LangPager.GoTo(new WordType((Model.Languages.WordType)row.DataContext));
        }
    }
}
