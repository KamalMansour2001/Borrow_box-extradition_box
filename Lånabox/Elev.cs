using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lånabox
{
    class Elev
    {
        public string Namn { get; set; }

        public string Klass { get; set; }

        public string Användernamn { get; set; }

        public string Lössenord { get; set; }


        public bool LånatLåda { get; set; }

        public int Lådnummer { get; set; }
        public Elev(string namn, string klass, string anvnamn, string lössen, bool lånatlåda, int lådnummer)    
        {
            this.Namn = namn;
            this.Klass = klass;
            this.Användernamn = anvnamn;
            this.Lössenord = lössen;
            this.LånatLåda = lånatlåda;
            this.Lådnummer = lådnummer;
        }

    }
}
