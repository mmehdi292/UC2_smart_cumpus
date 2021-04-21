
namespace Gestion_des_projet
{
    partial class BienvenueFormChefProjet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.consulterpro = new Guna.UI2.WinForms.Guna2Button();
            this.ajouterprojet = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addProject1 = new Gestion_des_projets_scientifiques.UserControls.addProject();
            this.consulterProjects1 = new Gestion_des_projets_scientifiques.UserControls.ConsulterProjects();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout.AutoRoundedCorners = true;
            this.logout.BorderRadius = 22;
            this.logout.CheckedState.Parent = this.logout;
            this.logout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logout.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.logout.CustomImages.Parent = this.logout;
            this.logout.FillColor = System.Drawing.Color.White;
            this.logout.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.logout.HoverState.Parent = this.logout;
            this.logout.Image = global::Gestion_des_projet.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(47, 502);
            this.logout.Name = "logout";
            this.logout.ShadowDecoration.Parent = this.logout;
            this.logout.Size = new System.Drawing.Size(215, 47);
            this.logout.TabIndex = 23;
            this.logout.Text = "Deconnecter";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // consulterpro
            // 
            this.consulterpro.AutoRoundedCorners = true;
            this.consulterpro.BorderRadius = 22;
            this.consulterpro.CheckedState.Parent = this.consulterpro;
            this.consulterpro.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.consulterpro.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.consulterpro.CustomImages.Parent = this.consulterpro;
            this.consulterpro.FillColor = System.Drawing.Color.White;
            this.consulterpro.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.consulterpro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.consulterpro.HoverState.Parent = this.consulterpro;
            this.consulterpro.Image = global::Gestion_des_projet.Properties.Resources.project_management;
            this.consulterpro.Location = new System.Drawing.Point(37, 197);
            this.consulterpro.Name = "consulterpro";
            this.consulterpro.ShadowDecoration.Parent = this.consulterpro;
            this.consulterpro.Size = new System.Drawing.Size(244, 47);
            this.consulterpro.TabIndex = 21;
            this.consulterpro.Text = "Consulter Projets / affectation";
            // 
            // ajouterprojet
            // 
            this.ajouterprojet.AutoRoundedCorners = true;
            this.ajouterprojet.BorderRadius = 22;
            this.ajouterprojet.CheckedState.Parent = this.ajouterprojet;
            this.ajouterprojet.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ajouterprojet.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.ajouterprojet.CustomImages.Parent = this.ajouterprojet;
            this.ajouterprojet.FillColor = System.Drawing.Color.White;
            this.ajouterprojet.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.ajouterprojet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterprojet.HoverState.Parent = this.ajouterprojet;
            this.ajouterprojet.Image = global::Gestion_des_projet.Properties.Resources.search;
            this.ajouterprojet.Location = new System.Drawing.Point(47, 132);
            this.ajouterprojet.Name = "ajouterprojet";
            this.ajouterprojet.ShadowDecoration.Parent = this.ajouterprojet;
            this.ajouterprojet.Size = new System.Drawing.Size(215, 47);
            this.ajouterprojet.TabIndex = 20;
            this.ajouterprojet.Text = "Ajouter projet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.consulterpro);
            this.panel1.Controls.Add(this.ajouterprojet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 567);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_des_projet.Properties.Resources.investigation;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gestion des projets de rechercher";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Systeme de \nGestion des projets de rechercher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProject1
            // 
            this.addProject1.Location = new System.Drawing.Point(322, 0);
            this.addProject1.Name = "addProject1";
            this.addProject1.Size = new System.Drawing.Size(656, 567);
            this.addProject1.TabIndex = 2;
            // 
            // consulterProjects1
            // 
            this.consulterProjects1.Location = new System.Drawing.Point(322, 0);
            this.consulterProjects1.Name = "consulterProjects1";
            this.consulterProjects1.Size = new System.Drawing.Size(724, 567);
            this.consulterProjects1.TabIndex = 3;
            // 
            // BienvenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.consulterProjects1);
            this.Controls.Add(this.addProject1);
            this.Controls.Add(this.panel1);
            this.Name = "BienvenueForm";
            this.Text = "BienvenueForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logout;
        private Guna.UI2.WinForms.Guna2Button consulterpro;
        private Guna.UI2.WinForms.Guna2Button ajouterprojet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gestion_des_projets_scientifiques.UserControls.addProject addProject1;
        private Gestion_des_projets_scientifiques.UserControls.ConsulterProjects consulterProjects1;
    }
}