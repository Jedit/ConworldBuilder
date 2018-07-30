using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConworldBuilder.Model.Languages {
    class WordType {
        public string Name { get; set; }

        public List<WordTypeProperty> Properties { get; set; }
    }
}
