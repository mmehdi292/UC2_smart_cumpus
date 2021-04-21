using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_chercheurs.Forms;
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
    public partial class AffectCher : UserControl
    {
        public AffectCher()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            /*
             * IGetEquipes.IGetEquipes getEquipes = (IGetEquipes.IGetEquipes)Activator.GetObject(typeof(IGetEquipes.IGetEquipes), "tcp://localhost:8086/getEquipes");
            try
            {
                
                List<IGetEquipes.Equipe> equipes = getEquipes.GetEquipes();
                foreach (IGetEquipes.Equipe equipe in equipes)
                {

                    //this.ChefCombo.Items.Add(chefEquipe);
                }
                
            }
            catch
            {

            }
             * 
             * 
             * DataBases bd = new DataBases();
            ClearData();
            if (guna2TextBox2.Text.Length != 0)
            {
                if (ChercheurCheckBox.Checked)
                {
                    List<Chercheur> chercheurs = bd.SearchChercheurs(guna2TextBox2.Text);
                    foreach (Chercheur chercheur in chercheurs)
                    {
                        this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                    }
                }
                else if (DirectureCheckBox.Checked)
                {
                    List<IUsersInfo.Directure> directures = bd.SearchDirectures(guna2TextBox2.Text);
                    Debug.WriteLine("----PICK----");
                    foreach (IUsersInfo.Directure chercheur in directures)
                    {
                        Debug.WriteLine("----PICK----" + chercheur.nom);
                        this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                    }
                }
                else if (ChefCheckBox.Checked)
                {
                    List<IUsersInfo.ChefEquipe> chefs = bd.SearchChefs(guna2TextBox2.Text);
                    foreach (IUsersInfo.ChefEquipe chercheur in chefs)
                    {
                        this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                    }
                }
            }
            else { DataInTable(); }*/
        }

        public void DataInTable()
        {
            DataBases bd = new DataBases();
            List<Chercheur> chercheurs = bd.GetChercheurs();
            List<ChercherAffectaion> chercherAffectaions = bd.GetAffectaions();
            foreach (Chercheur chercheur in chercheurs)
            {
                bool isAffected = false;
                foreach (ChercherAffectaion c in chercherAffectaions) {

                    if (c.username == chercheur.username) { isAffected = true; break; }
                }
                if (isAffected)
                    this.DataShow.Rows.Add(chercheur.nom + "" + chercheur.prenom, chercheur.username, "affecter");
                else
                {
                    this.DataShow.Rows.Add(chercheur.nom + "" + chercheur.prenom, chercheur.username, "non-affecter");
                   
                }

            }
        }
        public void ClearData()
        {
            this.DataShow.Rows.Clear();
        }

        private void DataShow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataBases bd = new DataBases();
            Debug.WriteLine("------" + DataShow.Columns[e.ColumnIndex].Name);
            if (DataShow.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (DataShow.Rows[e.RowIndex].Cells[2].Value.ToString() == "non-affecter") { MessageBox.Show("pas d'affectation"); }
                else
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShow.Rows[e.RowIndex].Cells[1].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (bd.DeleteAffercation(DataShow.Rows[e.RowIndex].Cells[1].Value.ToString()))
                        MessageBox.Show("bien supprimer");
                    else
                        MessageBox.Show("error");

                }
            }
            if (DataShow.Columns[e.ColumnIndex].Name == "Affecter_modifier")
            {
                String name = DataShow.Rows[e.RowIndex].Cells[0].Value.ToString();
                String username = DataShow.Rows[e.RowIndex].Cells[1].Value.ToString();
                Affectation l = new Affectation(this);
                l.chercheur.Text = name + " ," + username;
                IGetEquipes.IGetEquipes getEquipes = (IGetEquipes.IGetEquipes)Activator.GetObject(typeof(IGetEquipes.IGetEquipes), "tcp://localhost:8086/getEquipes");
                try
                {

                    List<Equipe> equipes = getEquipes.GetEquipes();
                    foreach (Equipe equipe in equipes)
                    {

                        l.equipes.Items.Add(equipe);
                    }
                    l.Show();

                }
                catch
                {
                    MessageBox.Show("verfier la cnx ");
                }
                

            }
            ClearData();
            DataInTable();
        }
    }
}
