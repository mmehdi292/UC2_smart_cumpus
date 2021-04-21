using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
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

namespace Gestion_des_projets_scientifiques
{
    public partial class BienvenueFormChefProjet : Form
    {
        public LoginForm lf;
        public static string username;
        public static string type;
        public BienvenueFormChefProjet(LoginForm lf, string user, string t)
        {
            InitializeComponent();
            this.profile1.Hide();
            this.deposerProjet1.Hide();
            this.lf = lf;
            username = user;
            type = t;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            lf.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            Chercheur c = usersInfo.GetChercheur(BienvenueFormChefProjet.username);
            this.profile1.nom.Text = c.nom;
            this.profile1.prenom.Text = c.prenom;
            this.profile1.DataNais.Text = c.date_nais.ToString();
            this.profile1.lieu.Text = c.lieu_nais;
            this.profile1.adresse.Text = c.adresse;
            this.profile1.email.Text = c.email;
            this.profile1.username.Text = c.username;

            if (c.sexe == "Male")
                this.profile1.sexe.SelectedIndex = 0;
            else
                this.profile1.sexe.SelectedIndex = 1;
            this.profile1.domaine.Text = c.domaine;
            this.profile1.interet.Text = c.interet[0];
            this.profile1.type.Text = type;
            this.profile1.Show();
            this.deposerProjet1.Hide();
        }

        private void depprojet_Click(object sender, EventArgs e)
        {
            DataBases bd = new DataBases();
            this.profile1.Hide();
            this.deposerProjet1.TypeProjet.Text = type;
            if (type == "PRFU")
            {
                PRFU prfu = bd.GetPRFU(BienvenueFormChefProjet.username);
                this.deposerProjet1.id = prfu.id;
                this.deposerProjet1.NomProjet.Text = prfu.nom;
                this.deposerProjet1.TypeProjet.Text = "PRFU";

            }
            else
            {
                MessageBox.Show(BienvenueFormChefProjet.username);
                Projet projet = (Projet)bd.GetProjet(BienvenueFormChefProjet.username);
                this.deposerProjet1.id = projet.id;
                this.deposerProjet1.NomProjet.Text = projet.nom;
                this.deposerProjet1.TypeProjet.Text = "Simple";
            }
            this.deposerProjet1.Show();
        }
    }
}
