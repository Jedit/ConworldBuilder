using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class WordTypePropertyNumberOption : IWordTypePropertyOption {
        protected int number;

        public string Value {
            get {
                return number.ToString();
            }
            set {
                number = int.Parse(value);
            }
        }

        public override string ToString() {
            return "Number value (" + Value + ")";
        }
    }
}
