using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_projet.Froms
{
    public partial class Affectation : Form
    {
        Projet p;
        Boolean prfu;
        public Affectation(Projet p, Boolean prfu)
        {
            InitializeComponent();
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            List<Chercheur> chercheurs = usersInfo.GetChercheurs();
            foreach (Chercheur c in chercheurs) {
                this.ch1.Items.Add(c.nom + " " + c.prenom + "," + c.username);
                this.ch2.Items.Add(c.nom + " " + c.prenom + "," + c.username);
                this.ch3.Items.Add(c.nom + " " + c.prenom + "," + c.username);
                this.ch4.Items.Add(c.nom + " " + c.prenom + "," + c.username);
            }
            this.p = p;
            this.prfu = prfu;
            this.nom.Text = p.nom;
        }

        private void ajouterProjetButton_Click(object sender, EventArgs e)
        {
            string chefText = this.ch1.Text;
            string[] username1 = chefText.Split(',');

            string chefText1 = this.ch2.Text;
            string[] username2 = chefText1.Split(',');

            string chefText2 = this.ch3.Text;
            string[] username3 = chefText2.Split(',');

            string chefText3 = this.ch4.Text;
            string[] username4 = chefText3.Split(',');
            DataBases bd = new DataBases();
            if (prfu)
            {
                if (bd.AddChercheurPRFU(p.id, username1[1]) && bd.AddChercheurPRFU(p.id, username2[1]) && bd.AddChercheurPRFU(p.id, username3[1]) && bd.AddChercheurPRFU(p.id, username4[1]))
                    MessageBox.Show("Bien ajouter");
                else
                    MessageBox.Show("erreur");
            }
            else {
                if (bd.AddChercheurProjet(p.id, username1[1]) && bd.AddChercheurProjet(p.id, username2[1]) && bd.AddChercheurProjet(p.id, username3[1]) && bd.AddChercheurProjet(p.id, username4[1]))
                    MessageBox.Show("Bien ajouter");
                else
                    MessageBox.Show("erreur");
            }


        }
    }
}
