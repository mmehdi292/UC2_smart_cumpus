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
    public partial class EditLivre : Form
    {
        int id;

        byte[] pdfContanet;
        public EditLivre()
        {
            InitializeComponent();
        }
        public EditLivre(Livre livre)
        {
            InitializeComponent();
            this.nom.Text = livre.nom;
            this.desc.Text = livre.desc;
            this.motcle.Text = livre.motcle;
            this.pages.Value = livre.pages;
            pdfContanet = livre.pdf;
            this.version.Value = livre.version;
            this.langue.Text = livre.langue;
            id = livre.id;
            this.fileName.Text = "pdf loaded";
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
            if (this.fileName.Text != "pdf loaded") { 
                string fileName = this.fileName.Text;
                FileStream pdfFile = File.OpenRead(fileName);
                byte[] pdfContanet = new byte[pdfFile.Length];
                pdfFile.Read(pdfContanet, 0, (int)pdfFile.Length);
                pdfFile.Close();
            }
            int version = (int)this.version.Value;
            string langue = this.langue.Text;
            Livre livre = new Livre(id, nom, DateTime.Now, description, motCle, BienvenueForm.username, pages, pdfContanet, version, langue);
            DataBases bd = new DataBases();
            if (bd.ModLivre(livre))
            {
                MessageBox.Show("bien ajouter");
            }
            else
            {
                MessageBox.Show("erreur d'ajouter");
            }
        }
    }
}
