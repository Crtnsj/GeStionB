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
                string query = "SELECT id_med AS ID, libelle_med AS Libelle, (SELECT libelle_a FROM antecedent WHERE antecedent.id_a = medicament.id_a) AS 'Contre indication' FROM medicament;";
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
                string query = "INSERT INTO medicament (id_med, libelle_med, id_a) VALUES (NULL, @libelle_med, (SELECT id_a FROM antecedent WHERE libelle_a = @CI)); ";
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
                string query = "UPDATE medicament SET libelle_med = @libelle, id_a = (SELECT id_a FROM antecedent WHERE libelle_a = @CI) WHERE id_med = @id;";
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
        public void FillComboBox(ComboBox comboBox)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_med FROM medicament;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            comboBox.Items.Add(value);
                        }
                    }
                }
                conn.Close();
            }


        }
    }
}

