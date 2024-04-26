using MySqlConnector;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Antecedent
{
    internal class AntecedentDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        //remplit la combox box passee en parametre
        public void FillComboBox(ComboBox comboBox)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //connexion à la base
                conn.Open();
                //preparation de la requete
                string query = "SELECT libelle_a FROM antecedent;";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {   
                    //remplissage de la comboBox avec les donnees recuperee en base
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
                //fermeture de la connexion
                conn.Close();
            }


        }
        public void CreateAntecedent(string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO antecedent (id_a, libelle_a) VALUES (NULL, @libelle_a); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_a", libelle);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public DataTable GetAntecedentListFromDB(int id_p)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM antecedent WHERE id_a IN (SELECT id_a FROM a_eu WHERE id_p = @id_patient);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_patient", id_p);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                conn.Close();
            }

            return dataTable;
        }
        //methode pour l'attribution des antecedents,
        //@param id_p, id du patient
        //@param libelle, libelle de l'antecedent
        public void AttributeAntecedent(int id_p, string libelle_a)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try {
                    //debut de la connexion
                    conn.Open();
                    // preparation de la requete
                    string query = "INSERT INTO a_eu (id_a, id_p) VALUES ((SELECT id_a FROM antecedent " +
                        "WHERE antecedent.libelle_a = @libelle_a), @id_p)";
                    //definition des parametres necessaire et execution de la requete
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_p", id_p);
                        command.Parameters.AddWithValue("@libelle_a", libelle_a);
                        command.ExecuteNonQuery();
                    }
                }
                //gestion des exeptions
                catch (Exception e){
                    //message pour l'utilisateur annoncant qu'une erreur s'est produite
                    MessageBox.Show("Une erreur s'est produite");
                    //affichage de l'erreur en console
                    Console.WriteLine(e.Message);
                }
                finally {
                    //fin de la connexion
                    conn.Close(); 
                }
                
            }
        }

    }
}
