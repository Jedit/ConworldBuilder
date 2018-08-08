using ConworldBuilder.Model.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.General {
    class Program {
        private static ICalendar activeCalendar;

        public static ICalendar ActiveCalendar {
            get {
                if (activeCalendar == null)
                    activeCalendar = new BasicCalendar();
                return activeCalendar;
            }
            set {
                activeCalendar = value;
            }
        }
    }
}
