using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GeStionB.Patients
{
    internal class PatientDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable GetPatientListFromDB()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_p As ID, nom_p As nom, prenom_p As prenom, sexe As sexe FROM patient";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                conn.Close();
            }

            return dataTable;
        }
        public void UpdatePatientInfo(int id, string nom, string prenom, string sexe)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE patient SET nom_p = @nom , prenom_p = @prenom, sexe = @sexe WHERE patient.id_p = @id; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                conn.Close() ;
            }
        }
        public void CreatePatient(string nom, string prenom, string sexe) {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO patient (id_p, nom_p, prenom_p, sexe) VALUES (NULL, @nom, @prenom, @sexe); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}

