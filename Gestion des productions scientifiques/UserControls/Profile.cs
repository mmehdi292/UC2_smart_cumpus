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

namespace Gestion_des_productions_scientifiques.UserControls
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void ajouterChercheurButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string prenom = this.prenom.Text;
            DateTime date = Convert.ToDateTime(this.DataNais.Text);
            string lieu = this.lieu.Text;
            string adresse = this.adresse.Text;
            string username = this.username.Text;
            string password = this.password.Text;
            string email = this.email.Text;
            string sexe = this.sexe.Text;
            string[] interets = { this.interet.Text };
            string domaine = this.domaine.Text;
            Chercheur ch = new Chercheur(nom, prenom, date, lieu, adresse, username, password, email, sexe, interets, domaine);
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
               
                if (usersInfo.ModChercheur(ch))
                {
                    MessageBox.Show("Bien modifier");
                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
            
        }
    }
