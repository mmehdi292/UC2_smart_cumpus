using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_chercheurs.UserForms;
using System;
using System.Windows.Forms;

namespace Gestion_des_chercheurs.Forms
{
    public partial class EditCharcheur : Form
    {
        ConsulterCher cc;

        public EditCharcheur(String username, string type, ConsulterCher cc)
        {
            InitializeComponent();
            this.cc = cc;
            Chercheur c = null;
            DataBases bd = new DataBases();
            if (type == "chercheur")
            {
                 c = bd.GetChercheur(username);
            }
            else if (type == "chef")
            {
                 c = bd.GetChef(username);
            }
            else if (type == "directeur")
            {
                 c = bd.GetDirectuer(username);
            }
            else { }
            this.nom.Text = c.nom;
            this.prenom.Text = c.prenom;
            this.DataNais.Value = c.date_nais;
            this.lieu.Text = c.lieu_nais;
            this.adresse.Text = c.adresse;
            this.username.Text = c.username;
            this.password.Text = "";
            this.email.Text = c.email;
            this.sexe.SelectedItem = c.sexe;
            this.interet.Text = c.interet[0];
            this.domaine.Text = c.domaine;



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
            DataBases bd = new DataBases();
            
            if (this.ChercheurCheckBox.Checked)
            {
                bd.DeleteChef(username);
                bd.DeleteCher(username);
                bd.DeleteDirecture(username);
                if (bd.AddChercheur(ch))
                {
                    MessageBox.Show("Bien modifier");
                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
            else if (this.ChefCheckBox.Checked)
            {
                bd.DeleteChef(username);
                bd.DeleteCher(username);
                bd.DeleteDirecture(username);
                if (bd.AddChef(ch))
                {
                    MessageBox.Show("Bien modifier");
                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
            else if (this.DirectureCheckBox.Checked)
            {
                bd.DeleteChef(username);
                bd.DeleteCher(username);
                bd.DeleteDirecture(username);
                if (bd.AddDirecteur(ch))
                {
                    MessageBox.Show("Bien modifier");
                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
            else
            {
                MessageBox.Show("a choisi une option (chercheur,Directeur,Chef)");
            }
            this.cc.ClearData();
            this.cc.DataInTable();
        }

        private void ChercheurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChercheurCheckBox.Checked)
            {
                ChefCheckBox.Checked = false;
                DirectureCheckBox.Checked = false;
            }
        }

        private void ChefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChefCheckBox.Checked)
            {
                ChercheurCheckBox.Checked = false;
                DirectureCheckBox.Checked = false;
            }
        }

        private void DirectureCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (DirectureCheckBox.Checked)
            {
                ChefCheckBox.Checked = false;
                ChercheurCheckBox.Checked = false;
            }
        }
    }
}
