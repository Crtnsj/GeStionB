using GeStionB.Medicaments;
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
        public Accueil()
        {
            InitializeComponent();
        }



        private void gererLesPatiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPatients viewPatients = new ViewPatients();
            viewPatients.Show();
        }

        private void gererLesMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMedicaments viewMedicaments = new ViewMedicaments();
            viewMedicaments.Show();
        }

        private void gererLesOrdonnacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrdonnances viewOrdonnances = new ViewOrdonnances();
            viewOrdonnances.Show();
        }
       

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
