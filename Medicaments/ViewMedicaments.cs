using GeStionB.Patients;
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
        public ViewMedicaments()
        {
            InitializeComponent();
            updateDataGridView();
        }
        public void updateDataGridView()
        {
            this.MedicamentGridView.DataSource = null;
            this.MedicamentGridView.DataSource = dataAccess.GetMedicamentListFromDB();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_addMedicament_Click(object sender, EventArgs e)
        {
           AddMedicament addMedicament = new AddMedicament();
            addMedicament.Show();
        }
    }
}
