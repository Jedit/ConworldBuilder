using ConworldBuilder.Model.General;
using ConworldBuilder.Visualization.General;
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
    /// Interaction logic for WordTypeProperty.xaml
    /// </summary>
    public partial class WordTypeProperty : Page {
        internal Model.Languages.WordType Type { get; set; }

        internal Model.Languages.WordTypeProperty Property { get; set; }

        internal WordTypeProperty(Model.Languages.WordType type, Model.Languages.WordTypeProperty property) {
            InitializeComponent();
            Type = type;
            Property = property;
            this.DataContext = Property;
            tblTypeTitle.DataContext = Type;
            var timePicker = (UserControl)Program.ActiveCalendar.GetIntervalPicker();
            gridTime.Children.Add(timePicker);
            Binding binding = new Binding("TimePeriod") {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Source = Property
            };
            timePicker.SetBinding(UserControl.DataContextProperty, binding);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) {
            LangPager.GoBack();
        }

        private void BtnAddOption_Click(object sender, RoutedEventArgs e) {
            TextInputDialog tid = new TextInputDialog("Add Option", "Insert name of the new option", "New Option");
            if (tid.ShowDialog() == true) {
                Property.Options.Add(new Model.Languages.WordTypePropertyTextOption() { Value = tid.txbInput.Text });
            }
        }

        private void BtnRemoveOption_Click(object sender, RoutedEventArgs e) {
            if(dgOptions.SelectedItem != null) {
                Property.Options.Remove((Model.Languages.IWordTypePropertyOption)dgOptions.SelectedItem);
            }
        }
    }
}
