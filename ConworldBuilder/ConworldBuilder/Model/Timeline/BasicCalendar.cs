using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Timeline {
    class BasicCalendar : ICalendar {
        public string DateIntervalSeparator => ":";

        public string DatePicker { get; set; } = typeof(Visualization.Timeline.BasicCalendarDatePicker).AssemblyQualifiedName;
        public string IntervalPicker { get; set; } = typeof(Visualization.Timeline.BasicCalendarIntervalPicker).AssemblyQualifiedName;

        public ICalendarDatePicker GetDatePicker() {
            return (ICalendarDatePicker)Activator.CreateInstance(Type.GetType(DatePicker));
        }

        public ICalendarIntervalPicker GetIntervalPicker() {
            return (ICalendarIntervalPicker)Activator.CreateInstance(Type.GetType(IntervalPicker));
        }

        public string GetTimeDate(TimePoint timePoint) {
            return timePoint.ToString();
        }

        public TimePoint GetTimePoint(string timedate) {
            throw new NotImplementedException();
        }

        public TimePoint GetTimePoint(IEnumerable<string> timedate) {
            throw new NotImplementedException();
        }
    }
}
