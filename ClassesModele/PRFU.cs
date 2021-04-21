using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesModele
{
    [Serializable]
    public class PRFU : Projet
    {
        public PRFU(int id, string nom, string user,Boolean verifeirCondition)
            :base(id,nom,user)
        {
            this.VerifeirCondition = verifeirCondition;
        }

        public Boolean VerifeirCondition { set;  get; }


    }
}
