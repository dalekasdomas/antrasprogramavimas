using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Daiktas
    {
        public string pavadinimas { get; set; }
        public double kaina { get; set; }

        public void gautiDaiktas(string Pavadinimas,double Kaina)
        {
            this.kaina = Kaina;
            this.pavadinimas = Pavadinimas;
        }
    }
}
