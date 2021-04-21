using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_laboratoires_de_recherche.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_laboratoires_de_recherche.Usercontorls
{
    public partial class consluterEquipes : UserControl
    {
        public consluterEquipes()
        {
            InitializeComponent();
        }
        public void DataInTable()
        {
            DataBases bd = new DataBases();
            List<Equipe> equipes= bd.GetEquipes();
            foreach (Equipe equipe in equipes)
            {
                this.DataShow.Rows.Add(equipe.id, equipe.nom, equipe.chefUser, equipe.lab.acronyme);
            }


        }
        public void ClearData()
        {
            this.DataShow.Rows.Clear();
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            DataBases bd = new DataBases();
            List<Equipe> equipes = bd.SearchEquipe(guna2TextBox2.Text);
            ClearData();
            if (guna2TextBox2.Text.Length != 0)
            {
                foreach (Equipe equipe in equipes)
                {
                    this.DataShow.Rows.Add(equipe.id, equipe.nom, equipe.chefUser, equipe.lab.acronyme);
                }
            }
            else
            {
                DataInTable();
            }
        }

        private void DataShow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)

        {
            DataBases bd = new DataBases();
            if (DataShow.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShow.Rows[e.RowIndex].Cells[1].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bd.DeleteEquipe(Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString()));
                }
            }
            if (DataShow.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int id = Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nom = DataShow.Rows[e.RowIndex].Cells[1].Value.ToString();
                string userchef = DataShow.Rows[e.RowIndex].Cells[2].Value.ToString();
                string acro = DataShow.Rows[e.RowIndex].Cells[3].Value.ToString();
                Equipe eq = new Equipe(id,nom,userchef,new Laboratoire(acro,"",0,""));
                EditEquipe l = new EditEquipe(eq, this);
                l.Show();

            }
            ClearData();
            DataInTable();
        }
    }
}
