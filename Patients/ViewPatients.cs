using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeStionB.Patients;

namespace GeStionB
{
    public partial class ViewPatients : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        public ViewPatients()
        {
            InitializeComponent();
            updateDataGridView();
            this.Activated += ViewPatients_Activated;
        }

        private void ViewPatients_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }


        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void updateDataGridView()
        {
            this.PatientGridView.DataSource = null;
            this.PatientGridView.DataSource = dataAccess.GetPatientListFromDB();
        }

        private void PatientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.PatientGridView.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string nom = selectedRow.Cells["nom"].Value.ToString();
                string prenom = selectedRow.Cells["prenom"].Value.ToString();
                string sexe = selectedRow.Cells["sexe"].Value.ToString();

                PatientsDetails patientDetail = new PatientsDetails(id, nom, prenom, sexe);
                patientDetail.Show();
            }
        }

        private void Add_patient_button_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
        }
    }
}
