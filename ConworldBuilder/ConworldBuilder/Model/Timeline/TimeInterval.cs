using ConworldBuilder.Model.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Timeline {
    /// <summary>
    /// Represent period in time.
    /// </summary>
    class TimeInterval : INotifyPropertyChanged {
        protected TimePoint start;
        protected TimePoint end;
        protected IntervalType type;

        public event PropertyChangedEventHandler PropertyChanged;

        public TimePoint Start {
            get {
                return start;
            }
            set {
                if (Start != null)
                    Start.PropertyChanged -= Start_PropertyChanged;
                start = value;
                OnPropertyChanged("Start");
                Start.PropertyChanged += Start_PropertyChanged;
            }
        }

        private void Start_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            OnPropertyChanged("Start");
        }

        public TimePoint End {
            get {
                return end;
            }
            set {
                if (End != null)
                    End.PropertyChanged -= End_PropertyChanged;
                end = value;
                OnPropertyChanged("End");
                End.PropertyChanged += End_PropertyChanged;
            }
        }

        private void End_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            OnPropertyChanged("End");
        }

        public IntervalType Type {
            get {
                return type;
            }
            set {
                type = value;
                OnPropertyChanged("Type");
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

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
