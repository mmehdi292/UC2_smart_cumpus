
namespace Gestion_des_laboratoires_de_recherche
{
    partial class BienvenueForm
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
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.ConsulterEquipes = new Guna.UI2.WinForms.Guna2Button();
            this.AjouterEquipe = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.consulterLabo = new Guna.UI2.WinForms.Guna2Button();
            this.ajouterLabo = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consulterLabo1 = new Gestion_des_laboratoires_de_recherche.Usercontorls.ConsulterLabo();
            this.ajouterEquipe1 = new Gestion_des_laboratoires_de_recherche.Usercontorls.AjouterEquipe();
            this.ajouterLabo1 = new Gestion_des_laboratoires_de_recherche.AjouterLabo();
            this.consluterEquipes1 = new Gestion_des_laboratoires_de_recherche.Usercontorls.consluterEquipes();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.ConsulterEquipes);
            this.panel1.Controls.Add(this.AjouterEquipe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.consulterLabo);
            this.panel1.Controls.Add(this.ajouterLabo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 569);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.AutoRoundedCorners = true;
            this.logout.BorderRadius = 22;
            this.logout.CheckedState.Parent = this.logout;
            this.logout.CustomImages.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.logout;
            this.logout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logout.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.logout.CustomImages.Parent = this.logout;
            this.logout.FillColor = System.Drawing.Color.White;
            this.logout.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.logout.HoverState.Parent = this.logout;
            this.logout.Location = new System.Drawing.Point(38, 506);
            this.logout.Name = "logout";
            this.logout.ShadowDecoration.Parent = this.logout;
            this.logout.Size = new System.Drawing.Size(215, 47);
            this.logout.TabIndex = 8;
            this.logout.Text = "Deconnecter";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ConsulterEquipes
            // 
            this.ConsulterEquipes.AutoRoundedCorners = true;
            this.ConsulterEquipes.BorderRadius = 22;
            this.ConsulterEquipes.CheckedState.Parent = this.ConsulterEquipes;
            this.ConsulterEquipes.CustomImages.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.users_group;
            this.ConsulterEquipes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ConsulterEquipes.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.ConsulterEquipes.CustomImages.Parent = this.ConsulterEquipes;
            this.ConsulterEquipes.FillColor = System.Drawing.Color.White;
            this.ConsulterEquipes.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsulterEquipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ConsulterEquipes.HoverState.Parent = this.ConsulterEquipes;
            this.ConsulterEquipes.Location = new System.Drawing.Point(38, 347);
            this.ConsulterEquipes.Name = "ConsulterEquipes";
            this.ConsulterEquipes.ShadowDecoration.Parent = this.ConsulterEquipes;
            this.ConsulterEquipes.Size = new System.Drawing.Size(215, 47);
            this.ConsulterEquipes.TabIndex = 7;
            this.ConsulterEquipes.Text = "Consulter equipes";
            this.ConsulterEquipes.Click += new System.EventHandler(this.ConsulterEquipes_Click);
            // 
            // AjouterEquipe
            // 
            this.AjouterEquipe.AutoRoundedCorners = true;
            this.AjouterEquipe.BorderRadius = 22;
            this.AjouterEquipe.CheckedState.Parent = this.AjouterEquipe;
            this.AjouterEquipe.CustomImages.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.group_of_people;
            this.AjouterEquipe.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AjouterEquipe.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.AjouterEquipe.CustomImages.Parent = this.AjouterEquipe;
            this.AjouterEquipe.FillColor = System.Drawing.Color.White;
            this.AjouterEquipe.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterEquipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.AjouterEquipe.HoverState.Parent = this.AjouterEquipe;
            this.AjouterEquipe.Location = new System.Drawing.Point(38, 294);
            this.AjouterEquipe.Name = "AjouterEquipe";
            this.AjouterEquipe.ShadowDecoration.Parent = this.AjouterEquipe;
            this.AjouterEquipe.Size = new System.Drawing.Size(215, 47);
            this.AjouterEquipe.TabIndex = 6;
            this.AjouterEquipe.Text = "Ajouter equipe";
            this.AjouterEquipe.Click += new System.EventHandler(this.AjouterEquipe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(57, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gestion des equipes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consulterLabo
            // 
            this.consulterLabo.AutoRoundedCorners = true;
            this.consulterLabo.BorderRadius = 22;
            this.consulterLabo.CheckedState.Parent = this.consulterLabo;
            this.consulterLabo.CustomImages.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.microscope;
            this.consulterLabo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.consulterLabo.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.consulterLabo.CustomImages.Parent = this.consulterLabo;
            this.consulterLabo.FillColor = System.Drawing.Color.White;
            this.consulterLabo.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulterLabo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.consulterLabo.HoverState.Parent = this.consulterLabo;
            this.consulterLabo.Location = new System.Drawing.Point(38, 201);
            this.consulterLabo.Name = "consulterLabo";
            this.consulterLabo.ShadowDecoration.Parent = this.consulterLabo;
            this.consulterLabo.Size = new System.Drawing.Size(215, 47);
            this.consulterLabo.TabIndex = 4;
            this.consulterLabo.Text = "Consulter laboratoires";
            this.consulterLabo.Click += new System.EventHandler(this.consulterLabo_Click);
            // 
            // ajouterLabo
            // 
            this.ajouterLabo.AutoRoundedCorners = true;
            this.ajouterLabo.BorderRadius = 22;
            this.ajouterLabo.CheckedState.Parent = this.ajouterLabo;
            this.ajouterLabo.CustomImages.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.laboratory;
            this.ajouterLabo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ajouterLabo.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.ajouterLabo.CustomImages.Parent = this.ajouterLabo;
            this.ajouterLabo.FillColor = System.Drawing.Color.White;
            this.ajouterLabo.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterLabo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterLabo.HoverState.Parent = this.ajouterLabo;
            this.ajouterLabo.Location = new System.Drawing.Point(38, 148);
            this.ajouterLabo.Name = "ajouterLabo";
            this.ajouterLabo.ShadowDecoration.Parent = this.ajouterLabo;
            this.ajouterLabo.Size = new System.Drawing.Size(215, 47);
            this.ajouterLabo.TabIndex = 3;
            this.ajouterLabo.Text = "Ajouter laboratoire";
            this.ajouterLabo.Click += new System.EventHandler(this.ajouterLabo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion des laboratoires";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Advent Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Systeme de \nGestion des laboratoires";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consulterLabo1
            // 
            this.consulterLabo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consulterLabo1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulterLabo1.Location = new System.Drawing.Point(286, 0);
            this.consulterLabo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consulterLabo1.Name = "consulterLabo1";
            this.consulterLabo1.Size = new System.Drawing.Size(770, 569);
            this.consulterLabo1.TabIndex = 3;
            // 
            // ajouterEquipe1
            // 
            this.ajouterEquipe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterEquipe1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterEquipe1.Location = new System.Drawing.Point(286, 0);
            this.ajouterEquipe1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ajouterEquipe1.Name = "ajouterEquipe1";
            this.ajouterEquipe1.Size = new System.Drawing.Size(770, 569);
            this.ajouterEquipe1.TabIndex = 2;
            // 
            // ajouterLabo1
            // 
            this.ajouterLabo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterLabo1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterLabo1.Location = new System.Drawing.Point(286, 0);
            this.ajouterLabo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ajouterLabo1.Name = "ajouterLabo1";
            this.ajouterLabo1.Size = new System.Drawing.Size(770, 569);
            this.ajouterLabo1.TabIndex = 1;
            // 
            // consluterEquipes1
            // 
            this.consluterEquipes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consluterEquipes1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consluterEquipes1.Location = new System.Drawing.Point(286, 0);
            this.consluterEquipes1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consluterEquipes1.Name = "consluterEquipes1";
            this.consluterEquipes1.Size = new System.Drawing.Size(770, 569);
            this.consluterEquipes1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.flask;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BienvenueForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1056, 569);
            this.Controls.Add(this.consluterEquipes1);
            this.Controls.Add(this.consulterLabo1);
            this.Controls.Add(this.ajouterEquipe1);
            this.Controls.Add(this.ajouterLabo1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BienvenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des laboratoires de recherche";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ajouterLabo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ConsulterEquipes;
        private Guna.UI2.WinForms.Guna2Button AjouterEquipe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button consulterLabo;
        private Guna.UI2.WinForms.Guna2Button logout;
        private AjouterLabo ajouterLabo1;
        private Usercontorls.AjouterEquipe ajouterEquipe1;
        private Usercontorls.ConsulterLabo consulterLabo1;
        private Usercontorls.consluterEquipes consluterEquipes1;
    }
}