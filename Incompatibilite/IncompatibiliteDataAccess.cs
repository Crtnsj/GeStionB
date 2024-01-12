using MySqlConnector;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Incompatibilite
{
    internal class IncompatibiliteDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void CreateIncompatibilite(string id_a, int id_med, string id_al, string libelle_med)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO incompatible (id, id_a, id_med, id_al, id_med_Medicament) VALUES (NULL, (SELECT id_a FROM antecedent WHERE antecedent.libelle_a = @libelle_a), @id_med,(SELECT id_al FROM allergie WHERE allergie.libelle_al = @libelle_al),(SELECT id_med FROM medicament WHERE medicament.libelle_med = @libelle_med));";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_a", id_a);
                    command.Parameters.AddWithValue("@id_med", id_med);
                    command.Parameters.AddWithValue("@libelle_al", id_al);
                    command.Parameters.AddWithValue("@libelle_med", libelle_med);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        public void FillDefaultValueComboxBoxMedicaments(int id_med)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT libelle_med FROM medicament WHERE medicament.id_med = (SELECT id_med_Medicament FROM incompatible WHERE incompatible.id_med = @id_med); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", id_med);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
