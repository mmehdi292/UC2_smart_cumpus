using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_laboratoires_de_recherche.Usercontorls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_laboratoires_de_recherche.Forms
{
    public partial class EditEquipe : Form
    {
        consluterEquipes ce;
        public EditEquipe()
        {
            InitializeComponent();
        }
        internal EditEquipe(Equipe e, consluterEquipes ce)
        {
            InitializeComponent();
            this.ce = ce;
            this.nomEquipe.Text = e.nom;
            this.IDText.Text = e.id+"";
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

        private void ModifierEquipeButton_Click(object sender, EventArgs e)
        {

            string[] acro = laboCombo.Text.Split(',');
            string[] chef = ChefCombo.Text.Split(',');
            Equipe equipe = new Equipe(Int32.Parse(IDText.Text), nomEquipe.Text, chef[1], new Laboratoire(acro[1], "", 0, ""));
            DataBases bd = new DataBases();
            if (bd.EditEquipe(equipe))
            {
                MessageBox.Show("bien modifier");
                
            }
            else
                MessageBox.Show("Error");

            this.ce.ClearData();
            this.ce.DataInTable();
            this.Close();
        }

    }
}
