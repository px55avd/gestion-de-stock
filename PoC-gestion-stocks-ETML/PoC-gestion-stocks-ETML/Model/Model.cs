using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoC_gestion_stocks_ETML.Controller;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace PoC_gestion_stocks_ETML.Model
{
    public class Model
    {
        /// <summary>
        /// Contrôleur associé à ce modèle
        /// </summary>
        public Controller.Controller Controller { get; set; }

        // Prepare the connection
        private string myConnectionString = "datasource=localhost;port=6033;username=root;password=root;database=db_gestionStockage;";
        private MySqlConnection myConnection;
        private int _lineUser;
        private int _lineArticle;
        private int _lineCategory;



        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Model()
        {


        }

        /// <summary>
        /// Test de connexion
        /// </summary>
        public void TestConnection()
        {

            myConnection = new MySqlConnection(myConnectionString);

            try
            {
                myConnection.Open();
                MessageBox.Show("Connexion réussie !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Échec de la connexion : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void getNumberLineUser()
        {
            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT COUNT(*) FROM t_utilisateur";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection); ;
            MySqlDataReader reader;

            //Compteur
            int count = 0;

            try
            {
                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 1");
                }

                // Finally close the connection     
                reader.Close();
                myConnection.Close();
                
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion : {ex.Message}");
            }

            _lineUser = count;
        }


        private void getNumberLineArticle()
        {
            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT COUNT(*) FROM t_article";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection); ;
            MySqlDataReader reader;

            //Compteur
            int count = 0;

            try
            {
                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 1");
                }

                // Finally close the connection     
                reader.Close();
                myConnection.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion : {ex.Message}");
            }

            _lineArticle = count;
        }

        private void getNumberLineCategory()
        {
            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT COUNT(*) FROM t_catégorie";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection); ;
            MySqlDataReader reader;

            //Compteur
            int count = 0;

            try
            {
                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 1");
                }

                // Finally close the connection     
                reader.Close();
                myConnection.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion : {ex.Message}");
            }

            _lineCategory = count;
        }


        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public string[,] GetuserData()
        {
            getNumberLineUser();

            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT * FROM t_utilisateur";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection);

            MySqlDataReader reader;

            string[,] data = new string[0,0];

            try
            {
                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                data = new string[_lineUser, reader.FieldCount];

                //Compteur
                int count = 0;

                // All succesfully executed, now do something

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[count, i] = reader.GetValue(i).ToString();
                        }

                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 3");
                }

                // Finally close the connection     
                myConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion 2: {ex.Message}");
            }

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public void SaveNewuser(string firstname, string name, string login, string password, int role)
        {
            
            string query = "INSERT INTO t_utilisateur(`utilisateur_id`, `nom`, `prénom`, `login`, `mot_de_passe`,  `rôle`) VALUES (NULL, '" + firstname + "', '" + name + "', '" + login + "', '" + password + "', '" + role + "')";

            MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstname"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public void updateUser(string id, string firstname, string name, string address)
        {
            
            // Update the properties of the row with good id
            string query = "UPDATE `t_utilisateur` SET `useFirstname`='" + firstname + "',`useLastname`='" + name + "',`useAddress`='" + address + "' WHERE id = " + id + "";

            MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully updated

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUser(string id)
        {
            // Update the properties of the row with good id
            string query = "DELETE FROM `t_utilisateur` WHERE utilisateur_id = " + id + "; OPTIMIZE TABLE t_utilisateur ";


            MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("L'utilisateur a bien été supprimmé");

                // Succesfully updated

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public string[,] GetarticleData()
        {
            getNumberLineArticle();

            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT * FROM t_article";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection);

            MySqlDataReader reader;

            string[,] data = new string[0, 0];

            try
            {
                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                data = new string[_lineArticle, reader.FieldCount];

                //Compteur
                int count = 0;

                // All succesfully executed, now do something

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[count, i] = reader.GetValue(i).ToString();
                        }

                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 3");
                }

                // Finally close the connection     
                myConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion 2: {ex.Message}");
            }

            return data;
        }


        public string[,] GetcategoryData()
        {
            getNumberLineCategory();

            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT * FROM t_catégorie";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection);

            MySqlDataReader reader;

            string[,] data = new string[0, 0];

            try
            {
                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                data = new string[_lineCategory, reader.FieldCount];

                //Compteur
                int count = 0;

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[count, i] = reader.GetValue(i).ToString();
                        }

                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 3");
                }

                // Finally close the connection     
                myConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion 2: {ex.Message}");
            }

            return data;
        }


        public void SaveNewArticle(string name, string description, string quantity, string unitPrice, string categoryID)
        {

            string query = "INSERT INTO t_article(`article_id`, `nom`, `description`, `quantité`, `prix_unitaire`,  `catégorie_id`) VALUES (NULL, '" + name + "', '" + description + "', '" + quantity + "', '" + unitPrice + "', '" + categoryID + "')";

            MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Article succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

    }
}
