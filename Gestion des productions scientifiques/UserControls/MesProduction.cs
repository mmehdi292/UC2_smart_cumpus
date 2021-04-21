using ClassesModele;
using Gestion_des_chercheurs.BDclasses;
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
    public partial class MesProduction : UserControl
    {
        public MesProduction()
        {
            InitializeComponent();
            DataShowArticle.Hide();
            DataShowConference.Hide();
            DataShowLivre.Hide();
        }

        private void LivreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LivreCheckBox.Checked)
            {
                ArticleBox.Checked = false;
                conferenceCheckBox.Checked = false;
                DataShowArticle.Hide();
                DataShowConference.Hide();
                DataShowLivre.Show();
                ClearData();
                DataInTableDataShowLivre();
            }
            else { DataShowLivre.Hide(); }
        }

        private void ArticleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ArticleBox.Checked)
            {
                LivreCheckBox.Checked = false;
                conferenceCheckBox.Checked = false;
                DataShowArticle.Show();
                DataShowConference.Hide();
                DataShowLivre.Hide();
                ClearData();
                DataInTableDataShowArticle();
            }
            else { DataShowArticle.Hide(); }

        }

        private void conferenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (conferenceCheckBox.Checked)
            {
                ArticleBox.Checked = false;
                LivreCheckBox.Checked = false;
                DataShowArticle.Hide();
                DataShowConference.Show();
                DataShowLivre.Hide();
                ClearData();
                DataInTableDataShowConference();
            }
            else {
                DataShowConference.Hide();
            }

        }
        private void DataShowConference_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();

            if (DataShowConference.Columns[e.ColumnIndex].Name == "CSupprimer")
            {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShowConference.Rows[e.RowIndex].Cells[1].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                        if (bd.DeleteConference(Int32.Parse(DataShowConference.Rows[e.RowIndex].Cells[0].Value.ToString())))
                            MessageBox.Show("bien supprimer");
                        else
                            MessageBox.Show("error");
                }
            }
            if (DataShowConference.Columns[e.ColumnIndex].Name == "CModifier")
            {
                
                int id = Int32.Parse(DataShowConference.Rows[e.RowIndex].Cells[0].Value.ToString());
                Conference c = bd.getConference(id);
                EditConference l = new EditConference(c);
                l.Show();
                MessageBox.Show("Modifier");

            }
            if (DataShowConference.Columns[e.ColumnIndex].Name == "VoirPDFs")
            {
                int id = Int32.Parse(DataShowConference.Rows[e.RowIndex].Cells[0].Value.ToString());
                //EditCharcheur l = new EditCharcheur(username, type, this);
                //l.Show();
                MessageBox.Show("VoirPDFs");

            }
            ClearData();
            DataInTableDataShowConference();

        }
        public void DataInTableDataShowConference()
        {
            DataBases bd = new DataBases();
            
            List<Conference> conferences = bd.getConferences(BienvenueForm.username);
            foreach (Conference conference in conferences)
            {
                this.DataShowConference.Rows.Add(conference.id, conference.nom, conference.ajoutDate, conference.desc, conference.lieu,conference.salle ,conference.places, conference.dure);
            }  
        }
        public void ClearData()
        {
            this.DataShowArticle.Rows.Clear();
            this.DataShowConference.Rows.Clear();
            this.DataShowLivre.Rows.Clear();
        }

        private void DataShowArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();

            if (DataShowArticle.Columns[e.ColumnIndex].Name == "ASupprimer")
            {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShowArticle.Rows[e.RowIndex].Cells[1].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bd.DeleteArtical(Int32.Parse(DataShowArticle.Rows[e.RowIndex].Cells[0].Value.ToString())))
                        MessageBox.Show("bien supprimer");
                    else
                        MessageBox.Show("error");
                }
            }
            if (DataShowArticle.Columns[e.ColumnIndex].Name == "AModifier")
            {

                int id = Int32.Parse(DataShowArticle.Rows[e.RowIndex].Cells[0].Value.ToString());
                Article c = bd.getArticle(id);
                EditArticle l = new EditArticle(c);
                l.Show();
                MessageBox.Show("Modifier");

            }
            if (DataShowArticle.Columns[e.ColumnIndex].Name == "VoirPDF")
            {
                int id = Int32.Parse(DataShowArticle.Rows[e.RowIndex].Cells[0].Value.ToString());
                //EditCharcheur l = new EditCharcheur(username, type, this);
                //l.Show();
                MessageBox.Show("VoirPDF");

            }
            ClearData();
            DataInTableDataShowArticle();
        }
        public void DataInTableDataShowArticle()
        {
            DataBases bd = new DataBases();

            List<Article> articles  = bd.getArticles(BienvenueForm.username);
            foreach (Article article in articles)
                this.DataShowArticle.Rows.Add(article.id, article.nom, article.ajoutDate, article.desc, article.motcle, article.pages, article.langue);
          


        }

        private void DataShowLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();

            if (DataShowLivre.Columns[e.ColumnIndex].Name == "LSupprimer")
            {
                if (MessageBox.Show("Voulez-vous vraiment le supprimer\n" + DataShowLivre.Rows[e.RowIndex].Cells[1].Value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bd.DeleteLivre(Int32.Parse(DataShowLivre.Rows[e.RowIndex].Cells[0].Value.ToString())))
                        MessageBox.Show("bien supprimer");
                    else
                        MessageBox.Show("error");
                }
            }
            if (DataShowLivre.Columns[e.ColumnIndex].Name == "LModifier")
            {

                int id = Int32.Parse(DataShowLivre.Rows[e.RowIndex].Cells[0].Value.ToString());
                Livre c = bd.getLivre(id);
                EditLivre l = new EditLivre(c);
                l.Show();
                MessageBox.Show("Modifier");

            }
            if (DataShowLivre.Columns[e.ColumnIndex].Name == "LVoirPDF")
            {
                int id = Int32.Parse(DataShowLivre.Rows[e.RowIndex].Cells[0].Value.ToString());
                //EditCharcheur l = new EditCharcheur(username, type, this);
                //l.Show();
                MessageBox.Show("VoirPDF");

            }
            ClearData();
            DataInTableDataShowLivre();

        }
        public void DataInTableDataShowLivre()
        {
            DataBases bd = new DataBases();

            List<Livre> livres = bd.getLivres(BienvenueForm.username);
            foreach (Livre livre in livres)
                this.DataShowLivre.Rows.Add(livre.id, livre.nom, livre.ajoutDate, livre.desc, livre.motcle, livre.pages, livre.version,livre.langue);



        }
    }
}
