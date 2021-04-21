using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class Production
    {
       

        public Production(int id, string nom, DateTime ajoutDate, string desc, string motcle, string username)
        {
            this.id = id;
            this.nom = nom;
            this.ajoutDate = ajoutDate;
            this.desc = desc;
            this.motcle = motcle;
            this.username = username;
        }

        public int id { set; get; }
        public string nom {set;get;}
        public DateTime ajoutDate { set; get; }
        public string desc { set; get; }
        public string motcle { set; get; }
        public string username { set; get; }

    }
}
