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

namespace ConworldBuilder.Visualization.General {
    /// <summary>
    /// Interaction logic for TextInputDialog.xaml
    /// </summary>
    public partial class TextInputDialog : Window {
        private string DefVal { get; set; } = null;

        public TextInputDialog(string title, string desc, string defaultVal = null) {
            InitializeComponent();
            Title = title;
            txtDesc.Text = desc;
            DefVal = defaultVal;
            txbInput.Text = defaultVal ?? "";
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            DialogResult = true;
        }

        private void TxbInput_GotFocus(object sender, RoutedEventArgs e) {
            if (txbInput.Text == DefVal) {
                txbInput.Text = "";
            }
        }

        private void TxbInput_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(txbInput.Text) && !string.IsNullOrWhiteSpace(DefVal)) {
                txbInput.Text = DefVal;
            }
        }
    }
}
