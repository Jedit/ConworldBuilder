using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Timeline {
    interface ICalendar {
        string DateIntervalSeparator { get; }

        string DatePicker { get; set; }

        string IntervalPicker { get; set; }

        TimePoint GetTimePoint(string timedate);

        TimePoint GetTimePoint(IEnumerable<string> timedate);

        string GetTimeDate(TimePoint timePoint);

        ICalendarDatePicker GetDatePicker();

        ICalendarIntervalPicker GetIntervalPicker();
    }
}
