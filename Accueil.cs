﻿using GeStionB.Medicaments;
using GeStionB.Ordonnances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB
{
    public partial class Accueil : Form
    {
        string nom_m = "";
        public Accueil(string nom_m)
        {
            InitializeComponent();
            this.nom_m = nom_m;
        }



        private void gererLesPatiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPatients viewPatients = new ViewPatients(this.nom_m);
            this.Hide();
            viewPatients.Show();
        }

        private void gererLesMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMedicaments viewMedicaments = new ViewMedicaments(this.nom_m);
            this.Hide();
            viewMedicaments.Show();
        }

        private void gererLesOrdonnacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrdonnances viewOrdonnances = new ViewOrdonnances(nom_m);
            this.Hide();
            viewOrdonnances.Show();
        }


        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
