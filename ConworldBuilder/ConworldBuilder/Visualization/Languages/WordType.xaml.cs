using ConworldBuilder.Model.General;
using ConworldBuilder.Visualization.Timeline;
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
    /// Interaction logic for WordType.xaml
    /// </summary>
    public partial class WordType : Page {
        internal Model.Languages.WordType Type { get; set; }

        internal WordType(Model.Languages.WordType type) {
            InitializeComponent();
            Type = type;
            this.DataContext = Type;
            var timePicker = (UserControl)Program.ActiveCalendar.GetIntervalPicker();
            gridTime.Children.Add(timePicker);
            Binding binding = new Binding("TimePeriod") {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Source = Type
            };
            timePicker.SetBinding(UserControl.DataContextProperty, binding);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) {
            LangPager.GoBack();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (dgProperities.SelectedItem != null)
                LangPager.GoTo(new WordTypeProperty(Type, (Model.Languages.WordTypeProperty)dgProperities.SelectedItem));
        }

        private void BtnAddProperty_Click(object sender, RoutedEventArgs e) {
            Type.Properties.Add(new Model.Languages.WordTypeProperty(Type.TimePeriod));
        }

        private void BtnRemoveProperty_Click(object sender, RoutedEventArgs e) {
            if (dgProperities.SelectedItem != null)
                Type.Properties.Remove((Model.Languages.WordTypeProperty)dgProperities.SelectedItem);
        }
    }
}
