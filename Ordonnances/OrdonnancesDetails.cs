using GeStionB.Medecin;
using GeStionB.Medicaments;
using GeStionB.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Ordonnances
{
    public partial class OrdonnancesDetails : Form
    {
        int id_o;
        public OrdonnancesDetails(int id_o, string posologie, string date, int duree_traitement, string instruction, string nom_m, string nom_p, string libelle_med)
        {
            InitializeComponent();
            this.id_o = id_o;
            this.boxId.Text = id_o.ToString();
            this.boxPosologie.Text = posologie;
            this.boxDate.Text = date;
            this.boxDuree.Text = duree_traitement.ToString();
            this.boxInstructions.Text = instruction;
            this.boxMedecin.Text = nom_m;
            FillComboBoxMedicaments(libelle_med);
            FillComboBoxPatients(nom_p);
            
        }

        public void FillComboBoxMedicaments(string libelle_med)
        {
            MedicamentsDataAccess dataAccessMedicament = new MedicamentsDataAccess();
            dataAccessMedicament.FillComboBox(comboMedicament);

            this.comboMedicament.Text = libelle_med;
        }
        public void FillComboBoxPatients(string nom_p)
        {
            PatientDataAccess dataAccessPatient = new PatientDataAccess();
            dataAccessPatient.FillComboBox(comboPatient);
            this.comboPatient.Text = nom_p;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePDF_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {

                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    PdfCreator pdfCreator = new PdfCreator();
                    pdfCreator.CreatePDF(selectedFolder, this.boxId.Text, this.boxMedecin.Text, this.boxDate.Text, this.comboPatient.Text, this.comboMedicament.Text, this.boxPosologie.Text, this.boxDuree.Text, this.boxInstructions.Text);
                }
            }
        }

        private void btn_suppOrdonnance_Click(object sender, EventArgs e)
        {
            OrdonnancesDataAccess dataAccess = new OrdonnancesDataAccess();
            dataAccess.RemoveOrdonnance(id_o);
        }
    }
}
