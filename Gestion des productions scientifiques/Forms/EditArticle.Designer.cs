
namespace Gestion_des_productions_scientifiques.Forms
{
    partial class EditArticle
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
            this.Description = new System.Windows.Forms.RichTextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.motCle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.addFile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.langue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pages = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ajouterArticleButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).BeginInit();
            this.SuspendLayout();
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
            this.Description.Location = new System.Drawing.Point(88, 191);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(625, 101);
            this.Description.TabIndex = 113;
            this.Description.Text = "";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 298);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel1.TabIndex = 126;
            this.guna2HtmlLabel1.Text = "Mot Cle";
            // 
            // motCle
            // 
            this.motCle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motCle.AutoRoundedCorners = true;
            this.motCle.BorderRadius = 17;
            this.motCle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.motCle.DefaultText = "";
            this.motCle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.motCle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.motCle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.motCle.DisabledState.Parent = this.motCle;
            this.motCle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.motCle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.motCle.FocusedState.Parent = this.motCle;
            this.motCle.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.motCle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.motCle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.motCle.HoverState.Parent = this.motCle;
            this.motCle.Location = new System.Drawing.Point(88, 329);
            this.motCle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motCle.Name = "motCle";
            this.motCle.PasswordChar = '\0';
            this.motCle.PlaceholderText = "";
            this.motCle.SelectedText = "";
            this.motCle.ShadowDecoration.Parent = this.motCle;
            this.motCle.Size = new System.Drawing.Size(625, 36);
            this.motCle.TabIndex = 114;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(88, 160);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(86, 24);
            this.guna2HtmlLabel4.TabIndex = 125;
            this.guna2HtmlLabel4.Text = "Description";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(88, 86);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(231, 24);
            this.guna2HtmlLabel7.TabIndex = 124;
            this.guna2HtmlLabel7.Text = "Nom de Production scientifique";
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
            this.nom.Location = new System.Drawing.Point(88, 117);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(625, 36);
            this.nom.TabIndex = 112;
            // 
            // addFile
            // 
            this.addFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addFile.AutoRoundedCorners = true;
            this.addFile.BorderColor = System.Drawing.Color.DimGray;
            this.addFile.BorderRadius = 17;
            this.addFile.CheckedState.Parent = this.addFile;
            this.addFile.CustomImages.Parent = this.addFile;
            this.addFile.FillColor = System.Drawing.Color.White;
            this.addFile.Font = new System.Drawing.Font("Advent Pro", 9.749999F, System.Drawing.FontStyle.Bold);
            this.addFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.addFile.HoverState.Parent = this.addFile;
            this.addFile.Location = new System.Drawing.Point(577, 488);
            this.addFile.Name = "addFile";
            this.addFile.ShadowDecoration.Parent = this.addFile;
            this.addFile.Size = new System.Drawing.Size(136, 36);
            this.addFile.TabIndex = 123;
            this.addFile.Text = "Ajouter fichiers";
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(88, 539);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 24);
            this.guna2HtmlLabel3.TabIndex = 122;
            this.guna2HtmlLabel3.Text = "Langue";
            // 
            // langue
            // 
            this.langue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langue.AutoRoundedCorners = true;
            this.langue.BorderRadius = 17;
            this.langue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.langue.DefaultText = "";
            this.langue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.langue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.langue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.langue.DisabledState.Parent = this.langue;
            this.langue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.langue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.langue.FocusedState.Parent = this.langue;
            this.langue.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.langue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.langue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.langue.HoverState.Parent = this.langue;
            this.langue.Location = new System.Drawing.Point(88, 570);
            this.langue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.langue.Name = "langue";
            this.langue.PasswordChar = '\0';
            this.langue.PlaceholderText = "";
            this.langue.SelectedText = "";
            this.langue.ShadowDecoration.Parent = this.langue;
            this.langue.Size = new System.Drawing.Size(625, 36);
            this.langue.TabIndex = 116;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(88, 372);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(47, 24);
            this.guna2HtmlLabel2.TabIndex = 121;
            this.guna2HtmlLabel2.Text = "Pages";
            // 
            // pages
            // 
            this.pages.AutoRoundedCorners = true;
            this.pages.BackColor = System.Drawing.Color.Transparent;
            this.pages.BorderRadius = 19;
            this.pages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pages.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pages.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pages.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pages.DisabledState.Parent = this.pages;
            this.pages.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.pages.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pages.FocusedState.Parent = this.pages;
            this.pages.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.pages.Location = new System.Drawing.Point(88, 402);
            this.pages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pages.Name = "pages";
            this.pages.ShadowDecoration.Parent = this.pages;
            this.pages.Size = new System.Drawing.Size(625, 40);
            this.pages.TabIndex = 115;
            this.pages.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(88, 457);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel6.TabIndex = 120;
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
            this.fileName.Location = new System.Drawing.Point(88, 488);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.PlaceholderText = "";
            this.fileName.ReadOnly = true;
            this.fileName.SelectedText = "";
            this.fileName.ShadowDecoration.Parent = this.fileName;
            this.fileName.Size = new System.Drawing.Size(482, 36);
            this.fileName.TabIndex = 119;
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
            this.ajouterArticleButton.Location = new System.Drawing.Point(298, 629);
            this.ajouterArticleButton.Name = "ajouterArticleButton";
            this.ajouterArticleButton.ShadowDecoration.Parent = this.ajouterArticleButton;
            this.ajouterArticleButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterArticleButton.TabIndex = 118;
            this.ajouterArticleButton.Text = "Modifier article";
            this.ajouterArticleButton.Click += new System.EventHandler(this.ajouterArticleButton_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Advent Pro SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(286, 25);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(214, 44);
            this.guna2HtmlLabel5.TabIndex = 117;
            this.guna2HtmlLabel5.Text = "Modifier Article";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.motCle);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.langue);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.ajouterArticleButton);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Name = "EditArticle";
            this.Text = "EditArticle";
            ((System.ComponentModel.ISupportInitialize)(this.pages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Description;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox motCle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2Button addFile;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox langue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown pages;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox fileName;
        private Guna.UI2.WinForms.Guna2Button ajouterArticleButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}