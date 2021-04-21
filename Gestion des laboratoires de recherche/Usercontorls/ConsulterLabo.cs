using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_laboratoires_de_recherche.Forms;
using Guna.UI2.WinForms;
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
    public partial class ConsulterLabo : UserControl
    {
        public ConsulterLabo()
        {
            InitializeComponent();
            
        }

        public void DataInTable() {
            DataBases bd = new DataBases();
            List<Laboratoire> laboratoires = bd.GetLaboratoires();
            foreach (Laboratoire labo in laboratoires) {
                this.DataShow.Rows.Add(labo.acronyme,labo.nom,labo.anneeCreation,labo.usernameDirecteur);
            }


        }
        public void ClearData() {
            this.DataShow.Rows.Clear();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            DataBases bd = new DataBases();
            List<Laboratoire> laboratoires = bd.SearchLabo(guna2TextBox2.Text);
            ClearData();
            if (guna2TextBox2.Text.Length!=0) {
                foreach (Laboratoire labo in laboratoires)
                {
                    this.DataShow.Rows.Add(labo.acronyme, labo.nom, labo.anneeCreation, labo.usernameDirecteur);
                }
            }
            else {
                DataInTable();
            }
            
            
        }

        private void DataShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();
            Debug.WriteLine(e.RowIndex+"Messs" + e.ColumnIndex);
            if (DataShow.Columns[e.ColumnIndex].Name == "Supprimer") {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShow.Rows[e.RowIndex].Cells[0].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    bd.DeleteLabo(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            if (DataShow.Columns[e.ColumnIndex].Name == "Modifier")
            {
                String acro = DataShow.Rows[e.RowIndex].Cells[0].Value.ToString();
                String nom = DataShow.Rows[e.RowIndex].Cells[1].Value.ToString();
                int annee = Int32.Parse(DataShow.Rows[e.RowIndex].Cells[2].Value.ToString());
                String user = DataShow.Rows[e.RowIndex].Cells[3].Value.ToString();
                Laboratoire labo = new Laboratoire(acro,nom,annee,user);
                EditLabo l = new EditLabo(labo,this);
                l.Show();
                
            }
            ClearData();
            DataInTable();
        }
    }
}
