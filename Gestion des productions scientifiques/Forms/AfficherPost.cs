using ClassesModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques.Forms
{
    public partial class AfficherPost : Form
    {
        public AfficherPost(Forum f)
        {
            InitializeComponent();
            this.title.Text = f.nom;
            this.desc.Text = f.description;
            this.date.Text = f.date.ToString();
            this.username.Text = f.username;
        }

        private void like_Click(object sender, EventArgs e)
        {
            this.like.FillColor = Color.LightSkyBlue;
        }

        private void Deslike_Click(object sender, EventArgs e)
        {
            this.Deslike.FillColor = Color.LightSkyBlue;
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Commantaire bien ajouter");
        }
    }
}
