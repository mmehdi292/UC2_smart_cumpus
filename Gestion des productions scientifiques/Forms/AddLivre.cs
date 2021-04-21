using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques.Forms
{
    public partial class AddLivre : Form
    {
        public AddLivre()
        {
            InitializeComponent();
        }

        private void addPdf_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";
            this.openFileDialog1.ShowDialog();
            string fileName = this.openFileDialog1.FileName;
            this.fileName.Text = fileName;
        }

        private void ajouterLivreButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string description = this.desc.Text;
            string motCle = this.motcle.Text;
            int pages = (int)this.pages.Value;
            string fileName = this.fileName.Text;
            FileStream pdfFile = File.OpenRead(fileName);
            byte[] pdfContanet = new byte[pdfFile.Length];
            pdfFile.Read(pdfContanet, 0, (int)pdfFile.Length);
            pdfFile.Close();
            int version = (int)this.version.Value;
            string langue = this.langue.Text;
            Livre livre = new Livre(0, nom, DateTime.Now, description, motCle, BienvenueForm.username, pages, pdfContanet,version,langue);
            DataBases bd = new DataBases();
            if (bd.addLivre(livre))
            {
                MessageBox.Show("bien ajouter");
            }
            else
            {
                MessageBox.Show("erreur d'ajouter");
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void version_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void pages_ValueChanged(object sender, EventArgs e)
        {

        }

        private void motcle_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void langue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
