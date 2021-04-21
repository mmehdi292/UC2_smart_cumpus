using Gestion_des_chercheurs.BDclasses;
using Gestion_des_chercheurs.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_chercheurs.Forms
{
    public partial class Affectation : Form
    {
        public AffectCher af;
        public Affectation(AffectCher af)
        {
            InitializeComponent();
            this.af = af;
            
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            string[] username = this.chercheur.Text.Split(',');
            string[] equipes = this.equipes.Text.Split(',');
            int id = Int32.Parse(equipes[0]);
            DataBases bd = new DataBases();
            bd.DeleteAffercation(username[1]);
            if (bd.AddAffercation(username[1], id))
                MessageBox.Show("Bien affecter");
            else
                MessageBox.Show("Error sur l'affectation");
            af.ClearData();
            af.DataInTable();
        }
    }
}
