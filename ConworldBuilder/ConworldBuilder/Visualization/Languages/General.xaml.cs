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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConworldBuilder.Visualization.Languages {
    /// <summary>
    /// Interaction logic for General.xaml
    /// </summary>
    public partial class General : Page {
        public General() {
            InitializeComponent();
            this.DataContext = Program.I.ActiveConlang;
            Program.I.PropertyChanged += (s, e) => {
                if (e.PropertyName == "ActiveConlang") {
                    this.DataContext = Program.I.ActiveConlang;
                }
            };
            var timePicker = (UserControl)Program.ActiveCalendar.GetIntervalPicker();
            gridTime.Children.Add(timePicker);
            Binding binding = new Binding("TimePeriod") {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            timePicker.SetBinding(UserControl.DataContextProperty, binding);
        }
    }
}
