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
            IAuthentification.IAuthentification authentification = (IAuthentification.IAuthentification)Activator.GetObject(typeof(IAuthentification.IAuthentification), "tcp://localhost:8085/authentification");
            try
            {
                if (authentification.Login(user, pass))
                {
                    this.Hide();
                    userTextBox.Text = "";
                    passwordTextBox.Text = "";
                    BienvenueForm bienvenueForm = new BienvenueForm(this);
                    bienvenueForm.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch {
                MessageBox.Show("cnx error");
            }
            
        }
    }
}
