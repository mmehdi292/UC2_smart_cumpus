using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesModele
{
    [Serializable]
    public class ChercherAffectaion
    {
        public ChercherAffectaion(string username, int id)
        {
            this.username = username;
            this.id = id;
        }

        public string username { set; get; }
        public int id { set; get; }
    }
}
