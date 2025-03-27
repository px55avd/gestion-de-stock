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
        private string myConnectionString = "datasource=localhost;port=6033;username=root;password=root;database=db_test;";
        private MySqlConnection myConnection;
        private int _line;
        

        
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

        private void getNumberLine()
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

                

                // All succesfully executed, now do something

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

            _line = count;
        }

        /// <summary>
        /// 
        /// </summary>
        public string[] Readrows()
        {
            myConnection = new MySqlConnection(myConnectionString);

            string query = "SELECT * FROM t_utilisateur";

            MySqlCommand commandDatabase = new MySqlCommand(query, myConnection);

            MySqlDataReader reader;

            string[] result = new string[0];

            try
            {

                // Open the database
                myConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                //Table to get names ogf columns
                result = new string[reader.FieldCount];

                // All succesfully executed, now do something
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Do something with every received database ROW
                        string[] row = { reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3) };

                        result = row;
                    }
                }
                else
                {
                    MessageBox.Show("Pas de colonnes 2");
                }

                // Finally close the connection     
                myConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show($"Échec de la connexion 1 : {ex.Message}");
            }

            return result;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public string[,] Getdata()
        {
            getNumberLine();

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

                data = new string[_line, reader.FieldCount];

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
        public void SaveUser(string firstname, string name, string address)
        {
            
            string query = "INSERT INTO t_utilisateur(`id`, `useFirstname`, `useLastname`, `useAddress`) VALUES (NULL, '" + firstname + "', '" + name + "', '" + address + "')";
            // Which could be translated manually to :
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

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
            string query = "DELETE FROM `t_utilisateur` WHERE id = " + id + "";

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
    }
}
