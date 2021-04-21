using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_laboratoires_de_recherche.Usercontorls;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Gestion_des_laboratoires_de_recherche.Forms
{
    public partial class EditLabo : Form
    {
        public ConsulterLabo consulterLabo;
        public EditLabo()
        {
            InitializeComponent();
        }
        internal EditLabo(Laboratoire la, ConsulterLabo consulterLabo)
        {
            this.consulterLabo = consulterLabo;
            InitializeComponent();
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
            this.acronyme.Text = la.acronyme;
            
            this.nomlaboratoire.Text = la.nom;
            this.anneeCreation.Text = la.anneeCreation.ToString();
            

        }

        private void EditLaboButton_Click(object sender, EventArgs e)
        {
            DataBases bd = new DataBases();
            string[] directeurs = Directeur.Text.Split(',');
            Laboratoire labo = new Laboratoire(acronyme.Text, nomlaboratoire.Text, int.Parse(anneeCreation.Text), directeurs[1]);
            if (bd.EditLabo(labo))
            {
                MessageBox.Show("Bien modifie"); 
            }
            else {
                MessageBox.Show("Erreur sur la modification");
            }
            this.consulterLabo.ClearData();
            this.consulterLabo.DataInTable();
            this.Close();


        }
    }
}
