
namespace Gestion_des_laboratoires_de_recherche.Forms
{
    partial class EditEquipe
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
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nomEquipe = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChefCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.laboCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ModifierEquipeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IDText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(142, 112);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(112, 24);
            this.guna2HtmlLabel4.TabIndex = 18;
            this.guna2HtmlLabel4.Text = "Nom de equipe";
            // 
            // nomEquipe
            // 
            this.nomEquipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomEquipe.AutoRoundedCorners = true;
            this.nomEquipe.BorderRadius = 17;
            this.nomEquipe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomEquipe.DefaultText = "";
            this.nomEquipe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nomEquipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nomEquipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomEquipe.DisabledState.Parent = this.nomEquipe;
            this.nomEquipe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomEquipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomEquipe.FocusedState.Parent = this.nomEquipe;
            this.nomEquipe.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.nomEquipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.nomEquipe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomEquipe.HoverState.Parent = this.nomEquipe;
            this.nomEquipe.Location = new System.Drawing.Point(142, 143);
            this.nomEquipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomEquipe.Name = "nomEquipe";
            this.nomEquipe.PasswordChar = '\0';
            this.nomEquipe.PlaceholderText = "";
            this.nomEquipe.SelectedText = "";
            this.nomEquipe.ShadowDecoration.Parent = this.nomEquipe;
            this.nomEquipe.Size = new System.Drawing.Size(517, 36);
            this.nomEquipe.TabIndex = 17;
            // 
            // ChefCombo
            // 
            this.ChefCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChefCombo.AutoRoundedCorners = true;
            this.ChefCombo.BackColor = System.Drawing.Color.Transparent;
            this.ChefCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ChefCombo.BorderRadius = 17;
            this.ChefCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChefCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChefCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChefCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChefCombo.FocusedState.Parent = this.ChefCombo;
            this.ChefCombo.Font = new System.Drawing.Font("Advent Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.ChefCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ChefCombo.HoverState.Parent = this.ChefCombo;
            this.ChefCombo.ItemHeight = 30;
            this.ChefCombo.ItemsAppearance.Parent = this.ChefCombo;
            this.ChefCombo.Location = new System.Drawing.Point(142, 311);
            this.ChefCombo.Name = "ChefCombo";
            this.ChefCombo.ShadowDecoration.Parent = this.ChefCombo;
            this.ChefCombo.Size = new System.Drawing.Size(517, 36);
            this.ChefCombo.TabIndex = 15;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(142, 281);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 24);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Chef de equipe";
            // 
            // laboCombo
            // 
            this.laboCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.laboCombo.AutoRoundedCorners = true;
            this.laboCombo.BackColor = System.Drawing.Color.Transparent;
            this.laboCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.laboCombo.BorderRadius = 17;
            this.laboCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.laboCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laboCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.laboCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.laboCombo.FocusedState.Parent = this.laboCombo;
            this.laboCombo.Font = new System.Drawing.Font("Advent Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.laboCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.laboCombo.HoverState.Parent = this.laboCombo;
            this.laboCombo.ItemHeight = 30;
            this.laboCombo.ItemsAppearance.Parent = this.laboCombo;
            this.laboCombo.Location = new System.Drawing.Point(142, 229);
            this.laboCombo.Name = "laboCombo";
            this.laboCombo.ShadowDecoration.Parent = this.laboCombo;
            this.laboCombo.Size = new System.Drawing.Size(517, 36);
            this.laboCombo.TabIndex = 16;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(142, 199);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(88, 24);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Laboratoire";
            // 
            // ModifierEquipeButton
            // 
            this.ModifierEquipeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifierEquipeButton.AutoRoundedCorners = true;
            this.ModifierEquipeButton.BorderRadius = 25;
            this.ModifierEquipeButton.CheckedState.Parent = this.ModifierEquipeButton;
            this.ModifierEquipeButton.CustomImages.Parent = this.ModifierEquipeButton;
            this.ModifierEquipeButton.FillColor = System.Drawing.Color.White;
            this.ModifierEquipeButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.ModifierEquipeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ModifierEquipeButton.HoverState.Parent = this.ModifierEquipeButton;
            this.ModifierEquipeButton.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.edit;
            this.ModifierEquipeButton.Location = new System.Drawing.Point(298, 381);
            this.ModifierEquipeButton.Name = "ModifierEquipeButton";
            this.ModifierEquipeButton.ShadowDecoration.Parent = this.ModifierEquipeButton;
            this.ModifierEquipeButton.Size = new System.Drawing.Size(187, 52);
            this.ModifierEquipeButton.TabIndex = 12;
            this.ModifierEquipeButton.Text = "Modifier equipe";
            this.ModifierEquipeButton.Click += new System.EventHandler(this.ModifierEquipeButton_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(142, 28);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(20, 24);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "ID";
            // 
            // IDText
            // 
            this.IDText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDText.AutoRoundedCorners = true;
            this.IDText.BorderRadius = 17;
            this.IDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDText.DefaultText = "";
            this.IDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDText.DisabledState.Parent = this.IDText;
            this.IDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDText.FocusedState.Parent = this.IDText;
            this.IDText.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.IDText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.IDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDText.HoverState.Parent = this.IDText;
            this.IDText.Location = new System.Drawing.Point(142, 59);
            this.IDText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDText.Name = "IDText";
            this.IDText.PasswordChar = '\0';
            this.IDText.PlaceholderText = "";
            this.IDText.ReadOnly = true;
            this.IDText.SelectedText = "";
            this.IDText.ShadowDecoration.Parent = this.IDText;
            this.IDText.Size = new System.Drawing.Size(517, 36);
            this.IDText.TabIndex = 19;
            // 
            // EditEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.nomEquipe);
            this.Controls.Add(this.ChefCombo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.laboCombo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.ModifierEquipeButton);
            this.Name = "EditEquipe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox nomEquipe;
        public Guna.UI2.WinForms.Guna2ComboBox ChefCombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2ComboBox laboCombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button ModifierEquipeButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox IDText;
    }
}