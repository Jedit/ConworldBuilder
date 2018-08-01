﻿using System;
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
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) {
            LangPager.GoBack();
        }
    }
}