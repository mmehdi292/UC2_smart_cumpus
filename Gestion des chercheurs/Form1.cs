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

namespace Gestion_des_chercheurs
{
    public partial class Form1 : Form
    {
        public Login login;
        public Form1(Login login)
        {
            InitializeComponent();
            this.login=login;
            this.addCher1.Hide(); 
            this.consulterCher1.Hide();
            this.affectCher1.Hide();

        }

        private void ajouterEq_Click(object sender, EventArgs e)
        {
            this.addCher1.Show();
            this.consulterCher1.Hide();
            this.affectCher1.Hide();
            this.consulterCher1.ClearData();
            this.consulterCher1.DataInTable();
        }

        private void consulterEq_Click(object sender, EventArgs e)
        {
            this.consulterCher1.ClearData();
            this.consulterCher1.DataInTable();
            this.addCher1.Hide();
            this.consulterCher1.Show();
            this.affectCher1.Hide();
        }

        private void affecter_Click(object sender, EventArgs e)
        {
            this.addCher1.Hide();
            this.consulterCher1.Hide();
            this.affectCher1.ClearData();
            this.affectCher1.DataInTable();
            this.affectCher1.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.login.Show();
        }

       
    }
}
