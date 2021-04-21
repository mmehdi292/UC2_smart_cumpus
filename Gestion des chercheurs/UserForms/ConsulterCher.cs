using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_chercheurs.Forms;
using IUsersInfo;
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
    public partial class ConsulterCher : UserControl
    {
        public ConsulterCher()
        {
            InitializeComponent();
            


        }
        private void ChercheurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChercheurCheckBox.Checked)
            {
                ChefCheckBox.Checked = false;
                DirectureCheckBox.Checked = false;
                ClearData();
                DataInTable();
            }
        }

        private void ChefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChefCheckBox.Checked)
            {
                ChercheurCheckBox.Checked = false;
                DirectureCheckBox.Checked = false;
                ClearData();
                DataInTable();
            }
        }

        private void DirectureCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (DirectureCheckBox.Checked)
            {
                ChefCheckBox.Checked = false;
                ChercheurCheckBox.Checked = false;
                ClearData();
                DataInTable();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            DataBases bd = new DataBases();
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
                    List<Directure> directures = bd.SearchDirectures(guna2TextBox2.Text);
                    Debug.WriteLine("----PICK----");
                    foreach (Directure chercheur in directures)
                    {
                        Debug.WriteLine("----PICK----"+chercheur.nom);
                        this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                    }
                }
                else if (ChefCheckBox.Checked)
                {
                    List<ChefEquipe> chefs = bd.SearchChefs(guna2TextBox2.Text);
                    foreach (ChefEquipe chercheur in chefs)
                    {
                        this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                    }
                }
            }
            else { DataInTable(); }
        }

        private void DataShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();
            if (DataShow.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShow.Rows[e.RowIndex].Cells[0].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ChercheurCheckBox.Checked)
                    {
                        if (bd.DeleteCher(DataShow.Rows[e.RowIndex].Cells[5].Value.ToString()))
                            MessageBox.Show("bien supprimer");
                        else
                            MessageBox.Show("error");

                    }
                    if (ChefCheckBox.Checked)
                    {
                        if (bd.DeleteChef(DataShow.Rows[e.RowIndex].Cells[5].Value.ToString()))
                            MessageBox.Show("bien supprimer");
                        else
                            MessageBox.Show("error");
                    }
                    if (DirectureCheckBox.Checked)
                    {
                        if (bd.DeleteDirecture(DataShow.Rows[e.RowIndex].Cells[5].Value.ToString()))
                            MessageBox.Show("bien supprimer");
                        else
                            MessageBox.Show("error");
                    }
                }
            }
            if (DataShow.Columns[e.ColumnIndex].Name == "Modifier")
            {
                String username = DataShow.Rows[e.RowIndex].Cells[5].Value.ToString();
                string type = "";
                if (this.ChercheurCheckBox.Checked) {
                    type = "chercheur";
                }
                else if (this.ChefCheckBox.Checked) {
                    type = "chef";
                }
                else if (this.DirectureCheckBox.Checked) {
                    type = "directeur";
                }
                EditCharcheur l = new EditCharcheur(username, type, this);
                l.Show();

            }
            ClearData();
            DataInTable();

        }
        public void DataInTable()
        {
            DataBases bd = new DataBases();
            if (ChercheurCheckBox.Checked)
            {
                List<Chercheur> chercheurs = bd.GetChercheurs();
                foreach (Chercheur chercheur in chercheurs)
                {
                    this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                }
            }
            if (DirectureCheckBox.Checked)
            {
                List<Directure> directures = bd.GetDirectures();
                foreach (Directure chercheur in directures)
                {
                    this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                }
            }
            if (ChefCheckBox.Checked)
            {
                List<ChefEquipe> chefs = bd.GetChefs();
                foreach (ChefEquipe chercheur in chefs)
                {
                    this.DataShow.Rows.Add(chercheur.nom, chercheur.prenom, chercheur.date_nais, chercheur.lieu_nais, chercheur.email, chercheur.username, chercheur.sexe);
                }
            }

        }
        public void ClearData()
        {
            this.DataShow.Rows.Clear();
        }


    }
}
