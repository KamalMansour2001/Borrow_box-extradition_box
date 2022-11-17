using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lånabox
{
    class Låda
    {
        public int Nummer { get; set; }
        public bool Ledig { get; set; }
        public DateTime LåneDatum { get; set; }

        public Låda(int nummer, bool ledig, DateTime låneddatum)
        {
            this.Nummer = nummer;
            this.Ledig = ledig;
            this.LåneDatum = låneddatum;
        }
    }
}
