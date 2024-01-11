using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Medicaments
{
    internal class Medicament
    {
        private int id_med;
        private string libelle_med;
        private string contre_indication;

        public Medicament(int id, string libelle, string contre_indication)
        {
            id_med = id;
            libelle_med = libelle;
            this.contre_indication = contre_indication;
        }
    }
}
