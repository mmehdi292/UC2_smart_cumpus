using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_laboratoires_de_recherche
{
    public partial class BienvenueForm : Form
    {
        LoginForm lf;
        public BienvenueForm(LoginForm lf)
        {
            InitializeComponent();
            this.consluterEquipes1.Hide();
            this.consulterLabo1.Hide();
            this.ajouterEquipe1.Hide();
            this.ajouterLabo1.Hide();
            this.lf = lf;

        }

        private void ajouterLabo_Click(object sender, EventArgs e)
        {
            this.ajouterLabo1.Directeur.Items.Clear();
            this.ajouterLabo1.updateCombo();
            this.consluterEquipes1.Hide();
            this.consulterLabo1.Hide();
            this.ajouterEquipe1.Hide();
            this.ajouterLabo1.Show();
        }

        private void consulterLabo_Click(object sender, EventArgs e)
        {
            this.consluterEquipes1.Hide();
            this.consulterLabo1.Show();
            this.ajouterEquipe1.Hide();
            this.ajouterLabo1.Hide();
            this.consulterLabo1.ClearData();
            this.consulterLabo1.DataInTable();
        }

        private void AjouterEquipe_Click(object sender, EventArgs e)
        {
            this.ajouterEquipe1.laboCombo.Items.Clear();
            this.ajouterEquipe1.ChefCombo.Items.Clear();
            this.ajouterEquipe1.updateComboData();
            this.consluterEquipes1.Hide();
            this.consulterLabo1.Hide();
            this.ajouterEquipe1.Show();
            this.ajouterLabo1.Hide();
        }

        private void ConsulterEquipes_Click(object sender, EventArgs e)
        {

            this.consluterEquipes1.ClearData();
            this.consluterEquipes1.DataInTable();
            this.consluterEquipes1.Show();
            this.consulterLabo1.Hide();
            this.ajouterEquipe1.Hide();
            this.ajouterLabo1.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.lf.Show();

        }
    }
}