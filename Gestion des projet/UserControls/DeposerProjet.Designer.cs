
namespace Gestion_des_projets_scientifiques.UserControls
{
    partial class DeposerProjet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomProjet = new System.Windows.Forms.Label();
            this.addPdf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ajouterLivreButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeProjet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Advent Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(115, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Deposer projet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Gestion_des_projet.Properties.Resources.project_management;
            this.pictureBox1.Location = new System.Drawing.Point(49, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Gestion_des_projet.Properties.Resources.labelImg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(256, 71);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Advent Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(38, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Le nom de projet est:";
            // 
            // NomProjet
            // 
            this.NomProjet.AutoSize = true;
            this.NomProjet.BackColor = System.Drawing.Color.Transparent;
            this.NomProjet.Font = new System.Drawing.Font("Advent Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomProjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.NomProjet.Location = new System.Drawing.Point(224, 188);
            this.NomProjet.Name = "NomProjet";
            this.NomProjet.Size = new System.Drawing.Size(188, 22);
            this.NomProjet.TabIndex = 19;
            this.NomProjet.Text = "APLHA BETA GAMA TEST";
            // 
            // addPdf
            // 
            this.addPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPdf.AutoRoundedCorners = true;
            this.addPdf.BorderColor = System.Drawing.Color.DimGray;
            this.addPdf.BorderRadius = 17;
            this.addPdf.CheckedState.Parent = this.addPdf;
            this.addPdf.CustomImages.Parent = this.addPdf;
            this.addPdf.FillColor = System.Drawing.Color.White;
            this.addPdf.Font = new System.Drawing.Font("Advent Pro", 9.749999F, System.Drawing.FontStyle.Bold);
            this.addPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.addPdf.HoverState.Parent = this.addPdf;
            this.addPdf.Location = new System.Drawing.Point(531, 314);
            this.addPdf.Name = "addPdf";
            this.addPdf.ShadowDecoration.Parent = this.addPdf;
            this.addPdf.Size = new System.Drawing.Size(136, 36);
            this.addPdf.TabIndex = 107;
            this.addPdf.Text = "Ajouter fichiers";
            this.addPdf.Click += new System.EventHandler(this.addPdf_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(42, 283);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel6.TabIndex = 106;
            this.guna2HtmlLabel6.Text = "Fichers";
            // 
            // fileName
            // 
            this.fileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileName.AutoRoundedCorners = true;
            this.fileName.BorderRadius = 17;
            this.fileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileName.DefaultText = "";
            this.fileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileName.DisabledState.Parent = this.fileName;
            this.fileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileName.FocusedState.Parent = this.fileName;
            this.fileName.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.fileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.fileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileName.HoverState.Parent = this.fileName;
            this.fileName.Location = new System.Drawing.Point(42, 314);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.PlaceholderText = "";
            this.fileName.SelectedText = "";
            this.fileName.ShadowDecoration.Parent = this.fileName;
            this.fileName.Size = new System.Drawing.Size(482, 36);
            this.fileName.TabIndex = 105;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ajouterLivreButton
            // 
            this.ajouterLivreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterLivreButton.AutoRoundedCorners = true;
            this.ajouterLivreButton.BorderRadius = 25;
            this.ajouterLivreButton.CheckedState.Parent = this.ajouterLivreButton;
            this.ajouterLivreButton.CustomImages.Parent = this.ajouterLivreButton;
            this.ajouterLivreButton.FillColor = System.Drawing.Color.White;
            this.ajouterLivreButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.ajouterLivreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterLivreButton.HoverState.Parent = this.ajouterLivreButton;
            this.ajouterLivreButton.Image = global::Gestion_des_projet.Properties.Resources.ADDprod;
            this.ajouterLivreButton.Location = new System.Drawing.Point(259, 522);
            this.ajouterLivreButton.Name = "ajouterLivreButton";
            this.ajouterLivreButton.ShadowDecoration.Parent = this.ajouterLivreButton;
            this.ajouterLivreButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterLivreButton.TabIndex = 108;
            this.ajouterLivreButton.Text = "Deposer le projet";
            this.ajouterLivreButton.Click += new System.EventHandler(this.ajouterLivreButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Advent Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(486, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 109;
            this.label4.Text = "Type de projet:";
            // 
            // TypeProjet
            // 
            this.TypeProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeProjet.AutoSize = true;
            this.TypeProjet.BackColor = System.Drawing.Color.Transparent;
            this.TypeProjet.Font = new System.Drawing.Font("Advent Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeProjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.TypeProjet.Location = new System.Drawing.Point(605, 45);
            this.TypeProjet.Name = "TypeProjet";
            this.TypeProjet.Size = new System.Drawing.Size(62, 22);
            this.TypeProjet.TabIndex = 110;
            this.TypeProjet.Text = "Simple";
            // 
            // DeposerProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TypeProjet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ajouterLivreButton);
            this.Controls.Add(this.addPdf);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.NomProjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "DeposerProjet";
            this.Size = new System.Drawing.Size(726, 591);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NomProjet;
        public Guna.UI2.WinForms.Guna2Button addPdf;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        public Guna.UI2.WinForms.Guna2TextBox fileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Guna.UI2.WinForms.Guna2Button ajouterLivreButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label TypeProjet;
    }
}
