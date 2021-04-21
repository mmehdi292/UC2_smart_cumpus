using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using Gestion_des_productions_scientifiques.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques.UserControls
{
    public partial class Form : UserControl
    {
        public Form()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddForm l = new AddForm(BienvenueForm.username);
            l.Show();
        }

        private void DataShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();

            if (DataShow.Columns[e.ColumnIndex].Name == "Afficher")
            {
                int id = Int32.Parse(DataShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                Forum f = bd.getForum(id);
                AfficherPost p = new AfficherPost(f);
                p.Show();
            }
            ClearData();
            DataInTableDataShow();

        }
        public void DataInTableDataShow()
        {
            DataBases bd = new DataBases();

            List<Forum> forums = bd.getForums();
            foreach (Forum forum in forums)
            {
                this.DataShow.Rows.Add(forum.id, forum.nom, forum.date, forum.description, forum.username);
            }
        }
        public void ClearData()
        {
            this.DataShow.Rows.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
