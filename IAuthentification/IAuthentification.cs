using ClassesModele;
using System;

namespace IAuthentification
{
    public interface IAuthentification
    {
        bool Login(string user,string pass);
        Chercheur LoginChercheur(string user, string pass);
        ChefEquipe LoginChef(string user, string pass);
        Directure LoginDirecteur(string user, string pass);


    }
}
