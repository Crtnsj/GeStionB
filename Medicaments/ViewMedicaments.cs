﻿using GeStionB.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Medicaments
{
    public partial class ViewMedicaments : Form
    {
        private MedicamentsDataAccess dataAccess = new MedicamentsDataAccess();
        string nom_m = "";
        public ViewMedicaments(string nom_m)
        {
            InitializeComponent();
            updateDataGridView();
            this.Activated += ViewPatients_Activated;
            this.nom_m = nom_m;
        }

        private void ViewPatients_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        public void updateDataGridView()
        {
            this.MedicamentGridView.DataSource = null;
            this.MedicamentGridView.DataSource = dataAccess.GetMedicamentListFromDB();
        }
        private void MedicamentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.MedicamentGridView.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string libelle = selectedRow.Cells["Libelle"].Value.ToString();


                MedicamentsDetails patientDetail = new MedicamentsDetails(id, libelle);
                patientDetail.Show();
            }
        }

        private void Button_addMedicament_Click(object sender, EventArgs e)
        {
            AddMedicament addMedicament = new AddMedicament();
            addMedicament.Show();
        }

        private void ViewMedicaments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.nom_m);
            this.Hide();
            accueil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
