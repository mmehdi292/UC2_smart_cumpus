using ClassesModele;
using System;
using System.Collections.Generic;

namespace IUsersInfo
{
    public interface IUsersInfo
    {
         List<Directure> GetDirectures();
        List<ChefEquipe> GetChefs();
        List<Chercheur> GetChercheurs();
        Chercheur GetChercheur(String username);
        bool ModChercheur(Chercheur chercheur);
    }
}
