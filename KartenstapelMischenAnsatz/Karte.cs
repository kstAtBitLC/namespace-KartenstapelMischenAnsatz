using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenstapelMischenAnsatz {
    class Karte {
        public string Farbe { get; set; }
        public string Bezeichnung { get; set; }

        public string ToString () {
            return ( "Farbe: " + Farbe + "\t Bezeichnung:" + Bezeichnung );
        }
    }
}
