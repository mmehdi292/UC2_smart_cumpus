using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ClassesModele;
using MySql.Data.MySqlClient;

namespace Gestion_des_chercheurs.BDclasses
{
    class DataBases
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DataBases()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "projetbd";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Projet GetProjet(String username) {
            string query = "SELECT * FROM projet WHERE username = '" + username + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id = reader.GetInt32(0);
                        string nom = reader.GetString(1);;
                        Projet p =  new Projet(id, nom, username);
                        MessageBox.Show(p.id+" - "+p.nom);
                        return p;

                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public PRFU GetPRFU(String username)
        {
            string query = "SELECT * FROM prfu WHERE username = '" + username + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        PRFU projet = new PRFU(id, nom, username,true);
                        return projet;

                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public Projet GetPRFU(int id)
        {
            string query = "SELECT * FROM prfu WHERE id = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        String username = reader.GetString(2);
                        string nom = reader.GetString(1);
                        Projet projet = new Projet(id, nom, username);
                        return projet;

                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public Projet GetProjet(int id)
        {
            string query = "SELECT * FROM projet WHERE id = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        String username = reader.GetString(2);
                        string nom = reader.GetString(1);
                        Projet projet = new Projet(id, nom, username);
                        return projet;

                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public bool AddProjet(Projet projet)
        {

            string query = "INSERT INTO projet (nom,username) VALUES(@nom, @username);";
            if (this.OpenConnection() == true)
            {
                //MySqlCommand cmd = connection.CreateCommand();
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", projet.nom);
                    cmd.Parameters.AddWithValue("@username", projet.username);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {

                }
                this.CloseConnection();

            }
            return false;
        }
        public bool AddPRFU(PRFU projet)
        {

            string query = "INSERT INTO prfu (nom,username,verifeirCondition) VALUES(@nom, @username,@verifeirCondition);";
            if (this.OpenConnection() == true)
            {
                //MySqlCommand cmd = connection.CreateCommand();
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", projet.nom);
                    cmd.Parameters.AddWithValue("@username", projet.username);
                    cmd.Parameters.AddWithValue("@verifeirCondition", projet.VerifeirCondition);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {

                }
                this.CloseConnection();

            }
            return false;
        }
        public List<Projet> GetProjets()
        {
            List<Projet> projets = new List<Projet>();
            string query = "SELECT * FROM projet;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            string username = reader.GetString(2);
                            Projet p = new Projet(id, nom, username);
                            projets.Add(p);

                        }
                        this.CloseConnection();
                        return projets;
                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public List<Projet> GetPRFUs()
        {
            List<Projet> projets = new List<Projet>();
            string query = "SELECT * FROM prfu;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            string username = reader.GetString(2);
                            Projet p = new Projet(id, nom, username);
                            projets.Add(p);

                        }
                        this.CloseConnection();
                        return projets;
                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public bool DeletePRFU(int id)
        {
            string query = "DELETE FROM prfu WHERE id = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                        return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }
        public bool DeleteProjet(int id)
        {
            string query = "DELETE FROM projet WHERE id = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                        return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }

    }
}
