using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesModele
{
    public class Notification
    {
        public Notification(int id, string username, bool vue, int id_prod)
        {
            this.id = id;
            this.username = username;
            this.vue = vue;
            this.id_prod = id_prod;
        }

        public int id { set; get; }
        public string username { set; get; }
        public Boolean vue { set; get; }
        public int id_prod { set; get; }

    }
}
