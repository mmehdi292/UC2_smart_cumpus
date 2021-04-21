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

namespace Gestion_des_laboratoires_de_recherche.Usercontorls
{
    public partial class AjouterEquipe : UserControl
    {
        public AjouterEquipe()
        {
            InitializeComponent();
            updateComboData();



        }
        public void updateComboData() {
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            try
            {
                DataBases bd = new DataBases();
                List<ChefEquipe> chefEquipes = usersInfo.GetChefs();
                foreach (ChefEquipe chefEquipe in chefEquipes)
                {

                    this.ChefCombo.Items.Add(chefEquipe);
                }
                List<Laboratoire> laboratoires = bd.GetLaboratoires();
                foreach (Laboratoire laboratoire in laboratoires)
                {

                    this.laboCombo.Items.Add(laboratoire);
                }
            }
            catch
            {

            }
        }
        

        private void ajouterEquipeButton_Click(object sender, EventArgs e)
        {
            
            string[] acro = laboCombo.Text.Split(',');
            string[] chef = ChefCombo.Text.Split(',');
            Equipe equipe = new Equipe(0,nomEquipe.Text, chef[1], new Laboratoire(acro[1], "",0,""));
            DataBases bd = new DataBases();
            if (bd.AjouterEquipe(equipe)) { 
                MessageBox.Show("bien ajouter");
                nomEquipe.Text = "";
                laboCombo.SelectedIndex = -1;
                ChefCombo.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Error");
        }
    }
}
