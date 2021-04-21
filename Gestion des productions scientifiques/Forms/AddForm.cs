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

namespace Gestion_des_productions_scientifiques.Forms
{
    public partial class AddForm : Form
    {
        List<String> files;
        string username;
        public AddForm(string username)
        {
            InitializeComponent();
            this.username = username;
            files = new List<String>();
        }

        private void ajouterArticleButton_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string desc = this.Description.Text;
            Forum form = new Forum(0,nom,DateTime.Now,desc,username);
            DataBases bd = new DataBases();
            if (bd.addForum(form)) {
                MessageBox.Show("Bien ajouter");
                this.Close();
            }
            else {
                MessageBox.Show("Bien ajouter");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
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
