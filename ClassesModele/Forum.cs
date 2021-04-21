using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesModele
{
    public class Forum
    {
        public Forum(int id, string nom, DateTime date, string description, string username)
        {
            this.id = id;
            this.nom = nom;
            this.date = date;
            this.description = description;
            this.username = username;
        }

        public int id { set; get; } 
        public string nom { set; get; }
        public DateTime date { set; get; }
        public string description { set; get; } 
        public string username { set; get; }
    }
}
