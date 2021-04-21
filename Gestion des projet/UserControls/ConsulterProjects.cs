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
    public partial class ConsulterProjects : UserControl
    {
        public ConsulterProjects()
        {
            InitializeComponent();
        }

        private void DataShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();

            if (DataShow.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShow.Rows[e.RowIndex].Cells[1].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(guna2CheckBox1.Checked)
                        if (bd.DeletePRFU(Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString())))
                            MessageBox.Show("bien supprimer");
                        else
                            MessageBox.Show("error");
                    else
                        if (bd.DeleteProjet(Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString())))
                            MessageBox.Show("bien supprimer");
                        else
                            MessageBox.Show("error");
                }
            }
            if (DataShow.Columns[e.ColumnIndex].Name == "Modifier")
            {

                int id = Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (guna2CheckBox1.Checked) {
                    Projet projet = bd.GetPRFU(id);
                }
                else {
                    Projet projet = bd.GetProjet(id);
                }
                //EditConference l = new EditConference(c);
                //l.Show();
                MessageBox.Show("Modifier");

            }
            if (DataShow.Columns[e.ColumnIndex].Name == "Affecation")
            {
                int id = Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                //EditCharcheur l = new EditCharcheur(username, type, this);
                //l.Show();
                MessageBox.Show("VoirPDFs");

            }
            ClearData();
            DataInTableDataShow();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                SimpleCheckBox.Checked = false;
                ClearData();
                DataInTableDataShow();
            }
            else
            {
                ClearData();
            }
        }

        private void SimpleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SimpleCheckBox.Checked)
            {
                guna2CheckBox1.Checked = false;
                ClearData();
                DataInTableDataShow();
            }
            else
            {
                ClearData();
            }
        }
        public void ClearData()
        {
            this.DataShow.Rows.Clear();
        }
        public void DataInTableDataShow()
        {
            List<Projet> projets = null;
            DataBases bd = new DataBases();
            if (SimpleCheckBox.Checked)
            {
                projets = bd.GetProjets();
            }
            else if(guna2CheckBox1.Checked) {
                projets = bd.GetPRFUs();
            }
            
            foreach (Projet projet in projets)
            {
                this.DataShow.Rows.Add(projet.id, projet.nom, projet.username);
            }
        }
    }
}
