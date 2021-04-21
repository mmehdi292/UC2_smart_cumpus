using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesModele
{
    [Serializable]
    public class Projet
    {
        public Projet(int id, string nom, string username)
        {
            this.id = id;
            this.nom = nom;
            this.username = username;
        }

        public int id { set; get; }
        public string nom { set;get; }

        public string username { set; get; }

    }
}
