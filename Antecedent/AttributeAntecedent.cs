using GeStionB.Medicaments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Antecedent
{
    public partial class AttributeAntecedent : Form
    {
        AntecedentDataAccess dataAccess = new AntecedentDataAccess();
        int Id_p { get; set; }
        public AttributeAntecedent(int id_p)
        {
            InitializeComponent();
            this.Id_p = id_p;
            //quand le composant est activé execute -> AttributeAntecedent_Activated()
            this.Activated += AttributeAntecedent_Activated;
        }

        private void AttributeAntecedent_Activated(object sender, EventArgs e)
        {   
            //utilise la methode FillComboBox
            FillComboBox();
        }

        public void FillComboBox()
        {   
            //utilise la methode FillComboBox de la classe antecedentDataAccess
            //avec la comboBox ciblee en parametre
            dataAccess.FillComboBox(combo_antecedents);
        }

        //au click du bouton de validation ->
        private void btn_valid_attributAnT_Click(object sender, EventArgs e)
        {
            //nouvel objet de la classe AntecedentsDataAccess
            AntecedentDataAccess dataAccess = new AntecedentDataAccess();
            //utilisation de la methode AttributeAntecedents avec l'id de l'utilisateur et de la comboBox
            dataAccess.AttributeAntecedent(this.Id_p, this.combo_antecedents.Text);
            //fermeture de la fenetre
            this.Close();
        }

        private void Btn_AddAntecedent_Click(object sender, EventArgs e)
        {
            
                AddAntecedent addAntecedent = new AddAntecedent();
                addAntecedent.Show();
            
        }
    }
}
