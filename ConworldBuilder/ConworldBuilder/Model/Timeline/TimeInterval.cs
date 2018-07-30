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
    }
}
