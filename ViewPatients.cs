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

namespace GeStionB
{
    public partial class ViewPatients : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        public ViewPatients()
        {
            InitializeComponent();
            updateDataGridView();
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void updateDataGridView()
        {
            this.PatientGridView.DataSource = null;
            this.PatientGridView.DataSource = dataAccess.GetPatientListFromDB();
        }

        private void Utilisateurs_Load(object sender, EventArgs e)
        {

        }
    }
}
