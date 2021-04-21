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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String user = userTextBox.Text;
            String pass = passwordTextBox.Text;
            DataBases bd = new DataBases();
            if (bd.Login(user, pass))
                {
                    this.Hide();
                    userTextBox.Text = "";
                    passwordTextBox.Text = "";
                    Form1 bienvenueForm = new Form1(this);
                    bienvenueForm.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            
        }
    }
