using GeStionB.Allergies;
using GeStionB.Antecedent;
using GeStionB.Incompatibilite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Medicaments
{
    public partial class ManageIncompatiblite : Form
    {
        int Id { get; set; }
       

        public ManageIncompatiblite(int id)
        {
            InitializeComponent();
            this.Id = id;
            this.Activated += ManageMedicament_Activated;
            

        }

        private void ManageMedicament_Activated(object sender, EventArgs e)
        {   
            FillComboBoxAntecedents();
            FillComboBoxAllergies();
            FillComboBoxMedicaments();
        }

        public void FillComboBoxAntecedents()
        {
            AntecedentDataAccess dataAccess = new AntecedentDataAccess();
            dataAccess.FillComboBox(combo_antecedents);
        }
        public void FillComboBoxAllergies()
        {
            AllergiesDataAccess dataAccess = new AllergiesDataAccess();
            dataAccess.FillComboBox(combo_allergie);
        }
        public void FillComboBoxMedicaments()
        {
            MedicamentsDataAccess dataAccess = new MedicamentsDataAccess();
            dataAccess.FillComboBox(combo_Medicaments);
        }

        public void btn_Incompatibilite_valid_Click(object sender, EventArgs e)
        {
            IncompatibiliteDataAccess dataAccess = new IncompatibiliteDataAccess();
            dataAccess.CreateIncompatibilite(this.combo_antecedents.Text,Id,this.combo_allergie.Text, this.combo_Medicaments.Text);
            MessageBox.Show("Modification prise en compte");
        }
    }
}
