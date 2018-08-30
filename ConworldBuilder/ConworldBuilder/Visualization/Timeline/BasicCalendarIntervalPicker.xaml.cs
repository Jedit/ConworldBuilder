using ConworldBuilder.Model.Timeline;
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

namespace ConworldBuilder.Visualization.Timeline {
    /// <summary>
    /// Interaction logic for BasicCalendarIntervalPicker.xaml
    /// </summary>
    public partial class BasicCalendarIntervalPicker : UserControl, ICalendarIntervalPicker {
        public BasicCalendarIntervalPicker() {
            InitializeComponent();
        }

        private void Beggining_Click(object sender, RoutedEventArgs e) {
            txbDateF.Text = TimePoint.Beginning.Day.ToString();
            txbTimeF.Text = TimePoint.Beginning.Time.ToString();
        }

        private void AllTime_Click(object sender, RoutedEventArgs e) {
            txbDateF.Text = TimePoint.Beginning.Day.ToString();
            txbTimeF.Text = TimePoint.Beginning.Time.ToString();
            txbDateT.Text = TimePoint.Forever.Day.ToString();
            txbTimeT.Text = TimePoint.Forever.Time.ToString();
        }

        private void Forever_Click(object sender, RoutedEventArgs e) {
            txbDateT.Text = TimePoint.Forever.Day.ToString();
            txbTimeT.Text = TimePoint.Forever.Time.ToString();
        }
    }
}
