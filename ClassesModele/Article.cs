using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class Article : Production
    {
        public Article(int id, string nom, DateTime ajoutDate, string desc, string motcle, string username, int pages, byte[] pdf, string langue)
            :base(id,nom,ajoutDate,desc,motcle,username)
        {
            
            this.pages = pages;
            this.pdf = pdf;
            this.langue = langue;
        }

        public int pages { set; get; }
        public byte[] pdf { set; get; }
        public string langue { set; get; }

    }
}
