
namespace Gestion_des_projets_scientifiques
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.profile = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.depprojet = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deposerProjet1 = new Gestion_des_projets_scientifiques.UserControls.DeposerProjet();
            this.profile1 = new Gestion_des_productions_scientifiques.UserControls.Profile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.depprojet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 651);
            this.panel1.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.AutoRoundedCorners = true;
            this.profile.BorderRadius = 22;
            this.profile.CheckedState.Parent = this.profile;
            this.profile.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.profile.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.profile.CustomImages.Parent = this.profile;
            this.profile.FillColor = System.Drawing.Color.White;
            this.profile.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.profile.HoverState.Parent = this.profile;
            this.profile.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.user_1_;
            this.profile.Location = new System.Drawing.Point(47, 499);
            this.profile.Name = "profile";
            this.profile.ShadowDecoration.Parent = this.profile;
            this.profile.Size = new System.Drawing.Size(215, 47);
            this.profile.TabIndex = 26;
            this.profile.Text = "Profile";
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            this.logout.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(47, 586);
            this.logout.Name = "logout";
            this.logout.ShadowDecoration.Parent = this.logout;
            this.logout.Size = new System.Drawing.Size(215, 47);
            this.logout.TabIndex = 23;
            this.logout.Text = "Deconnecter";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // depprojet
            // 
            this.depprojet.AutoRoundedCorners = true;
            this.depprojet.BorderRadius = 22;
            this.depprojet.CheckedState.Parent = this.depprojet;
            this.depprojet.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.depprojet.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.depprojet.CustomImages.Parent = this.depprojet;
            this.depprojet.FillColor = System.Drawing.Color.White;
            this.depprojet.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.depprojet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.depprojet.HoverState.Parent = this.depprojet;
            this.depprojet.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.project_management;
            this.depprojet.Location = new System.Drawing.Point(47, 132);
            this.depprojet.Name = "depprojet";
            this.depprojet.ShadowDecoration.Parent = this.depprojet;
            this.depprojet.Size = new System.Drawing.Size(215, 47);
            this.depprojet.TabIndex = 20;
            this.depprojet.Text = "Deposer le projet";
            this.depprojet.Click += new System.EventHandler(this.depprojet_Click);
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
            // deposerProjet1
            // 
            this.deposerProjet1.Location = new System.Drawing.Point(321, 0);
            this.deposerProjet1.Name = "deposerProjet1";
            this.deposerProjet1.Size = new System.Drawing.Size(677, 654);
            this.deposerProjet1.TabIndex = 3;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(321, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(677, 654);
            this.profile1.TabIndex = 2;
            // 
            // BienvenueFormChefProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 651);
            this.Controls.Add(this.deposerProjet1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.panel1);
            this.Name = "BienvenueFormChefProjet";
            this.Text = "BienvenueFormChefProjet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button logout;
        private Guna.UI2.WinForms.Guna2Button depprojet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gestion_des_productions_scientifiques.UserControls.Profile profile1;
        public UserControls.DeposerProjet deposerProjet1;
    }
}