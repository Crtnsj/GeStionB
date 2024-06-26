﻿using MySqlConnector;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Allergies
{
    internal class AllergiesDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void FillComboBox(ComboBox comboBox)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_al FROM allergie;";
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
        public void CreateAllergie(string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO allergie (id_al, libelle_al) VALUES (NULL, @libelle_al); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_al", libelle);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public DataTable GetAllergieListFromDB(int id_p)
        {
            //initialise un nouvel objet de type DataTable
            DataTable dataTable = new DataTable();

            //Creer la connexion à la BDD grace à la chaine de connexion
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //ouvre la connexion
                conn.Open();
                //definit la requete qui sera utilisee
                string query = "SELECT * FROM allergie WHERE id_al IN (SELECT id_al FROM est WHERE id_p = @id_patient);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    //creer un parametre de requete, @id_aptient sera remplace au fonctionnement par l'ID du patient
                    command.Parameters.AddWithValue("@id_patient", id_p);
                    //complete la dataTable avec le resultat de la requete
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                //ferme la connexion
                conn.Close();
            }
            // renvoie la dataTable
            return dataTable;
        }
        //methode pour l'attribution des allergies,
        //@param id_p, id du patient
        //@param libelle, libelle de l'allergie
        public void AttributeAllergie(int id_p, string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {   
                    //debut de la connexion
                    conn.Open();
                    //preparation de la requete
                    string query = "INSERT INTO `est` (`id_al`, `id_p`) VALUES((SELECT id_al FROM allergie " +
                        "WHERE allergie.libelle_al = @libelle_al), @id_p)";
                    //definition des parametres necessaire et execution de la requete
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_p", id_p);
                        command.Parameters.AddWithValue("@libelle_al", libelle);
                        command.ExecuteNonQuery();
                    }
                }
                //gestion des exeptions
                catch (Exception e)
                {
                    //message pour l'utilisateur annoncant qu'une erreur s'est produite
                    MessageBox.Show("Une erreur s'est produite");
                    //affichage de l'erreur en console
                    Console.WriteLine(e.Message);
                }
                finally
                {   
                    //fin de la connexion
                    conn.Close();
                }
               
            }
        }
    }
}
