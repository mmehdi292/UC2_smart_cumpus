
namespace Gestion_des_chercheurs.Forms
{
    partial class Affectation
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
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.equipes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.modifierButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chercheur = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(45, 85);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(110, 24);
            this.guna2HtmlLabel11.TabIndex = 34;
            this.guna2HtmlLabel11.Text = "Les chercheurs";
            // 
            // equipes
            // 
            this.equipes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equipes.AutoRoundedCorners = true;
            this.equipes.BackColor = System.Drawing.Color.Transparent;
            this.equipes.BorderRadius = 17;
            this.equipes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.equipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.equipes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.equipes.FocusedState.Parent = this.equipes;
            this.equipes.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.equipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.equipes.HoverState.Parent = this.equipes;
            this.equipes.ItemHeight = 30;
            this.equipes.ItemsAppearance.Parent = this.equipes;
            this.equipes.Location = new System.Drawing.Point(45, 187);
            this.equipes.Name = "equipes";
            this.equipes.ShadowDecoration.Parent = this.equipes;
            this.equipes.Size = new System.Drawing.Size(253, 36);
            this.equipes.TabIndex = 36;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(45, 157);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 24);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "Les equipes";
            // 
            // modifierButton
            // 
            this.modifierButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifierButton.AutoRoundedCorners = true;
            this.modifierButton.BorderRadius = 25;
            this.modifierButton.CheckedState.Parent = this.modifierButton;
            this.modifierButton.CustomImages.Parent = this.modifierButton;
            this.modifierButton.FillColor = System.Drawing.Color.White;
            this.modifierButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.modifierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.modifierButton.HoverState.Parent = this.modifierButton;
            this.modifierButton.Image = global::Gestion_des_chercheurs.Properties.Resources.plus;
            this.modifierButton.Location = new System.Drawing.Point(71, 255);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.ShadowDecoration.Parent = this.modifierButton;
            this.modifierButton.Size = new System.Drawing.Size(187, 52);
            this.modifierButton.TabIndex = 32;
            this.modifierButton.Text = "Affecter";
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Advent Pro", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(22, 28);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(301, 34);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "Ajouter/Modifier Affectation";
            // 
            // chercheur
            // 
            this.chercheur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chercheur.AutoRoundedCorners = true;
            this.chercheur.BorderRadius = 17;
            this.chercheur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chercheur.DefaultText = "";
            this.chercheur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chercheur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chercheur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chercheur.DisabledState.Parent = this.chercheur;
            this.chercheur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chercheur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chercheur.FocusedState.Parent = this.chercheur;
            this.chercheur.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.chercheur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.chercheur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chercheur.HoverState.Parent = this.chercheur;
            this.chercheur.Location = new System.Drawing.Point(45, 116);
            this.chercheur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chercheur.Name = "chercheur";
            this.chercheur.PasswordChar = '\0';
            this.chercheur.PlaceholderText = "";
            this.chercheur.SelectedText = "";
            this.chercheur.ShadowDecoration.Parent = this.chercheur;
            this.chercheur.Size = new System.Drawing.Size(253, 36);
            this.chercheur.TabIndex = 39;
            // 
            // Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 336);
            this.Controls.Add(this.chercheur);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.equipes);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.modifierButton);
            this.Name = "Affectation";
            this.Text = "Affectation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Button modifierButton;
        public Guna.UI2.WinForms.Guna2ComboBox equipes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2TextBox chercheur;
    }
}