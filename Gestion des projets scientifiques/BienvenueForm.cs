using ClassesModele;
using Gestion_des_laboratoires_de_recherche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques
{
    public partial class BienvenueForm : Form
    {
        public LoginForm lf;
        public static string username;
        public static string type;

        public BienvenueForm(LoginForm lf,string user, string t)
        {
            InitializeComponent();
            this.lf = lf;
            username = user;
            type = t;
            this.addProject1.Hide();
            this.consulterProjects1.Hide();
        }


        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            lf.Show();
        }

        private void ajouterprojet_Click(object sender, EventArgs e)
        {
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            List<Chercheur> chercheurs = usersInfo.GetChercheurs();
            foreach(Chercheur c in chercheurs)
                this.addProject1.chef.Items.Add(c.nom+" "+c.prenom+","+c.username);
            this.addProject1.Show();
            this.consulterProjects1.Hide();
        }

        private void consulterpro_Click(object sender, EventArgs e)
        {
            this.addProject1.Hide();
            this.consulterProjects1.Show();
        }
    }
}
