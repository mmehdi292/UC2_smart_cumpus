using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class Livre : Production 
    {
        public Livre(int id, string nom, DateTime ajoutDate, string desc, string motcle, string username, int pages, byte[] pdf, int version, string langue)
            : base(id, nom, ajoutDate, desc, motcle, username)
        {
            this.pages = pages;
            this.pdf = pdf;
            this.version = version;
            this.langue = langue;
        }

        public int pages { set; get; }
        public byte[] pdf { set; get; }

        public int version { set; get; }
        public string langue { set; get; }
    }
}
