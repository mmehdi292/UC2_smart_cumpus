using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class Laboratoire
    {
        public string acronyme { set; get; }
        public string nom { set; get; }
        public int anneeCreation { set; get; }
        public string usernameDirecteur { set; get; }
        public Laboratoire(string acronyme, string nom, int anneeCreation, string usernameDirecteur)
        {
            this.acronyme = acronyme;
            this.nom = nom;
            this.anneeCreation = anneeCreation;
            this.usernameDirecteur = usernameDirecteur;
        }
        public override string ToString()
        {
            return this.nom +" ,"+this.acronyme;
        }

    }
}
