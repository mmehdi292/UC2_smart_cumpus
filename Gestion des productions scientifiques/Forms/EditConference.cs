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
    public partial class EditConference : Form
    {
        List<string> files;
        public int Id;
        public EditConference()
        {
            InitializeComponent();
            files = new List<string>();
        }
        public EditConference(Conference c)
        {
            InitializeComponent();
            this.Id = c.id;
            this.nom.Text = c.nom;
            this.desc.Text = c.desc;
            this.motcle.Text = c.motcle;
            this.lieu.Text = c.lieu;
            this.places.Value = c.places;
            this.salle.Text = c.salle;
            this.dure.Text = c.dure;

        }

      

        
        private void ajouterConferenceButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string description = this.desc.Text;
            string motCle = this.motcle.Text;
            string lieu = this.lieu.Text;
            int places = (int)this.places.Value;
            string salle = this.salle.Text;
            List<byte[]> filesBytes = new List<byte[]>();
            if (this.FileName.Text == "le(s) fichier(s) selecter") {
                
                foreach (string file in files)
                {
                    FileStream pdfFile = File.OpenRead(file);
                    byte[] pdfContanet = new byte[pdfFile.Length];
                    pdfFile.Read(pdfContanet, 0, (int)pdfFile.Length);
                    pdfFile.Close();
                    filesBytes.Add(pdfContanet);

                }
            }
            string dure = this.dure.Text;
            Conference a = new Conference(Id, nom, DateTime.Now, description, motCle, BienvenueForm.username, lieu, places, salle, filesBytes, dure);
            DataBases bd = new DataBases();
            if (bd.ModConfernce(a))
            {
                MessageBox.Show("bien modifier");
            }
            else
            {
                MessageBox.Show("erreur de modification");
            }
        }

        private void addfiles_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ShowDialog();
            foreach (String file in this.openFileDialog1.FileNames)
            {
                files.Add(file);
            }
            this.FileName.Text = "le(s) fichier(s) selecter";
        }
    }
}

