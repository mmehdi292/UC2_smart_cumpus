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

namespace Gestion_des_projets_scientifiques.UserControls
{
    public partial class addProject : UserControl
    {
        public addProject()
        {
            InitializeComponent();
        }

        private void ajouterProjetButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string chefText = this.chef.Text;
            string[] username = chefText.Split(',');
            DataBases bd = new DataBases();
            if (this.PRFUCheckBox.Checked)
            {
                PRFU p = new PRFU(0,nom,username[1],true);

                if (bd.AddPRFU(p))
                    MessageBox.Show("Bien ajouter");
                else
                    MessageBox.Show("erruer d'ajout");
            }
            else {
                Projet p = new Projet(0, nom, username[1]);

                if (bd.AddProjet(p))
                    MessageBox.Show("Bien ajouter");
                else
                    MessageBox.Show("erruer d'ajout");

            }
            this.nom.Text = "";
            this.chef.SelectedIndex = -1;
        }
    }
}
