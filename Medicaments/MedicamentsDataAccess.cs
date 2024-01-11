using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Medicaments
{
    internal class MedicamentsDataAccess
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable GetMedicamentListFromDB()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_med As ID, libelle_med As Libelle , contre_indication As 'Contre indication' FROM medicament;";
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
        public void CreateMedicament(string libelle, string CI )
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medicament (id_med, libelle_med, contre_indication) VALUES (NULL, @libelle_med, @CI); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_med", libelle);
                    command.Parameters.AddWithValue("@CI", CI);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void UpdateMedicamentInfo(int id, string libelle, string CI)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medicament SET libelle_med = @libelle , contre_indication = @CI WHERE medicament.id_med = @id; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", libelle);
                    command.Parameters.AddWithValue("@CI", CI);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}

