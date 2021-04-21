using Gestion_des_chercheurs.BDclasses;
using Gestion_des_productions_scientifiques;
using Gestion_des_projets_scientifiques;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void Login_Click(object sender, EventArgs e)
        {
            String user = userTextBox.Text;
            String pass = passwordTextBox.Text;
            DataBases bd = new DataBases();
            IAuthentification.IAuthentification authentification = (IAuthentification.IAuthentification)Activator.GetObject(typeof(IAuthentification.IAuthentification), "tcp://localhost:8085/authentification");
            try
            {

                if (authentification.LoginChercheur(user, pass) != null && bd.GetProjet(user)!=null)
                {
                    this.Hide();
                    userTextBox.Text = "";
                    passwordTextBox.Text = "";
                    string type = "Projet simple";
                    BienvenueFormChefProjet bienvenueForm = new BienvenueFormChefProjet(this, user, type);
                    bienvenueForm.Show();
                }
                else {
                    if (authentification.LoginChercheur(user, pass) != null && bd.GetPRFU(user) != null)
                    {
                        this.Hide();
                        userTextBox.Text = "";
                        passwordTextBox.Text = "";
                        string type = "PRFU";
                        BienvenueFormChefProjet bienvenueForm = new BienvenueFormChefProjet(this, user, type);
                        bienvenueForm.Show();
                    }
                    else { 
                        if (authentification.Login(user, pass))
                        {
                            this.Hide();
                            userTextBox.Text = "";
                            passwordTextBox.Text = "";
                            string type = "Admin";
                            BienvenueForm bienvenueForm = new BienvenueForm(this,user, type);
                            bienvenueForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("error");
                        }
                    }
                }
            }
            catch {
                MessageBox.Show("cnx error");
            }
            
        }
    }
}
