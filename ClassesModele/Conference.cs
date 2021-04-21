using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class Conference : Production
    {
        public Conference(int id, string nom, DateTime ajoutDate, string desc, string motcle, string username, string lieu, int places, string salle, List<byte[]> pdfs, string dure)
            : base(id, nom, ajoutDate, desc, motcle, username)
        {
            this.lieu = lieu;
            this.places = places;
            this.salle = salle;
            this.pdfs = pdfs;
            this.dure = dure;
        }

        public string lieu { set; get; }
        public int places { set; get; }

        public string salle { set; get; }
        public List<byte[]> pdfs { set; get; }
        public string dure { set; get; }
    }
}
