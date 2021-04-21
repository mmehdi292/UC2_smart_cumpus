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

namespace Gestion_des_projets_scientifiques.UserControls
{
    public partial class DeposerProjet : UserControl
    {
        public List<String> files;
        public int id;
        public DeposerProjet()
        {
            InitializeComponent();
            DataBases bd = new DataBases();
            if (TypeProjet.Text == "PRFU")
            {
                //PRFU prfu = bd.GetPRFU(BienvenueFormChefProjet.username);
                
                //this.id = prfu.id;
                //this.NomProjet.Text = prfu.nom;
                
            }
            else {
                //MessageBox.Show(BienvenueFormChefProjet.username);
                //Projet projet = (Projet) bd.GetProjet(BienvenueFormChefProjet.username);
               //MessageBox.Show(projet.id+" "+projet.nom);
                //id = projet.id;
                //this.NomProjet.Text = projet.nom;
            }
            

            files = new List<string>();
        }

        private void ajouterLivreButton_Click(object sender, EventArgs e)
        {
            List<byte[]> filesBytes = new List<byte[]>();
            foreach (string file in files)
            {

                FileStream pdfFile = File.OpenRead(file);
                byte[] pdfContanet = new byte[pdfFile.Length];
                pdfFile.Read(pdfContanet, 0, (int)pdfFile.Length);
                pdfFile.Close();
                filesBytes.Add(pdfContanet);

            }
            if (TypeProjet.Text == "PRFU")
            {
                

            }
            else
            {
                
            }
        }

        private void addPdf_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ShowDialog();
            foreach (String file in this.openFileDialog1.FileNames)
            {
                files.Add(file);
            }
            this.fileName.Text = "le(s) fichier(s) selecter";
        }
    }
}
