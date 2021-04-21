using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
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
            database = "productionbd";
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
        public bool addArticle(Article article) {
            string query = "INSERT INTO article (nom, date, description, mot_cle, username, pages,fichier, langue)" +
                " VALUES (@nom, @date, @desc, @motcle, @username, @page,@pdf, @langue);";


            if (this.OpenConnection() == true)
            {


                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", article.nom);
                    cmd.Parameters.AddWithValue("@date", article.ajoutDate);
                    cmd.Parameters.AddWithValue("@desc", article.desc);
                    cmd.Parameters.AddWithValue("@motcle", article.motcle);
                    cmd.Parameters.AddWithValue("@username", article.username);
                    cmd.Parameters.AddWithValue("@page", article.pages);
                    cmd.Parameters.AddWithValue("@pdf", article.pdf);
                    cmd.Parameters.AddWithValue("@langue", article.langue);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
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
        public bool addLivre(Livre livre)
        {
            string query = "INSERT INTO livre (nom, date, description, mot_cle, username, pages,fichierpdf,version, langue)" +
                " VALUES (@nom, @date, @desc, @motcle, @username, @page,@pdf,@version, @langue);";


            if (this.OpenConnection() == true)
            {


                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", livre.nom);
                    cmd.Parameters.AddWithValue("@date", livre.ajoutDate);
                    cmd.Parameters.AddWithValue("@desc", livre.desc);
                    cmd.Parameters.AddWithValue("@motcle", livre.motcle);
                    cmd.Parameters.AddWithValue("@username", livre.username);
                    cmd.Parameters.AddWithValue("@page", livre.pages);
                    cmd.Parameters.AddWithValue("@pdf", livre.pdf);
                    cmd.Parameters.AddWithValue("@version", livre.version);
                    cmd.Parameters.AddWithValue("@langue", livre.langue);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
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
        public bool addConference(Conference conference)
        {
            string query = "INSERT INTO conference (id_production,nom, date, description, mot_cle, username, lieu, places, salle, dure )" +
                " VALUES (@id,@nom, @date, @desc, @motcle, @username, @lieu,@places, @salle,@dure);";


            if (this.OpenConnection() == true)
            {


                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    Random rnd = new Random();
                    int id = rnd.Next(1, 10000); ;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nom", conference.nom);
                    cmd.Parameters.AddWithValue("@date", conference.ajoutDate);
                    cmd.Parameters.AddWithValue("@desc", conference.desc);
                    cmd.Parameters.AddWithValue("@motcle", conference.motcle);
                    cmd.Parameters.AddWithValue("@username", conference.username);
                    cmd.Parameters.AddWithValue("@lieu", conference.lieu);
                    cmd.Parameters.AddWithValue("@places", conference.places);
                    cmd.Parameters.AddWithValue("@salle", conference.salle);
                    cmd.Parameters.AddWithValue("@dure", conference.dure);
                    cmd.Prepare();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        int idfile = 1;
                        foreach (byte[] file in conference.pdfs)
                        {
                            string query1 = "INSERT INTO conferencefichiers (id_production, fichier,numfichier)" + " VALUES (@id, @file,@num);";
                            var cmd1 = new MySqlCommand(query, connection);
                            cmd1.CommandText = query1;
                            cmd1.Parameters.AddWithValue("@id", id);
                            cmd1.Parameters.AddWithValue("@file", file);
                            cmd1.Parameters.AddWithValue("@num", idfile);
                            cmd1.Prepare();
                            if (cmd1.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("file " + idfile + " bien ajouter");
                            }
                            else
                            {
                                MessageBox.Show("error dans le ficher" + idfile);
                                return false;
                            }
                            idfile++;
                        }
                        return true;
                    }
                    else {
                        return false;
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
        public Boolean DeleteConference(int id) {

            string query = "DELETE FROM conference WHERE id_production = '" + id + "';";
            string query1 = "DELETE FROM conferencefichiers WHERE id_production = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query1;
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = query;
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
        public List<Conference> getConferences(string user) {
            List<Conference> conferences = new List<Conference>();
            string query = "SELECT * FROM conference WHERE username = '"+user+"';";
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
                            //id_production, nom, date, description, mot_cle, username, lieu, places, salle, dure
                            int id_production = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            string mot_cle = reader.GetString(4);
                            string username = reader.GetString(5);
                            string lieu = reader.GetString(6);
                            int places = reader.GetInt32(7);
                            string salle = reader.GetString(8);
                            string dure = reader.GetString(9);
                            Conference chefEquipe = new Conference(id_production,nom,date,description,mot_cle,username,lieu,places,salle,null,dure);
                            conferences.Add(chefEquipe);
                        }
                    }

                }
                this.CloseConnection();
            }
            return conferences;
        }
        public List<Stream> getPdfs(int id)
        {
            List<Stream> pdfs = new List<Stream>();
            string query = "SELECT * FROM conferencefichiers WHERE id_production = '" + id + "';";
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
                            int id_production = reader.GetInt32(0);
                            Stream pdf = reader.GetStream(1);
                            
                            pdfs.Add(pdf);
                        }
                    }

                }
                this.CloseConnection();
            }
            return pdfs;
        }
        public Conference getConference(int id)
        {
            Conference conference = null;
            string query = "SELECT * FROM conference WHERE id_production = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string nom = reader.GetString(1);
                        DateTime date = reader.GetDateTime(2);
                        string description = reader.GetString(3);
                        string mot_cle = reader.GetString(4);
                        string username = reader.GetString(5);
                        string lieu = reader.GetString(6);
                        int places = reader.GetInt32(7);
                        string salle = reader.GetString(8);
                        string dure = reader.GetString(9);
                        conference = new Conference(id, nom, date, description, mot_cle, username, lieu, places, salle, null, dure);

                    }

                }
                this.CloseConnection();
            }
            return conference;
        }
        public Boolean ModConfernce(Conference c) {

            string query = "UPDATE conference SET nom = @nom, description=@description, mot_cle=@mot_cle," +
                " lieu=@lieu, places=@places, salle=@salle, dure=@dure WHERE id_production = @id_production;";
            if (this.OpenConnection() == true)
            {
                //MySqlCommand cmd = connection.CreateCommand();
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", c.nom);
                    cmd.Parameters.AddWithValue("@description", c.desc);
                    cmd.Parameters.AddWithValue("@mot_cle", c.motcle);
                    cmd.Parameters.AddWithValue("@lieu", c.lieu);
                    cmd.Parameters.AddWithValue("@places", c.places);
                    cmd.Parameters.AddWithValue("@salle", c.salle);
                    cmd.Parameters.AddWithValue("@dure", c.dure);
                    cmd.Parameters.AddWithValue("@id_production", c.id);
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
        public Boolean ModLivre(Livre c)
        {

            string query = "UPDATE livre SET nom = @nom, description=@description, mot_cle=@mot_cle," +
                " fichierpdf=@fichierpdf, pages=@pages, version=@version, langue=@langue WHERE id_production = @id_production;";
            if (this.OpenConnection() == true)
            {
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", c.nom);
                    cmd.Parameters.AddWithValue("@description", c.desc);
                    cmd.Parameters.AddWithValue("@mot_cle", c.motcle);
                    cmd.Parameters.AddWithValue("@fichierpdf", c.pdf);
                    cmd.Parameters.AddWithValue("@pages", c.pages);
                    cmd.Parameters.AddWithValue("@version", c.version);
                    cmd.Parameters.AddWithValue("@langue", c.langue);
                    cmd.Parameters.AddWithValue("@id_production", c.id);
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
        public Boolean ModArticle(Article c)
        {
            //id_production, nom, , description, mot_cle, , pages, fichier, langue

            string query = "UPDATE article SET nom = @nom, description=@description, mot_cle=@mot_cle," +
                "pages=@pages, langue=@langue WHERE id_production = @id_production;";
            if (this.OpenConnection() == true)
            {
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", c.nom);
                    cmd.Parameters.AddWithValue("@description", c.desc);
                    cmd.Parameters.AddWithValue("@mot_cle", c.motcle);
                    cmd.Parameters.AddWithValue("@pages", c.pages);
                    cmd.Parameters.AddWithValue("@langue", c.langue);
                    cmd.Parameters.AddWithValue("@id_production", c.id);
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
        public List<Article> getArticles(string user)
        {
            List<Article> articles = new List<Article>();
            string query = "SELECT * FROM article WHERE username = '" + user + "';";
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
                            //id_production, nom, date, description, mot_cle, username, pages, fichier, langue
                            int id_production = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            string mot_cle = reader.GetString(4);
                            string username = reader.GetString(5);
                            int pages = reader.GetInt32(6);
                            //byte[] fichier = reader.GetStream(7);
                            string langaue = reader.GetString(8);
                            Article article = new Article(id_production, nom, date, description, mot_cle, username, pages, null, langaue);
                            articles.Add(article);
                        }
                    }

                }
                this.CloseConnection();
            }
            return articles;
        }
        public Article getArticle(int id)
        {
            Article article = null;
            string query = "SELECT * FROM article WHERE id_production = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                            //id_production, nom, date, description, mot_cle, username, pages, fichier, langue
                            int id_production = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            string mot_cle = reader.GetString(4);
                            string username = reader.GetString(5);
                            int pages = reader.GetInt32(6);
                            //byte[] fichier = reader.GetStream(7);
                            string langaue = reader.GetString(8);
                            article = new Article(id_production, nom, date, description, mot_cle, username, pages, null, langaue);
                            
                    }

                }
                this.CloseConnection();
            }
            return article;
        }
        public Boolean DeleteArtical(int id)
        {

            string query = "DELETE FROM article WHERE id_production = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                
                try
                {
                    
                    cmd.CommandText = query;
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
        public List<Livre> getLivres(string user)
        {
            List<Livre> livres = new List<Livre>();
            string query = "SELECT * FROM livre WHERE username = '" + user + "';";
            if (this.OpenConnection() == true)
            {
                //id_production, nom, date, description, mot_cle, username, fichierpdf, pages, version, langue
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id_production = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            string mot_cle = reader.GetString(4);
                            string username = reader.GetString(5);
                            int pages = reader.GetInt32(7);
                            int vesrion = reader.GetInt32(8);
                            //byte[] fichier = reader.GetStream(6);
                            string langaue = reader.GetString(9);
                            Livre article = new Livre(id_production, nom, date, description, mot_cle, username,pages,null,vesrion,langaue);
                            livres.Add(article);
                        }
                    }

                }
                this.CloseConnection();
            }
            return livres;
        }
        public Livre getLivre(int id)
        {
            Livre livre = null;
            string query = "SELECT * FROM livre WHERE id_production = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id_production = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        DateTime date = reader.GetDateTime(2);
                        string description = reader.GetString(3);
                        string mot_cle = reader.GetString(4);
                        string username = reader.GetString(5);
                        int pages = reader.GetInt32(7);
                        int vesrion = reader.GetInt32(8);
                        //byte[] fichier = reader.GetStream(6);
                        string langaue = reader.GetString(9);
                        livre = new Livre(id_production, nom, date, description, mot_cle, username, pages, null, vesrion, langaue);

                    }

                }
                this.CloseConnection();
            }
            return livre;
        }
        public Boolean DeleteLivre(int id)
        {

            string query = "DELETE FROM livre WHERE id_production = '" + id + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();

                try
                {

                    cmd.CommandText = query;
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
        public bool addForum(Forum f)
        {
            string query = "INSERT INTO form (nom, date, description, username)" +
                " VALUES (@nom, @date, @desc,@username);";


            if (this.OpenConnection() == true)
            {


                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nom", f.nom);
                    cmd.Parameters.AddWithValue("@date", f.date);
                    cmd.Parameters.AddWithValue("@desc", f.description);
                    cmd.Parameters.AddWithValue("@username", f.username);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
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
        public List<Forum> getForums()
        {
            List<Forum> forums = new List<Forum>();
            string query = "SELECT * FROM form;";
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
                            //id_production, nom, date, description, mot_cle, username, lieu, places, salle, dure
                            int id_production = reader.GetInt32(0);
                            string nom = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string description = reader.GetString(4);
                            string username = reader.GetString(6);
                            Forum form = new Forum(id_production, nom, date, description, username);
                            forums.Add(form);
                        }
                    }

                }
                this.CloseConnection();
            }
            return forums;
        }
        public Forum getForum(int id)
        {
            string query = "SELECT * FROM form WHERE id = '"+id+"';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    { 
                        reader.Read();
                       int id_production = reader.GetInt32(0);
                      string nom = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string description = reader.GetString(4);
                            string username = reader.GetString(6);
                        Forum form = new Forum(id_production, nom, date, description, username);
                        this.CloseConnection();
                        return form;
                    }

                }
                this.CloseConnection();
            }
            return null;
        }
        public List<Notification> GetNotifications()
        {
            List<Notification> notifications = new List<Notification>();
            string query = "SELECT * FROM notificationconference;";
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
                            //id_production, nom, date, description, mot_cle, username, lieu, places, salle, dure
                            int id = reader.GetInt32(0);
                            Boolean vue = reader.GetBoolean(1);
                            string username = reader.GetString(2);
                            int id_pro = reader.GetInt32(3);
                            Notification notification = new Notification(id,username, vue,id_pro);
                            notifications.Add(notification);
                        }
                    }

                }
                this.CloseConnection();
            }
            return notifications;
        }

    }
}
