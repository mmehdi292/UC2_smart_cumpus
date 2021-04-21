using ClassesModele;
using Gestion_des_chercheurs.BDclasses;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_chercheurs.UserForms
{
    public partial class AddCher : UserControl
    {
        public AddCher()
        {
            InitializeComponent();
        }
        public void clearFileds() {
            this.nom.Text = "";
            this.prenom.Text = "";
            this.DataNais.Text = "";
            this.lieu.Text = "";
            this.adresse.Text = "";
            this.username.Text = "";
            this.password.Text = "";
            this.email.Text = "";
            this.sexe.Text = "";
            this.interet.Text = "";
            this.domaine.Text = "";
            this.ChercheurCheckBox.Checked = false;
            this.ChercheurCheckBox.Checked = false;
            this.ChercheurCheckBox.Checked = false;

        }

        private void ajouterChercheurButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string prenom = this.prenom.Text;
            DateTime date = Convert.ToDateTime(this.DataNais.Text);
            Debug.WriteLine("---------- "+date);
            string lieu = this.lieu.Text;
            string adresse = this.adresse.Text;
            string username = this.username.Text;
            string password = this.password.Text;
            string email = this.email.Text;
            string sexe = this.sexe.Text;
            string[] interets = { this.interet.Text };
            string domaine = this.domaine.Text;
            Chercheur ch = new Chercheur(nom,prenom,date,lieu,adresse,username,password,email,sexe,interets,domaine);
            DataBases bd = new DataBases();
            if (this.ChercheurCheckBox.Checked) {
                if (bd.AddChercheur(ch))
                {
                    MessageBox.Show("Bien ajouter");
                    clearFileds();
                }
                else {
                    MessageBox.Show("erreur");
                }
            }
            else if (this.ChefCheckBox.Checked) {
                if (bd.AddChef(ch))
                {
                    MessageBox.Show("Bien ajouter");
                    clearFileds();
                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
            else if (this.DirectureCheckBox.Checked) {
                if (bd.AddDirecteur(ch))
                {
                    MessageBox.Show("Bien ajouter");
                    clearFileds();
                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
            else {
                MessageBox.Show("a choisi une option (chercheur,Directeur,Chef)");
            }
        }

        private void ChercheurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ChercheurCheckBox.Checked){
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
            
            if(DirectureCheckBox.Checked){
                ChefCheckBox.Checked = false;
                ChercheurCheckBox.Checked = false;
            }
        }
    }
}
