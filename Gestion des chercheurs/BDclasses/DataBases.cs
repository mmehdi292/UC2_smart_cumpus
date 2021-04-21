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
            database = "chercheurbd";
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
        public bool Login(string user, string pass)
        {
            string query;
            if (user.Contains('@'))
                 query = "SELECT * FROM administrateur WHERE email = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            else
                 query = "SELECT * FROM administrateur WHERE username = \""+user+"\" and password = md5(\""+pass+"\"); ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        this.CloseConnection();
                        return true;

                    }
                    else {
                        this.CloseConnection();
                        return false;
                    }
                }    
                this.CloseConnection();
            }
            return false;

        }
        public List<Directure> GetDirectures()
        {
            List<Directure> directures = new List<Directure>();
            string query = "SELECT * FROM directure;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            Directure directure = new Directure(nom,prenom,date_niass,lieu_naiss,adress,username,password,email,sexe,interet,domaine);
                            directures.Add(directure);
                            Debug.WriteLine(directure.username);
                        }
                    }
                    
                }
                this.CloseConnection();
            }
            return directures;

        }
        public List<ChefEquipe> GetChefs()
        {
            List<ChefEquipe> chefEquipes = new List<ChefEquipe>();
            string query = "SELECT * FROM chef_equipe;";
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
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            ChefEquipe chefEquipe = new ChefEquipe(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                            chefEquipes.Add(chefEquipe);
                            Debug.WriteLine(chefEquipe.username);
                        }
                    }

                }
                this.CloseConnection();
            }
            return chefEquipes;

        }
        public List<Chercheur> GetChercheurs()
        {
            List<Chercheur> chercheurs = new List<Chercheur>();
            string query = "SELECT * FROM chercheur;";
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
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            Chercheur chercheur = new Chercheur(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                            chercheurs.Add(chercheur);
                        }
                    }

                }
                this.CloseConnection();
            }
            return chercheurs;

        }
        public bool AddChercheur(Chercheur chercheur) {

            string query = "INSERT INTO chercheur (nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine) VALUES(@nom, @prenom, @date_niass, @lieu_naiss, @adress, @username, MD5(@password), @email, @sexe, @interet, @domaine);";
            if (this.OpenConnection() == true)
            {
                //MySqlCommand cmd = connection.CreateCommand();
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", chercheur.nom);
                    cmd.Parameters.AddWithValue("@prenom", chercheur.prenom);
                    cmd.Parameters.AddWithValue("@date_niass", chercheur.date_nais);
                    cmd.Parameters.AddWithValue("@lieu_naiss", chercheur.lieu_nais);
                    cmd.Parameters.AddWithValue("@adress", chercheur.adresse);
                    cmd.Parameters.AddWithValue("@username", chercheur.username);
                    cmd.Parameters.AddWithValue("@password", chercheur.password);
                    cmd.Parameters.AddWithValue("@email", chercheur.email);
                    cmd.Parameters.AddWithValue("@sexe", chercheur.sexe);
                    cmd.Parameters.AddWithValue("@interet", chercheur.interet[0]);
                    cmd.Parameters.AddWithValue("@domaine", chercheur.domaine);
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
        public bool AddDirecteur(Chercheur chercheur)
        {

            string query = "INSERT INTO directure (nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine) VALUES(@nom, @prenom, @date_niass, @lieu_naiss, @adress, @username, MD5(@password), @email, @sexe, @interet, @domaine);";
            if (this.OpenConnection() == true)
            {
                //MySqlCommand cmd = connection.CreateCommand();
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", chercheur.nom);
                    cmd.Parameters.AddWithValue("@prenom", chercheur.prenom);
                    cmd.Parameters.AddWithValue("@date_niass", chercheur.date_nais);
                    cmd.Parameters.AddWithValue("@lieu_naiss", chercheur.lieu_nais);
                    cmd.Parameters.AddWithValue("@adress", chercheur.adresse);
                    cmd.Parameters.AddWithValue("@username", chercheur.username);
                    cmd.Parameters.AddWithValue("@password", chercheur.password);
                    cmd.Parameters.AddWithValue("@email", chercheur.email);
                    cmd.Parameters.AddWithValue("@sexe", chercheur.sexe);
                    cmd.Parameters.AddWithValue("@interet", chercheur.interet[0]);
                    cmd.Parameters.AddWithValue("@domaine", chercheur.domaine);
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
        public bool AddChef(Chercheur chercheur)
        {

            string query = "INSERT INTO chef_equipe (nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine) VALUES(@nom, @prenom, @date_niass, @lieu_naiss, @adress, @username, MD5(@password), @email, @sexe, @interet, @domaine);";
            if (this.OpenConnection() == true)
            {
                //MySqlCommand cmd = connection.CreateCommand();
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", chercheur.nom);
                    cmd.Parameters.AddWithValue("@prenom", chercheur.prenom);
                    cmd.Parameters.AddWithValue("@date_niass", chercheur.date_nais);
                    cmd.Parameters.AddWithValue("@lieu_naiss", chercheur.lieu_nais);
                    cmd.Parameters.AddWithValue("@adress", chercheur.adresse);
                    cmd.Parameters.AddWithValue("@username", chercheur.username);
                    cmd.Parameters.AddWithValue("@password", chercheur.password);
                    cmd.Parameters.AddWithValue("@email", chercheur.email);
                    cmd.Parameters.AddWithValue("@sexe", chercheur.sexe);
                    cmd.Parameters.AddWithValue("@interet", chercheur.interet[0]);
                    cmd.Parameters.AddWithValue("@domaine", chercheur.domaine);
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
        public bool DeleteCher(String username)
        {
            Debug.WriteLine(username);
            string query = "DELETE FROM chercheur WHERE username = '" + username + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        this.CloseConnection();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }
        public bool DeleteDirecture(String username)
        {
            string query = "DELETE FROM directure WHERE username = '" + username + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        this.CloseConnection();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }
        public bool DeleteChef(String username)
        {
            string query = "DELETE FROM chef_equipe WHERE username = \"" + username + "\";";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1) { 
                    this.CloseConnection();
                    return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }

        public Chercheur GetChercheur(string user)
        {
            
            string query = "SELECT * FROM chercheur WHERE username = '"+user+"';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            Chercheur chercheur = new Chercheur(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                            return chercheur;

                    }
                    

                }
                this.CloseConnection();

            }
            return null ;

        }
        public Chercheur GetChef(string user)
        {

            string query = "SELECT * FROM chef_equipe WHERE username = '" + user + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string nom = reader.GetString(0);
                        string prenom = reader.GetString(1);
                        DateTime date_niass = reader.GetDateTime(2);
                        string lieu_naiss = reader.GetString(3);
                        string adress = reader.GetString(4);
                        string username = reader.GetString(5);
                        string password = reader.GetString(6);
                        string email = reader.GetString(7);
                        string sexe = reader.GetString(8);
                        string interetString = reader.GetString(9);
                        string[] interet = interetString.Split(',');
                        string domaine = reader.GetString(10);
                        Chercheur chercheur = new Chercheur(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                        return chercheur;

                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public Chercheur GetDirectuer(string user)
        {

            string query = "SELECT * FROM directure WHERE username = '" + user + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string nom = reader.GetString(0);
                        string prenom = reader.GetString(1);
                        DateTime date_niass = reader.GetDateTime(2);
                        string lieu_naiss = reader.GetString(3);
                        string adress = reader.GetString(4);
                        string username = reader.GetString(5);
                        string password = reader.GetString(6);
                        string email = reader.GetString(7);
                        string sexe = reader.GetString(8);
                        string interetString = reader.GetString(9);
                        string[] interet = interetString.Split(',');
                        string domaine = reader.GetString(10);
                        Chercheur chercheur = new Chercheur(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                        return chercheur;

                    }


                }
                this.CloseConnection();

            }
            return null;

        }
        public List<Directure> SearchDirectures(string word)
        {
            List<Directure> directures = new List<Directure>();
            string query = "SELECT * FROM directure WHERE nom like '%" + word + "%' or prenom like '%" + word + "%' or lieu_naiss like '%" + word + "%' or adress like '%" + word + "%'or username like '%" + word + "%' or email like '%" + word + "%' or sexe like '%" + word + "%' or interet like '%" + word + "%' or domaine like '%" + word + "%';";
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
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            Directure directure = new Directure(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                            directures.Add(directure);
                            Debug.WriteLine(directure.username);
                        }
                    }

                }
                this.CloseConnection();
            }
            return directures;

        }
        public List<ChefEquipe> SearchChefs(string word)
        {
            List<ChefEquipe> chefEquipes = new List<ChefEquipe>();
            string query = "SELECT * FROM chef_equipe WHERE nom like '%" + word + "%' or prenom like '%" + word + "%' or lieu_naiss like '%" + word + "%' or adress like '%" + word + "%'or username like '%" + word + "%' or email like '%" + word + "%' or sexe like '%" + word + "%' or interet like '%" + word + "%' or domaine like '%" + word + "%';";
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
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            ChefEquipe chefEquipe = new ChefEquipe(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                            chefEquipes.Add(chefEquipe);
                            Debug.WriteLine(chefEquipe.username);
                        }
                    }

                }
                this.CloseConnection();
            }
            return chefEquipes;

        }
        public List<Chercheur> SearchChercheurs(string word)
        {
            List<Chercheur> chercheurs = new List<Chercheur>();
            string query = "SELECT * FROM chercheur WHERE nom like '%" + word + "%' or prenom like '%" + word + "%' or lieu_naiss like '%" + word + "%' or adress like '%" + word + "%'or username like '%" + word + "%' or email like '%" + word + "%' or sexe like '%" + word + "%' or interet like '%" + word + "%' or domaine like '%" + word + "%';";
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
                            string nom = reader.GetString(0);
                            string prenom = reader.GetString(1);
                            DateTime date_niass = reader.GetDateTime(2);
                            string lieu_naiss = reader.GetString(3);
                            string adress = reader.GetString(4);
                            string username = reader.GetString(5);
                            string password = reader.GetString(6);
                            string email = reader.GetString(7);
                            string sexe = reader.GetString(8);
                            string interetString = reader.GetString(9);
                            string[] interet = interetString.Split(',');
                            string domaine = reader.GetString(10);
                            Chercheur chercheur = new Chercheur(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                            chercheurs.Add(chercheur);
                        }
                    }

                }
                this.CloseConnection();
            }
            return chercheurs;

        }
        public List<ChercherAffectaion> GetAffectaions()
        {
            List<ChercherAffectaion> chercherAffectaions = new List<ChercherAffectaion>();
            string query = "SELECT * FROM affectationchercheur;";
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
                            string username = reader.GetString(0);
                            int id = reader.GetInt32(1);

                            ChercherAffectaion ch = new ChercherAffectaion(username,id);
                            chercherAffectaions.Add(ch);
                        }
                    }

                }
                this.CloseConnection();
            }
            return chercherAffectaions;

        }
        public bool DeleteAffercation(String username)
        {
            string query = "DELETE FROM affectationchercheur WHERE username = '" + username + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        this.CloseConnection();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }
        public bool AddAffercation(String username,int id)
        {
            string query = "INSERT INTO affectationchercheur VALUES ('" + username + "','"+id+"');";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        this.CloseConnection();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CloseConnection();
            }
            return false;
        }
        public Chercheur LoginChercheur(string user, string pass)
        {
            string query;
            if (user.Contains('@'))
                query = "SELECT * FROM chercheur WHERE email = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            else
                query = "SELECT * FROM chercheur WHERE username = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string nom = reader.GetString(0);
                        string prenom = reader.GetString(1);
                        DateTime date_niass = reader.GetDateTime(2);
                        string lieu_naiss = reader.GetString(3);
                        string adress = reader.GetString(4);
                        string username = reader.GetString(5);
                        string password = reader.GetString(6);
                        string email = reader.GetString(7);
                        string sexe = reader.GetString(8);
                        string interetString = reader.GetString(9);
                        string[] interet = interetString.Split(',');
                        string domaine = reader.GetString(10);
                        Chercheur chercheur = new Chercheur(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);

                        this.CloseConnection();
                        return chercheur;

                    }
                    else
                    {
                        this.CloseConnection();
                        return null;
                    }
                }
                
            }
            return null;
        }
        public ChefEquipe LoginChef(string user, string pass)
        {
            string query;
            if (user.Contains('@'))
                query = "SELECT * FROM chef_equipe WHERE email = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            else
                query = "SELECT * FROM chef_equipe WHERE username = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        reader.Read();
                        string nom = reader.GetString(0);
                        string prenom = reader.GetString(1);
                        DateTime date_niass = reader.GetDateTime(2);
                        string lieu_naiss = reader.GetString(3);
                        string adress = reader.GetString(4);
                        string username = reader.GetString(5);
                        string password = reader.GetString(6);
                        string email = reader.GetString(7);
                        string sexe = reader.GetString(8);
                        string interetString = reader.GetString(9);
                        string[] interet = interetString.Split(',');
                        string domaine = reader.GetString(10);
                        ChefEquipe chefEquipe = new ChefEquipe(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                        this.CloseConnection();
                        return chefEquipe;

                    }
                    else
                    {
                        this.CloseConnection();
                        return null;
                    }
                }

            }
            return null;
        }
        public Directure LoginDirecture(string user, string pass)
        {
            string query;
            if (user.Contains('@'))
                query = "SELECT * FROM directure WHERE email = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            else
                query = "SELECT * FROM directure WHERE username = \"" + user + "\" and password = md5(\"" + pass + "\"); ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string nom = reader.GetString(0);
                        string prenom = reader.GetString(1);
                        DateTime date_niass = reader.GetDateTime(2);
                        string lieu_naiss = reader.GetString(3);
                        string adress = reader.GetString(4);
                        string username = reader.GetString(5);
                        string password = reader.GetString(6);
                        string email = reader.GetString(7);
                        string sexe = reader.GetString(8);
                        string interetString = reader.GetString(9);
                        string[] interet = interetString.Split(',');
                        string domaine = reader.GetString(10);
                        Directure directure = new Directure(nom, prenom, date_niass, lieu_naiss, adress, username, password, email, sexe, interet, domaine);
                        
                        this.CloseConnection();
                        return directure;

                    }
                    else
                    {
                        this.CloseConnection();
                        return null;
                    }
                }

            }
            return null;
        }

    }
}
