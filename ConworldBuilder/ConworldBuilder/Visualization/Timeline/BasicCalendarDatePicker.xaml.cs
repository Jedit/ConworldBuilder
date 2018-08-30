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
    /// Interaction logic for BasicCalendarDatePicker.xaml
    /// </summary>
    public partial class BasicCalendarDatePicker : UserControl, ICalendarDatePicker {
        public BasicCalendarDatePicker() {
            InitializeComponent();
        }

        private void Beggining_Click(object sender, RoutedEventArgs e) {
            txbDate.Text = TimePoint.Beginning.Day.ToString();
            txbTime.Text = TimePoint.Beginning.Time.ToString();
        }

        private void Forever_Click(object sender, RoutedEventArgs e) {
            txbDate.Text = TimePoint.Forever.Day.ToString();
            txbTime.Text = TimePoint.Forever.Time.ToString();
        }
    }
}
