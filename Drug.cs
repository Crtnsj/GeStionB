﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB
{
    internal class Drug
    {
        public string libelle_med { get; set; }
        public string contre_indication { get; set; }

        public Drug(string libelle_med, string contre_indication)
        {
            this.libelle_med = libelle_med;
            this.contre_indication = contre_indication;
        }
    }
}