using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassesModele;

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
            database = "labobd";
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
        public bool AjouterLabo(Laboratoire labo) {

            string query = "INSERT INTO laboratoire values(\"" + labo.acronyme + "\",\"" + labo.nom + "\"," + labo.anneeCreation + ",\"" + labo.usernameDirecteur + "\");";


            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try {
                    if (cmd.ExecuteNonQuery() == 1)
                        return true;
                } catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                this.CloseConnection();
            }
            return false;

        }
        public bool AjouterEquipe(Equipe eq)
        {

            string query = "INSERT INTO equipe(nom, username, acronyme) values(\"" + eq.nom + "\",\"" + eq.chefUser + "\",\"" + eq.lab.acronyme + "\");";


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
        public List<Laboratoire> GetLaboratoires() {
            List<Laboratoire> laboratoires = new List<Laboratoire>();
            string query = "SELECT * FROM laboratoire;";
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
                            string acronyme = reader.GetString(0);
                            string nom = reader.GetString(1);
                            int annee = reader.GetInt32(2);
                            string userDirecteur = reader.GetString(3);

                            Laboratoire laboratoire = new Laboratoire(acronyme,nom,annee,userDirecteur);
                            laboratoires.Add(laboratoire);
                        }
                    }

                }
                this.CloseConnection();
            }
            return laboratoires;
        }
        public bool DeleteLabo(String acronyme) {
            string query = "DELETE FROM laboratoire WHERE acronyme= \""+acronyme+"\";";
            string query1 = "DELETE FROM equipe WHERE acronyme= \"" + acronyme + "\";";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query1;
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = query;
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
        public bool EditLabo(Laboratoire labo)
        {
            string query = "UPDATE laboratoire SET nom = '"+labo.nom+"', anneeAgrement ='"+labo.anneeCreation+"', username = '"+labo.usernameDirecteur+"' WHERE acronyme= '"+labo.acronyme+"';";
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
        public List<Laboratoire> SearchLabo(string search) {
            List<Laboratoire> laboratoires = new List<Laboratoire>();
            string query = "SELECT * FROM laboratoire WHERE acronyme LIKE '%"+ search + "%' OR nom LIKE '%"+ search + "%' OR anneeAgrement LIKE '%"+ search + "%' OR username LIKE '%"+ search + "%';";
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
                            string acronyme = reader.GetString(0);
                            string nom = reader.GetString(1);
                            int annee = reader.GetInt32(2);
                            string userDirecteur = reader.GetString(3);

                            Laboratoire laboratoire = new Laboratoire(acronyme, nom, annee, userDirecteur);
                            laboratoires.Add(laboratoire);
                        }
                    }

                }
                this.CloseConnection();
            }
            return laboratoires;

        }
        public List<Equipe> GetEquipes() {
            List<Equipe> equipes = new List<Equipe>();
            string query = "SELECT * FROM equipe;";
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
                            string user = reader.GetString(2);
                            string acro = reader.GetString(3);

                            Equipe equipe = new Equipe(id, nom, user, new Laboratoire(acro,"",0,""));
                            equipes.Add(equipe);
                        }
                    }

                }
                this.CloseConnection();
            }
            return equipes;
        }
        public bool DeleteEquipe(int id)
        {
            string query = "DELETE FROM equipe WHERE id_equipe = '" + id + "';";
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
        public bool EditEquipe(Equipe eq)
        {
            string query = "UPDATE equipe SET nom = '" + eq.nom + "', username = '" + eq.chefUser + "', acronyme = '" + eq.lab.acronyme + "' WHERE id_equipe = " + eq.id + ";";
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
        public List<Equipe> SearchEquipe(string search)
        {
            List<Equipe> equipes = new List<Equipe>();
            string query = "SELECT * FROM equipe WHERE id_equipe LIKE '%" + search + "%' OR nom LIKE '%" + search + "%' OR username LIKE '%" + search + "%' OR acronyme LIKE '%" + search + "%';";
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
                            string acro = reader.GetString(3);

                            Equipe equipe = new Equipe(id, nom, username, new Laboratoire(acro,"",0,""));
                            equipes.Add(equipe);
                        }
                    }

                }
                this.CloseConnection();
            }
            return equipes;

        }
        public List<Equipe> GetEquipesImp()
        {
            List<Equipe> equipes = new List<Equipe>();
            string query = "SELECT * FROM equipe;";
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
                            string user = reader.GetString(2);
                            string acro = reader.GetString(3);

                            Equipe equipe = new Equipe(id, nom, user, new Laboratoire(acro,"",0,""));
                            equipes.Add(equipe);
                        }
                    }

                }
                this.CloseConnection();
            }
            return equipes;
        }

    }
}
