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

namespace ConworldBuilder.Visualization.Conworld {
    /// <summary>
    /// Interaction logic for ConworldMainWindow.xaml
    /// </summary>
    public partial class ConworldMainWindow : IForceCloseableWindow {
        public ConworldMainWindow() {
            InitializeComponent();
            this.DataContext = Program.I.ActiveWorld;
            Program.I.PropertyChanged += (s, e) => {
                if (e.PropertyName == "ActiveWorld")
                    this.DataContext = Program.I.ActiveWorld;
            };
        }

        public bool IsForecedToClose { get; set; }

        public void Window_Closing(object sender, CancelEventArgs e) {
            if (IsForecedToClose)
                return;
            e.Cancel = true;
            Hide();
        }
    }
}
