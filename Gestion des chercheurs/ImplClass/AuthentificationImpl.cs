using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_chercheurs.ImplClass
{
    class AuthentificationImpl : MarshalByRefObject, IAuthentification.IAuthentification
    {
        public bool Login(string user, string pass)
        {
            DataBases bd = new DataBases();
            return bd.Login(user,pass);
        }

        public ChefEquipe LoginChef(string user, string pass)
        {
            DataBases bd = new DataBases();
            return bd.LoginChef(user, pass);
        }

        public Chercheur LoginChercheur(string user, string pass)
        {
            DataBases bd = new DataBases();
            return bd.LoginChercheur(user, pass);
        }

        public Directure LoginDirecteur(string user, string pass)
        {
            DataBases bd = new DataBases();
            return bd.LoginDirecture(user, pass);
        }
    }
}
