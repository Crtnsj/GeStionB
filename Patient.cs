using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB
{
    internal class Patient
    {
        private int _id { get; }
        private String _nom { get; set; }
        private String _prenom { get; set; }
        private String _sexe { get; set; }

        public Patient(int id, string nom, string prenom, string sexe)
        {
            this._id = id;
            this._nom = nom;
            this._prenom = prenom;
            this._sexe = sexe;
        }
    }
}
