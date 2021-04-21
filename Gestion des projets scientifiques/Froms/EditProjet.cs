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
    public partial class EditProjet : Form
    {
        int id;
        public EditProjet(int id,Boolean prfu)
        {
            InitializeComponent();
            DataBases bd = new DataBases();
            Projet p = null;
            if (prfu) { 
                p = bd.GetPRFU(id);
                this.PRFUCheckBox.Checked = true;
            }
            else { 
                p = bd.GetProjet(id);
            }
            this.nom.Text = p.nom;
            this.id = p.id;
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            List<Chercheur> chercheurs = usersInfo.GetChercheurs();
            foreach (Chercheur c in chercheurs)
                this.chef.Items.Add(c.nom + " " + c.prenom + "," + c.username);
            this.chef.SelectedValue = -1;
        }

        private void ajouterProjetButton_Click(object sender, EventArgs e)
        {
            DataBases bd = new DataBases();
            string nom = this.nom.Text;
            string chefText = this.chef.Text;
            string[] username = chefText.Split(',');
            bd.DeletePRFU(id);
            bd.DeleteProjet(id);
            if (this.PRFUCheckBox.Checked)
            {
                PRFU p = new PRFU(0, nom, username[1], true);

                if (bd.AddPRFU(p))
                    MessageBox.Show("Bien Modifier");
                else
                    MessageBox.Show("erruer de Modification");
            }
            else
            {
                Projet p = new Projet(0, nom, username[1]);

                if (bd.AddProjet(p))
                    MessageBox.Show("Bien Modifier");
                else
                    MessageBox.Show("erruer de Modification");

            }

        }
    }
}
