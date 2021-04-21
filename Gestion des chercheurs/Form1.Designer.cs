
namespace Gestion_des_chercheurs
{
    partial class Form1
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.affecter = new Guna.UI2.WinForms.Guna2Button();
            this.consulterEq = new Guna.UI2.WinForms.Guna2Button();
            this.ajouterEq = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.affectCher1 = new Gestion_des_chercheurs.UserForms.AffectCher();
            this.consulterCher1 = new Gestion_des_chercheurs.UserForms.ConsulterCher();
            this.addCher1 = new Gestion_des_chercheurs.UserForms.AddCher();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.logout);
            this.guna2Panel1.Controls.Add(this.affecter);
            this.guna2Panel1.Controls.Add(this.consulterEq);
            this.guna2Panel1.Controls.Add(this.ajouterEq);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(303, 660);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_des_chercheurs.Properties.Resources.chemistry;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
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
            this.logout.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.logout.HoverState.Parent = this.logout;
            this.logout.Image = global::Gestion_des_chercheurs.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(51, 582);
            this.logout.Name = "logout";
            this.logout.ShadowDecoration.Parent = this.logout;
            this.logout.Size = new System.Drawing.Size(215, 47);
            this.logout.TabIndex = 16;
            this.logout.Text = "Deconnecter";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // affecter
            // 
            this.affecter.AutoRoundedCorners = true;
            this.affecter.BorderRadius = 20;
            this.affecter.CheckedState.Parent = this.affecter;
            this.affecter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.affecter.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.affecter.CustomImages.Parent = this.affecter;
            this.affecter.FillColor = System.Drawing.Color.White;
            this.affecter.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affecter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.affecter.HoverState.Parent = this.affecter;
            this.affecter.Image = global::Gestion_des_chercheurs.Properties.Resources.transfer;
            this.affecter.Location = new System.Drawing.Point(7, 339);
            this.affecter.Name = "affecter";
            this.affecter.ShadowDecoration.Parent = this.affecter;
            this.affecter.Size = new System.Drawing.Size(281, 43);
            this.affecter.TabIndex = 14;
            this.affecter.Text = "Affercter les chercheurs aux equipes";
            this.affecter.Click += new System.EventHandler(this.affecter_Click);
            // 
            // consulterEq
            // 
            this.consulterEq.AutoRoundedCorners = true;
            this.consulterEq.BorderRadius = 22;
            this.consulterEq.CheckedState.Parent = this.consulterEq;
            this.consulterEq.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.consulterEq.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.consulterEq.CustomImages.Parent = this.consulterEq;
            this.consulterEq.FillColor = System.Drawing.Color.White;
            this.consulterEq.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulterEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.consulterEq.HoverState.Parent = this.consulterEq;
            this.consulterEq.Image = global::Gestion_des_chercheurs.Properties.Resources.users_group;
            this.consulterEq.Location = new System.Drawing.Point(47, 226);
            this.consulterEq.Name = "consulterEq";
            this.consulterEq.ShadowDecoration.Parent = this.consulterEq;
            this.consulterEq.Size = new System.Drawing.Size(215, 47);
            this.consulterEq.TabIndex = 12;
            this.consulterEq.Text = "Consulter chercheurs";
            this.consulterEq.Click += new System.EventHandler(this.consulterEq_Click);
            // 
            // ajouterEq
            // 
            this.ajouterEq.AutoRoundedCorners = true;
            this.ajouterEq.BorderRadius = 22;
            this.ajouterEq.CheckedState.Parent = this.ajouterEq;
            this.ajouterEq.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ajouterEq.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.ajouterEq.CustomImages.Parent = this.ajouterEq;
            this.ajouterEq.FillColor = System.Drawing.Color.White;
            this.ajouterEq.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.ajouterEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterEq.HoverState.Parent = this.ajouterEq;
            this.ajouterEq.Image = global::Gestion_des_chercheurs.Properties.Resources.plus;
            this.ajouterEq.Location = new System.Drawing.Point(47, 152);
            this.ajouterEq.Name = "ajouterEq";
            this.ajouterEq.ShadowDecoration.Parent = this.ajouterEq;
            this.ajouterEq.Size = new System.Drawing.Size(215, 47);
            this.ajouterEq.TabIndex = 11;
            this.ajouterEq.Text = "Ajouter chercheur";
            this.ajouterEq.Click += new System.EventHandler(this.ajouterEq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestion des chercheurs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Advent Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Systeme de \nGestion des Chercheurs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // affectCher1
            // 
            this.affectCher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.affectCher1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affectCher1.Location = new System.Drawing.Point(303, 0);
            this.affectCher1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.affectCher1.Name = "affectCher1";
            this.affectCher1.Size = new System.Drawing.Size(772, 660);
            this.affectCher1.TabIndex = 3;
            // 
            // consulterCher1
            // 
            this.consulterCher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consulterCher1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulterCher1.Location = new System.Drawing.Point(303, 0);
            this.consulterCher1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consulterCher1.Name = "consulterCher1";
            this.consulterCher1.Size = new System.Drawing.Size(772, 660);
            this.consulterCher1.TabIndex = 2;
            // 
            // addCher1
            // 
            this.addCher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCher1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCher1.Location = new System.Drawing.Point(303, 0);
            this.addCher1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCher1.Name = "addCher1";
            this.addCher1.Size = new System.Drawing.Size(772, 660);
            this.addCher1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 660);
            this.Controls.Add(this.affectCher1);
            this.Controls.Add(this.consulterCher1);
            this.Controls.Add(this.addCher1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button logout;
        private Guna.UI2.WinForms.Guna2Button affecter;
        private Guna.UI2.WinForms.Guna2Button consulterEq;
        private Guna.UI2.WinForms.Guna2Button ajouterEq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserForms.AddCher addCher1;
        private UserForms.ConsulterCher consulterCher1;
        private UserForms.AffectCher affectCher1;
    }
}

