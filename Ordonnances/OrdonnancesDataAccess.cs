using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Ordonnances
{
    internal class OrdonnancesDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        public DataTable GetOrdonnancesListFromDB ()
        {
            DataTable dataTable = new DataTable ();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ordonnance.id_o AS ID, ordonnance.posologie AS Posologie, ordonnance.date AS \"Date de création\", ordonnance.duree_traitement AS \"Durée du traitement (jours)\", ordonnance.instruction_specifique AS \"Instructions\", (SELECT medecin.nom_m FROM medecin WHERE medecin.id_m = ordonnance.id_m) AS Medecin, (SELECT patient.nom_p FROM patient WHERE patient.id_p = ordonnance.id_p) AS Patient, (SELECT medicament.libelle_med FROM medicament WHERE medicament.id_med = ordonnance.id_med) AS \"Medicament Prescrit\" FROM ordonnance WHERE ordonnance.id_o = 4";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                conn.Close();
            }
            return dataTable ;
        }
    }
}
