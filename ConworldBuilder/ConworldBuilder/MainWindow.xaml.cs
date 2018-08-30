using ConworldBuilder.Model.General;
using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConworldBuilder {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Program.Init();
            this.DataContext = Program.I;
            Program.I.PropertyChanged += (s, e) => {
                if (e.PropertyName == "IsActiveWorld" && Program.I.IsActiveWorld == false) {
                    CloseAllSecondaryWindows();
                }
            };
        }

        private void BtnConworldInfo_Click(object sender, RoutedEventArgs e) {
            if (Program.I.ConworldMainWindow.IsVisible) {
                Program.I.ConworldMainWindow.Hide();
            }
            else {
                Program.I.ConworldMainWindow.Show();
            }
        }

        private void BtnConlangs_Click(object sender, RoutedEventArgs e) {
            if (Program.I.LanguageMainWindow.IsVisible) {
                Program.I.LanguageMainWindow.Hide();
            }
            else {
                Program.I.LanguageMainWindow.Show();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            CloseAllSecondaryWindows(false);
        }

        private void BtnOpenWorld_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "Conworld Builder Worlds (*.cwbw)|*cwbw|JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select World file..."
            };
            if (ofd.ShowDialog() == true) {
                Program.LoadWorld(ofd.FileName);
            }
        }

        private void btnSaveAsWorld_Click(object sender, RoutedEventArgs e) {
            SaveAs();
        }

        private void SaveAs() {
            SaveFileDialog sfd = new SaveFileDialog {
                Filter = "Conworld Builder Worlds (*.cwbw)|*cwbw|JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Save World as...",
                AddExtension = true,
                DefaultExt = "cwbw"
            };
            if (sfd.ShowDialog() == true) {
                Program.SaveWorld(sfd.FileName);
            }
        }

        private void CloseAllSecondaryWindows(bool reinitThem = true) {
            Program.I.ConworldMainWindow.IsForecedToClose = true;
            Program.I.ConworldMainWindow.Close();
            Program.I.ConworldMainWindow = null;
            Program.I.LanguageMainWindow.IsForecedToClose = true;
            Program.I.LanguageMainWindow.Close();
            Program.I.LanguageMainWindow = null;
        }

        private void BtnNewWorld_Click(object sender, RoutedEventArgs e) {
            Program.I.ActiveWorld = World.CreateNewWorld();
        }

        private void BtnCloseWorld_Click(object sender, RoutedEventArgs e) {
            //TODO Save?
            Program.I.ActiveWorld = null;
        }
    }
}
