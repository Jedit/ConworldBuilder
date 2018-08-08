using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Timeline {
    class TimePoint : INotifyPropertyChanged {
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

        public event PropertyChangedEventHandler PropertyChanged;

        public long Day {
            get {
                return day;
            }
            set {
                day = value;
                OnPropertyChanged("Day");
            }
        }

        public int Time {
            get {
                return time;
            }
            set {
                time = value;
                OnPropertyChanged("Time");
            }
        }

        public TimePoint(long day = 0, int time = 0) {
            Day = day;
            Time = time;
        }

        public override string ToString() {
            if (this.Day == PAST.Day && this.Time == PAST.Time)
                return "Beginning";
            if (this.Day == FUTURE.Day && this.Time == FUTURE.Time)
                return "Forever";
            return Day.ToString() + ":" + Time.ToString();
        }

        public string ToString(ICalendar calendar) {
            return calendar.GetTimeDate(this);
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
