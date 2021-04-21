using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques.Forms
{
    public partial class AddConference : Form
    {
        List<string> files;
        int id;
        public AddConference()
        {
            InitializeComponent();
            files = new List<string>();
        }

        private void addfiles_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ShowDialog();
            foreach (String file in this.openFileDialog1.FileNames) {
                files.Add(file);
                Debug.WriteLine(file);
            }
            this.FileName.Text = "le(s) fichier(s) selecter";
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
            foreach (string file in files) {

                FileStream pdfFile = File.OpenRead(file);
                byte[] pdfContanet = new byte[pdfFile.Length];
                pdfFile.Read(pdfContanet, 0, (int)pdfFile.Length);
                pdfFile.Close();
                filesBytes.Add(pdfContanet);

            }
            string dure = this.dure.Text;
            Conference a = new Conference(0, nom, DateTime.Now, description, motCle, BienvenueForm.username, lieu,places,salle,filesBytes,dure);
            DataBases bd = new DataBases();
            if (bd.addConference(a))
            {
                MessageBox.Show("bien ajouter");
            }
            else
            {
                MessageBox.Show("erreur d'ajouter");
            }
        }

        private void dure_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
