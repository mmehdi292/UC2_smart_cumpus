
namespace Gestion_des_projet.Froms
{
    partial class EditProjet
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PRFUCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chef = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ajouterProjetButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 146;
            this.label1.Text = "Modifier projet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(32, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.labelImg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(209, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 145;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PRFUCheckBox
            // 
            this.PRFUCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PRFUCheckBox.AutoSize = true;
            this.PRFUCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.PRFUCheckBox.CheckedState.BorderRadius = 0;
            this.PRFUCheckBox.CheckedState.BorderThickness = 0;
            this.PRFUCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PRFUCheckBox.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.PRFUCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.PRFUCheckBox.Location = new System.Drawing.Point(365, 211);
            this.PRFUCheckBox.Name = "PRFUCheckBox";
            this.PRFUCheckBox.Size = new System.Drawing.Size(70, 26);
            this.PRFUCheckBox.TabIndex = 157;
            this.PRFUCheckBox.Text = "PRFU";
            this.PRFUCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.PRFUCheckBox.UncheckedState.BorderRadius = 5;
            this.PRFUCheckBox.UncheckedState.BorderThickness = 0;
            this.PRFUCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            // 
            // chef
            // 
            this.chef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chef.AutoRoundedCorners = true;
            this.chef.BackColor = System.Drawing.Color.Transparent;
            this.chef.BorderRadius = 17;
            this.chef.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chef.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chef.FocusedState.Parent = this.chef;
            this.chef.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.chef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.chef.HoverState.Parent = this.chef;
            this.chef.ItemHeight = 30;
            this.chef.ItemsAppearance.Parent = this.chef;
            this.chef.Location = new System.Drawing.Point(59, 201);
            this.chef.Name = "chef";
            this.chef.ShadowDecoration.Parent = this.chef;
            this.chef.Size = new System.Drawing.Size(300, 36);
            this.chef.TabIndex = 155;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(65, 171);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(82, 24);
            this.guna2HtmlLabel11.TabIndex = 156;
            this.guna2HtmlLabel11.Text = "Chef Projet";
            // 
            // ajouterProjetButton
            // 
            this.ajouterProjetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterProjetButton.AutoRoundedCorners = true;
            this.ajouterProjetButton.BorderRadius = 25;
            this.ajouterProjetButton.CheckedState.Parent = this.ajouterProjetButton;
            this.ajouterProjetButton.CustomImages.Parent = this.ajouterProjetButton;
            this.ajouterProjetButton.FillColor = System.Drawing.Color.White;
            this.ajouterProjetButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.ajouterProjetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterProjetButton.HoverState.Parent = this.ajouterProjetButton;
            this.ajouterProjetButton.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.edit;
            this.ajouterProjetButton.Location = new System.Drawing.Point(161, 262);
            this.ajouterProjetButton.Name = "ajouterProjetButton";
            this.ajouterProjetButton.ShadowDecoration.Parent = this.ajouterProjetButton;
            this.ajouterProjetButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterProjetButton.TabIndex = 154;
            this.ajouterProjetButton.Text = "Modifer Projet";
            this.ajouterProjetButton.Click += new System.EventHandler(this.ajouterProjetButton_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(59, 99);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(38, 24);
            this.guna2HtmlLabel4.TabIndex = 153;
            this.guna2HtmlLabel4.Text = "Nom";
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
            this.nom.Location = new System.Drawing.Point(59, 130);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(376, 36);
            this.nom.TabIndex = 152;
            // 
            // EditProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.PRFUCheckBox);
            this.Controls.Add(this.chef);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.ajouterProjetButton);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "EditProjet";
            this.Text = "EditProjet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox PRFUCheckBox;
        public Guna.UI2.WinForms.Guna2ComboBox chef;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        public Guna.UI2.WinForms.Guna2Button ajouterProjetButton;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        public Guna.UI2.WinForms.Guna2TextBox nom;
    }
}