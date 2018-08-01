using ConworldBuilder.Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Timeline {
    /// <summary>
    /// Represent period in time.
    /// </summary>
    class TimeInterval {
        protected TimePoint start;
        protected TimePoint end;
        protected IntervalType type;

        public TimePoint Start {
            get {
                return start;
            }
            set {
                start = value;
            }
        }

        public TimePoint End {
            get {
                return end;
            }
            set {
                end = value;
            }
        }

        public IntervalType Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        public TimeInterval(TimePoint start = null, TimePoint end = null, IntervalType type = IntervalType.InIn) {
            Start = start ?? TimePoint.PAST;
            End = end ?? TimePoint.FUTURE;
            Type = type;
        }

        public override string ToString() {
            return Start.ToString() + " - " + End.ToString();
        }

        public string ToString(ICalendar calendar) {
            return Start.ToString(calendar) + calendar.DateIntervalSeparator + End.ToString(calendar);
        }
    }
}
