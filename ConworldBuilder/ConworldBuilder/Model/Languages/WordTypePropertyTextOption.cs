using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class WordTypePropertyTextOption : IWordTypePropertyOption {
        protected string text;

        public string Value {
            get {
                return text;
            }
            set {
                text = value;
            }
        }
    }
}
