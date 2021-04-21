using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class Equipe
    {
        public Equipe(int id, string nom, string chefUser, Laboratoire lab)
        {
            this.id = id;
            this.nom = nom;
            this.chefUser = chefUser;
            this.lab = lab;
        }
        public override string ToString()
        {
            return this.id + " ," + this.nom;
        }

        public int id { set; get; }
        public string nom { set; get; }
        public string chefUser { set; get; }

        public Laboratoire lab { set; get; }

    }
}
