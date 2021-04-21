using Gestion_des_productions_scientifiques.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_productions_scientifiques.UserControls
{
    public partial class FournirProduction : UserControl
    {
        public FournirProduction()
        {
            InitializeComponent();
        }

        private void ajouterConferenceButton_Click(object sender, EventArgs e)
        {
            AddConference addConference = new AddConference();
            addConference.Show();
        }

        private void ajouterArticleButton_Click(object sender, EventArgs e)
        {
            
            AddArticle addArticle = new AddArticle();
            addArticle.Show();
        }

        private void ajouterLivreButton_Click(object sender, EventArgs e)
        {
            AddLivre addLivre = new AddLivre();
            addLivre.Show();
        }
    }
    
}
