using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Medecin

{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Btn_Login_valid_Click(object sender, EventArgs e)
        {
            MedecinDataAccess dataAccess = new MedecinDataAccess();
            string hash = dataAccess.GetHashForAuthentification(this.Box_Login_Username.Text);
            string nom_m = dataAccess.GetNameOfMedecin(this.Box_Login_Username.Text);
            if (hash != null)
            {
                
                Bcrypt bcrypt = new Bcrypt();
                bool result = bcrypt.Descryption(this.Box_Login_Password.Text, hash);
                if (result)
                {
                    Accueil accueil = new Accueil(nom_m);
                    this.Hide();
                    accueil.Show();
                }
                else
                {
                    MessageBox.Show("Mauvais identifiant/mot de passe");
                }
            }
            else
            {
                await Task.Delay(800);
                MessageBox.Show("Mauvais identifiant/mot de passe");
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            AdminValidation adminValidation = new AdminValidation();
            adminValidation.Show();
        }
    }
}