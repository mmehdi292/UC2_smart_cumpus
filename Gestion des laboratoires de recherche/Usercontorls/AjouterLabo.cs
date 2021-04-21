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

namespace Gestion_des_laboratoires_de_recherche
{
    public partial class AjouterLabo : UserControl
    {
        public AjouterLabo()
        {
            
            InitializeComponent();
            updateCombo();


        }
        public void updateCombo() {
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            try
            {

                List<Directure> directures = usersInfo.GetDirectures();
                foreach (Directure directure in directures)
                {

                    this.Directeur.Items.Add(directure);
                }

            }
            catch
            {

            }

        }

        private void ajouterLaboButton_Click(object sender, EventArgs e)
        {
            string[] directeurs = Directeur.Text.Split(',');
            Laboratoire labo = new Laboratoire(acronyme.Text, nomlaboratoire.Text, int.Parse(anneeCreation.Text), directeurs[1]);
            DataBases bd = new DataBases();
            if (bd.AjouterLabo(labo)) { 
                MessageBox.Show("bien ajouter");
                acronyme.Text = "";
                nomlaboratoire.Text = "";
                anneeCreation.Text = "";
                Directeur.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Error");
        }

        private void acronyme_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void nomlaboratoire_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void anneeCreation_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Directeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
