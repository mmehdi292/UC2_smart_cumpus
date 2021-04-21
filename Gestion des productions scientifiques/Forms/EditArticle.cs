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
    public partial class EditArticle : Form
    {
        int id;

        byte[] pdfContanet;
        public EditArticle()
        {
            InitializeComponent();
        }
        public EditArticle(Article article)
        {
            InitializeComponent();
            this.nom.Text = article.nom;
            this.Description.Text = article.desc;
            this.motCle.Text = article.motcle;
            this.pages.Value = article.pages;
            this.fileName.Text = "pdf loaded";
            this.langue.Text = article.langue;
            this.id = article.id;
            this.pdfContanet = article.pdf;
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";
            this.openFileDialog1.ShowDialog();
            string fileName = this.openFileDialog1.FileName;
            this.fileName.Text = fileName;
        }

        private void ajouterArticleButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string description = this.Description.Text;
            string motCle = this.motCle.Text;
            int pages = (int)this.pages.Value;
            /*if (this.fileName.Text != "pdf loaded") { 
                string fileName = this.fileName.Text;
                FileStream pdfFile = File.OpenRead(fileName);
                byte[] pdfContanet = new byte[pdfFile.Length];
                pdfFile.Read(pdfContanet, 0, (int)pdfFile.Length);
                pdfFile.Close();
            }*/
            string langue = this.langue.Text;
            Article a = new Article(id, nom, DateTime.Now, description, motCle, BienvenueForm.username, pages, pdfContanet, langue);
            DataBases bd = new DataBases();
            if (bd.ModArticle(a))
            {
                MessageBox.Show("bien Mofidier");
            }
            else
            {
                MessageBox.Show("erreur de modification");
            }
        }
    }
}
