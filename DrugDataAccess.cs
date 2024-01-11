using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GeStionB
{
    internal class DrugDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Drug> drugs = new List<Drug>();


        public void addDrug(Drug drug)
        {
            this.drugs.Add(drug);
        }
        public List<Drug> getDrugList() { return this.drugs; }

        public List<Drug> getDrugListFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_med, contre_indication FROM medicament";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        this.drugs.Clear();
                        while (reader.Read())
                        {
                            this.drugs.Add(new Drug(reader["libelle_med"].ToString(), reader["contre_indication"].ToString()));
                        };
                        
                    }

                }
                conn.Close();

            }
            return this.drugs;
        }

        public int addDrugToDB(Drug drug)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medicament (libelle_med, contre_indication) VALUES (@libelle_med, @contre_indication)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@libelle_med", drug.libelle_med);
                    command.Parameters.AddWithValue("@contre_indication", drug.contre_indication);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;

                }
            }


        }
    }
}
