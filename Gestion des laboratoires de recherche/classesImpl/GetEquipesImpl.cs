using ClassesModele;
using Gestion_des_chercheurs.BDclasses;

using System;
using System.Collections.Generic;


namespace Gestion_des_laboratoires_de_recherche.classesImpl
{
    public class GetEquipesImpl : MarshalByRefObject, IGetEquipes.IGetEquipes
    {
        public List<Equipe> GetEquipes()
        {
            DataBases bd = new DataBases();
            return bd.GetEquipesImp();
        }
    }
}
