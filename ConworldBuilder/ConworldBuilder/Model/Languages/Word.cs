using ConworldBuilder.Model.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class Word {
        public string ID { get; set; }

        public WordType Type { get; set; }

        public List<KeyValuePair<WordTypeProperty, IWordTypePropertyOption>> Properties;

        public string Romanization { get; set; }

        public List<KeyValuePair<Definition, TimeInterval>> Definitions;
    }
}
