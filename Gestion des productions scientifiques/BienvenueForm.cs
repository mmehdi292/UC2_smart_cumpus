using ClassesModele;
using Gestion_des_laboratoires_de_recherche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques
{
    public partial class BienvenueForm : Form
    {
        public LoginForm lf;
        public static string username;
        public static string type;

        public BienvenueForm(LoginForm lf,string user, string t)
        {
            InitializeComponent();
            this.fournirProduction1.Hide();
            this.mesProduction1.Hide();
            this.profile1.Hide();
            this.form1.Hide();
            this.notification1.Hide();
            this.lf = lf;
            username = user;
            type = t;
        }

        private void fournirproduction_Click(object sender, EventArgs e)
        {
            this.fournirProduction1.Show();
            this.mesProduction1.Hide();
            this.profile1.Hide();
            this.form1.Hide();
            this.notification1.Hide();
        }

        private void consulterpro_Click(object sender, EventArgs e)
        {
            this.fournirProduction1.Hide();
            this.mesProduction1.Show();
            this.profile1.Hide();
            this.form1.Hide();
            this.notification1.Hide();

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            IUsersInfo.IUsersInfo usersInfo = (IUsersInfo.IUsersInfo)Activator.GetObject(typeof(IUsersInfo.IUsersInfo), "tcp://localhost:8085/userInfo");
            Chercheur c = usersInfo.GetChercheur(BienvenueForm.username);
            this.profile1.nom.Text = c.nom;
            this.profile1.prenom.Text = c.prenom;
            this.profile1.DataNais.Text = c.date_nais.ToString();
            this.profile1.lieu.Text = c.lieu_nais;
            this.profile1.adresse.Text = c.adresse;
            this.profile1.email.Text = c.email;
            this.profile1.username.Text = c.username;

            if (c.sexe == "Male")
                this.profile1.sexe.SelectedIndex = 0;
            else
                this.profile1.sexe.SelectedIndex = 1;
            this.profile1.domaine.Text = c.domaine;
            this.profile1.interet.Text = c.interet[0];
            this.profile1.type.Text = type;
            this.profile1.Show();
            this.fournirProduction1.Hide();
            this.mesProduction1.Hide();
            this.form1.Hide();
            this.notification1.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            lf.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.form1.ClearData();
            this.form1.DataInTableDataShow();
            this.form1.Show();
            this.profile1.Hide();
            this.fournirProduction1.Hide();
            this.mesProduction1.Hide();
            this.notification1.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.notification1.ClearData();
            this.notification1.DataInTableDataShow();
            this.notification1.Show();
            this.form1.Hide();
            this.profile1.Hide();
            this.fournirProduction1.Hide();
            this.mesProduction1.Hide();
        }
    }
}
