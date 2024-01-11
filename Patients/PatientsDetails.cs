using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeStionB.Patients
{
    public partial class PatientsDetails : Form
    {
        public int Id { get; set; }
        public PatientsDetails(int id, string nom, string prenom, string sex)
        {
            InitializeComponent();
            this.Id = id;
            this.Box_change_nom.Text = nom;
            this.Box_change_prenom.Text = prenom;
            this.combo_change_sexe.Text = sex;
        }

        private void PatientsDatails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void User_change_button_Click(object sender, EventArgs e)
        {
            PatientDataAccess dataAccess = new PatientDataAccess();
            dataAccess.UpdatePatientInfo(Id, this.Box_change_nom.Text, this.Box_change_prenom.Text, this.combo_change_sexe.Text);
            this.Close();  
        }
    }
}
