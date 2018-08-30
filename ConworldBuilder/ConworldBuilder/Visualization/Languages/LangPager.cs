using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConworldBuilder.Visualization.Languages {
    class LangPager {
        public static Visualization.Languages.LanguageMainWindow MainWindow { private get; set; }

        private static List<Page> history = new List<Page>();

        public static void GoTo(Page page) {
            history.Add(page);
            SwitchTo(history.Count - 1);
        }

        public static void GoBack() {
            if (history.Count >= 1)
                history.RemoveAt(history.Count - 1);
            SwitchTo(history.Count - 1);
        }

        private static void SwitchTo(int index) {
            Page p = (index >= 0) ? history[index] : null;
            MainWindow.pageMain.Content = p;
        }

        internal static void Reset() {
            MainWindow.pageMain.Content = null;
            history = new List<Page>();
        }
    }
}
