using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Timeline {
    class TimePoint {
        public static readonly TimePoint FUTURE = new TimePoint {
            Day = long.MaxValue,
            Time = int.MaxValue
        };
        public static readonly TimePoint PAST = new TimePoint {
            Day = long.MinValue,
            Time = int.MinValue
        };

        protected long day;
        protected int time;

        public long Day {
            get {
                return day;
            }
            set {
                day = value;
            }
        }

        public int Time {
            get {
                return time;
            }
            set {
                time = value;
            }
        }
    }
}
