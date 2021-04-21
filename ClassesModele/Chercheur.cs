using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassesModele
{
    [Serializable]
    public class Chercheur
    {
      
            public Chercheur(string nom, string prenom, DateTime date_nais, string lieu_nais, string adresse, string username, string password, string email, string sexe, string[] interet, string domaine)
            {
                this.nom = nom;
                this.prenom = prenom;
                this.date_nais = date_nais;
                this.lieu_nais = lieu_nais;
                this.adresse = adresse;
                this.username = username;
                this.password = password;
                this.email = email;
                this.sexe = sexe;
                this.interet = interet;
                this.domaine = domaine;
            }


            public string nom { set; get; }
            public string prenom { set; get; }
            public DateTime date_nais { set; get; }
            public string lieu_nais { set; get; }
            public string adresse { set; get; }
            public string username { set; get; }
            public string password { set; get; }
            public string email { set; get; }

            public string sexe { set; get; }

            public string[] interet { set; get; }
            public string domaine { set; get; }




        }
    }
