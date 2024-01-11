using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Patients
{
    internal class Patient
    {
        private int _id { get; }
        private string _nom { get; set; }
        private string _prenom { get; set; }
        private string _sexe { get; set; }

        public Patient(int id, string nom, string prenom, string sexe)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _sexe = sexe;
        }
    }
}
