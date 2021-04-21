
namespace Gestion_des_productions_scientifiques.Forms
{
    partial class AddForm
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
            this.ajouterArticleButton = new Guna.UI2.WinForms.Guna2Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ajouterArticleButton
            // 
            this.ajouterArticleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterArticleButton.AutoRoundedCorners = true;
            this.ajouterArticleButton.BorderRadius = 25;
            this.ajouterArticleButton.CheckedState.Parent = this.ajouterArticleButton;
            this.ajouterArticleButton.CustomImages.Parent = this.ajouterArticleButton;
            this.ajouterArticleButton.FillColor = System.Drawing.Color.White;
            this.ajouterArticleButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.ajouterArticleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterArticleButton.HoverState.Parent = this.ajouterArticleButton;
            this.ajouterArticleButton.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.ADDprod1;
            this.ajouterArticleButton.Location = new System.Drawing.Point(295, 410);
            this.ajouterArticleButton.Name = "ajouterArticleButton";
            this.ajouterArticleButton.ShadowDecoration.Parent = this.ajouterArticleButton;
            this.ajouterArticleButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterArticleButton.TabIndex = 136;
            this.ajouterArticleButton.Text = "Ajouter post";
            this.ajouterArticleButton.Click += new System.EventHandler(this.ajouterArticleButton_Click);
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.Description.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Description.Location = new System.Drawing.Point(88, 189);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(625, 101);
            this.Description.TabIndex = 129;
            this.Description.Text = "";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(88, 143);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(86, 24);
            this.guna2HtmlLabel4.TabIndex = 135;
            this.guna2HtmlLabel4.Text = "Description";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(88, 69);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(96, 24);
            this.guna2HtmlLabel7.TabIndex = 134;
            this.guna2HtmlLabel7.Text = "Nom de post";
            // 
            // nom
            // 
            this.nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom.AutoRoundedCorners = true;
            this.nom.BorderRadius = 17;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.Location = new System.Drawing.Point(88, 100);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(625, 36);
            this.nom.TabIndex = 128;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Advent Pro", 9.749999F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(577, 337);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(136, 36);
            this.guna2Button1.TabIndex = 133;
            this.guna2Button1.Text = "Ajouter fichiers";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 306);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(184, 24);
            this.guna2HtmlLabel1.TabIndex = 132;
            this.guna2HtmlLabel1.Text = "Files ou Photos ou Video";
            // 
            // FileName
            // 
            this.FileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileName.AutoRoundedCorners = true;
            this.FileName.BorderRadius = 17;
            this.FileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileName.DefaultText = "";
            this.FileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileName.DisabledState.Parent = this.FileName;
            this.FileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileName.FocusedState.Parent = this.FileName;
            this.FileName.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.FileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.FileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileName.HoverState.Parent = this.FileName;
            this.FileName.Location = new System.Drawing.Point(88, 337);
            this.FileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileName.Name = "FileName";
            this.FileName.PasswordChar = '\0';
            this.FileName.PlaceholderText = "";
            this.FileName.ReadOnly = true;
            this.FileName.SelectedText = "";
            this.FileName.ShadowDecoration.Parent = this.FileName;
            this.FileName.Size = new System.Drawing.Size(482, 36);
            this.FileName.TabIndex = 131;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Advent Pro SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(278, 19);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(167, 44);
            this.guna2HtmlLabel5.TabIndex = 130;
            this.guna2HtmlLabel5.Text = "Ajouter post";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.ajouterArticleButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ajouterArticleButton;
        private System.Windows.Forms.RichTextBox Description;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox FileName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}