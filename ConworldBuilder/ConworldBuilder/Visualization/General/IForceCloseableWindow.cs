using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Visualization.General {
    interface IForceCloseableWindow {
        bool IsForecedToClose { get; set; }

        void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e);
    }
}
