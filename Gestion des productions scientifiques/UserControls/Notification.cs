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
    public partial class Notification : UserControl
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void DataShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBases bd = new DataBases();

            if (DataShow.Columns[e.ColumnIndex].Name == "Afficher")
            {
                int id = Int32.Parse(DataShow.Rows[e.RowIndex].Cells[2].Value.ToString());

                Conference f = bd.getConference(id);
                NotificationViewer p = new NotificationViewer(f);
                p.Show();
            }
            ClearData();
            DataInTableDataShow();

        }
        public void DataInTableDataShow()
        {
            DataBases bd = new DataBases();

            List<ClassesModele.Notification> notifications = bd.GetNotifications();
            foreach (ClassesModele.Notification notification in notifications)
            {
                this.DataShow.Rows.Add(notification.id, notification.username,notification.id_prod);
            }
        }
        public void ClearData()
        {
            this.DataShow.Rows.Clear();
        }

    }
}
