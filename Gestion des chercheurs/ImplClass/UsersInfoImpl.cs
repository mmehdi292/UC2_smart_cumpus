using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using IUsersInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_chercheurs.ImplClass
{
    public class UsersInfoImpl : MarshalByRefObject, IUsersInfo.IUsersInfo
    {
        public List<Directure> GetDirectures()
        {
            DataBases bd = new DataBases();
            return bd.GetDirectures();
        }
        public List<ChefEquipe> GetChefs()
        {
            DataBases bd = new DataBases();
            return bd.GetChefs();
        }

        public Chercheur GetChercheur(string username)
        {
            DataBases bd = new DataBases();
            return bd.GetChercheur(username);
        }

        public bool ModChercheur(Chercheur chercheur)
        {
            DataBases bd = new DataBases();
            bd.DeleteCher(chercheur.username);
            if (bd.AddChercheur(chercheur))
                return true;
            else
                return false;
        }

        public List<Chercheur> GetChercheurs()
        {
            DataBases bd = new DataBases();
            return bd.GetChercheurs();
            
        }
    }
}
