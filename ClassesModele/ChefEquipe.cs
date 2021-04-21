using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesModele
{
    [Serializable]
    public class ChefEquipe : Chercheur
    {
        public ChefEquipe(string nom, string prenom, DateTime date_nais, string lieu_nais, string adresse, string username, string password, string email, string sexe, string[] interet, string domaine)
        : base(nom, prenom, date_nais, adresse, lieu_nais, adresse, username, password, email, interet, domaine)
        {
           
        }

        public override string ToString()
        {
            return this.nom + " " + this.prenom + " ," + this.username; ;
        }
 
    }
}
