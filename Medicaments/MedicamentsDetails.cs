using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeStionB.Antecedent;

namespace GeStionB.Medicaments
{
    public partial class MedicamentsDetails : Form
    {
        private AntecedentDataAccess dataAccessAntecedent = new AntecedentDataAccess();
        private MedicamentsDataAccess dataAccessMedicament = new MedicamentsDataAccess();
        private int Id { get; }

        public MedicamentsDetails(int id, string libelle, string CI)
        {
            InitializeComponent();
            FillComboBox();
            this.Id = id;
            this.Box_change_libelle.Text = libelle;
            this.Combo_change_CI.Text = CI;
            FillComboBox();
            this.Activated += AddMedicament_Activated;
        }

        private void AddMedicament_Activated(object sender, EventArgs e)
        {
            FillComboBox();
        }
    
        private void FillComboBox()
        {
            dataAccessAntecedent.FillComboBox(Combo_change_CI);

        }

        private void btn_MedicamentsDetails_addCI_Click (object sender, EventArgs e)
        {
            AddAntecedent addAntecedent = new AddAntecedent();
            addAntecedent.Show();
        }

        private void btn_MedicamentsDetails_Valid_Click (object sender, EventArgs e)
        {   
            dataAccessMedicament.UpdateMedicamentInfo(Id, this.Box_change_libelle.Text, this.Combo_change_CI.Text);
            this.Close();
        }

    }
    
}
