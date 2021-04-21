using ClassesModele;
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
    public partial class NotificationViewer : Form
    {
        public NotificationViewer(Conference f)
        {
            InitializeComponent();
            this.nom.Text = f.nom;
            this.desc.Text = f.desc;
            this.motcle.Text = f.motcle;
            this.lieu.Text = f.lieu;
            this.places.Value = f.places;
            this.salle.Text = f.salle;
            this.dure.Text = f.dure;
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
