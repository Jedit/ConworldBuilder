using ConworldBuilder.Model.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class WordTypeProperty {
        public string Name { get; set; }
        public bool IsDefinedByDict { get; set; }
        public List<IWordTypePropertyOption> Options { get; set; }

        public TimeInterval TimePeriod { get; set; }
    }
}
