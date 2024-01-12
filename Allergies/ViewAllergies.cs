using GeStionB.Antecedent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Allergies
{
    public partial class ViewAllergies : Form
    {
        private int Id_p { get; set; }
        public ViewAllergies(int id_p)


        {
            Id_p = id_p;
            InitializeComponent();
            UpdateDataGridView(id_p);
            this.Activated += ViewAllergies_Activated;

        }

        private void ViewAllergies_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView(Id_p);
        }

        private void UpdateDataGridView(int id_p)
        {
            AllergiesDataAccess dataAccess = new AllergiesDataAccess();
            this.Grid_Allergies.DataSource = null;
            this.Grid_Allergies.DataSource = dataAccess.GetAllergieListFromDB(id_p);
        }




        private void btn_AtributeAllergie_Click(object sender, EventArgs e)
        {
            AttributeAllergies attributeAllergies = new AttributeAllergies(Id_p);
            attributeAllergies.Show();
        }

        private void ViewAllergies_Load(object sender, EventArgs e)
        {

        }
    }
}

