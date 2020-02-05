using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenstapelMischenAnsatz {
    class Program {
        static void Main ( string [] args ) {
            Kartenstapel startStapel = new Kartenstapel () { Bezeichnung="StartStapel"};
          
            startStapel.Mischen ();
            startStapel.Show ();

            Console.ReadLine ();
        }
    }
}
