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
            txbDate.Text = TimePoint.PAST.Day.ToString();
            txbTime.Text = TimePoint.PAST.Time.ToString();
        }

        private void Forever_Click(object sender, RoutedEventArgs e) {
            txbDate.Text = TimePoint.FUTURE.Day.ToString();
            txbTime.Text = TimePoint.FUTURE.Time.ToString();
        }
    }
}
