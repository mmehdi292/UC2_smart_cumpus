

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Gestion_des_laboratoires_de_recherche
{
    partial class AjouterLabo
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
            this.anneeCreation = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Directeur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.acronyme = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nomlaboratoire = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ajouterLaboButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // anneeCreation
            // 
            this.anneeCreation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anneeCreation.AutoRoundedCorners = true;
            this.anneeCreation.BorderRadius = 17;
            this.anneeCreation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anneeCreation.DefaultText = "";
            this.anneeCreation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.anneeCreation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.anneeCreation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.anneeCreation.DisabledState.Parent = this.anneeCreation;
            this.anneeCreation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.anneeCreation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.anneeCreation.FocusedState.Parent = this.anneeCreation;
            this.anneeCreation.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.anneeCreation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.anneeCreation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.anneeCreation.HoverState.Parent = this.anneeCreation;
            this.anneeCreation.Location = new System.Drawing.Point(120, 289);
            this.anneeCreation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anneeCreation.Name = "anneeCreation";
            this.anneeCreation.PasswordChar = '\0';
            this.anneeCreation.PlaceholderText = "";
            this.anneeCreation.SelectedText = "";
            this.anneeCreation.ShadowDecoration.Parent = this.anneeCreation;
            this.anneeCreation.Size = new System.Drawing.Size(517, 36);
            this.anneeCreation.TabIndex = 1;
            this.anneeCreation.TextChanged += new System.EventHandler(this.anneeCreation_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(120, 258);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(135, 24);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Année de création";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(120, 342);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(178, 24);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Directeur de laboratoire";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // Directeur
            // 
            this.Directeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Directeur.AutoRoundedCorners = true;
            this.Directeur.BackColor = System.Drawing.Color.Transparent;
            this.Directeur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Directeur.BorderRadius = 17;
            this.Directeur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Directeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Directeur.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Directeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Directeur.FocusedState.Parent = this.Directeur;
            this.Directeur.Font = new System.Drawing.Font("Advent Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.Directeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.Directeur.HoverState.Parent = this.Directeur;
            this.Directeur.ItemHeight = 30;
            this.Directeur.ItemsAppearance.Parent = this.Directeur;
            this.Directeur.Location = new System.Drawing.Point(120, 372);
            this.Directeur.Name = "Directeur";
            this.Directeur.ShadowDecoration.Parent = this.Directeur;
            this.Directeur.Size = new System.Drawing.Size(517, 36);
            this.Directeur.TabIndex = 4;
            this.Directeur.SelectedIndexChanged += new System.EventHandler(this.Directeur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ajouter laboratoire";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(120, 93);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(77, 24);
            this.guna2HtmlLabel3.TabIndex = 9;
            this.guna2HtmlLabel3.Text = "Acronyme";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // acronyme
            // 
            this.acronyme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acronyme.AutoRoundedCorners = true;
            this.acronyme.BorderRadius = 17;
            this.acronyme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.acronyme.DefaultText = "";
            this.acronyme.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.acronyme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.acronyme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.acronyme.DisabledState.Parent = this.acronyme;
            this.acronyme.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.acronyme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.acronyme.FocusedState.Parent = this.acronyme;
            this.acronyme.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.acronyme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.acronyme.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.acronyme.HoverState.Parent = this.acronyme;
            this.acronyme.Location = new System.Drawing.Point(120, 124);
            this.acronyme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acronyme.Name = "acronyme";
            this.acronyme.PasswordChar = '\0';
            this.acronyme.PlaceholderText = "";
            this.acronyme.SelectedText = "";
            this.acronyme.ShadowDecoration.Parent = this.acronyme;
            this.acronyme.Size = new System.Drawing.Size(517, 36);
            this.acronyme.TabIndex = 8;
            this.acronyme.TextChanged += new System.EventHandler(this.acronyme_TextChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(120, 173);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(147, 24);
            this.guna2HtmlLabel4.TabIndex = 11;
            this.guna2HtmlLabel4.Text = "Nom de laboratoire";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // nomlaboratoire
            // 
            this.nomlaboratoire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomlaboratoire.AutoRoundedCorners = true;
            this.nomlaboratoire.BorderRadius = 17;
            this.nomlaboratoire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomlaboratoire.DefaultText = "";
            this.nomlaboratoire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nomlaboratoire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nomlaboratoire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomlaboratoire.DisabledState.Parent = this.nomlaboratoire;
            this.nomlaboratoire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomlaboratoire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomlaboratoire.FocusedState.Parent = this.nomlaboratoire;
            this.nomlaboratoire.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.nomlaboratoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.nomlaboratoire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomlaboratoire.HoverState.Parent = this.nomlaboratoire;
            this.nomlaboratoire.Location = new System.Drawing.Point(120, 204);
            this.nomlaboratoire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomlaboratoire.Name = "nomlaboratoire";
            this.nomlaboratoire.PasswordChar = '\0';
            this.nomlaboratoire.PlaceholderText = "";
            this.nomlaboratoire.SelectedText = "";
            this.nomlaboratoire.ShadowDecoration.Parent = this.nomlaboratoire;
            this.nomlaboratoire.Size = new System.Drawing.Size(517, 36);
            this.nomlaboratoire.TabIndex = 10;
            this.nomlaboratoire.TextChanged += new System.EventHandler(this.nomlaboratoire_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.laboratory;
            this.pictureBox1.Location = new System.Drawing.Point(43, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.labelImg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(222, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ajouterLaboButton
            // 
            this.ajouterLaboButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterLaboButton.AutoRoundedCorners = true;
            this.ajouterLaboButton.BorderRadius = 25;
            this.ajouterLaboButton.CheckedState.Parent = this.ajouterLaboButton;
            this.ajouterLaboButton.CustomImages.Parent = this.ajouterLaboButton;
            this.ajouterLaboButton.FillColor = System.Drawing.Color.White;
            this.ajouterLaboButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.ajouterLaboButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterLaboButton.HoverState.Parent = this.ajouterLaboButton;
            this.ajouterLaboButton.Image = global::Gestion_des_laboratoires_de_recherche.Properties.Resources.plus;
            this.ajouterLaboButton.Location = new System.Drawing.Point(273, 441);
            this.ajouterLaboButton.Name = "ajouterLaboButton";
            this.ajouterLaboButton.ShadowDecoration.Parent = this.ajouterLaboButton;
            this.ajouterLaboButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterLaboButton.TabIndex = 0;
            this.ajouterLaboButton.Text = "Ajouter laboratoire";
            this.ajouterLaboButton.Click += new System.EventHandler(this.ajouterLaboButton_Click);
            // 
            // AjouterLabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.nomlaboratoire);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.acronyme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Directeur);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.anneeCreation);
            this.Controls.Add(this.ajouterLaboButton);
            this.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AjouterLabo";
            this.Size = new System.Drawing.Size(737, 528);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ajouterLaboButton;
        private Guna.UI2.WinForms.Guna2TextBox anneeCreation;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2ComboBox Directeur;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox acronyme;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox nomlaboratoire;
    }
}
