
namespace Gestion_des_productions_scientifiques.Forms
{
    partial class AfficherPost
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
            this.title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Deslike = new Guna.UI2.WinForms.Guna2Button();
            this.like = new Guna.UI2.WinForms.Guna2Button();
            this.addFile = new Guna.UI2.WinForms.Guna2Button();
            this.fileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Advent Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.title.Location = new System.Drawing.Point(24, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(403, 40);
            this.title.TabIndex = 122;
            this.title.Text = "Nom de Production scientifique";
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.desc.Location = new System.Drawing.Point(24, 58);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(226, 24);
            this.desc.TabIndex = 123;
            this.desc.Text = "Nom de Production scientifique";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.username.Location = new System.Drawing.Point(555, 143);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(226, 24);
            this.username.TabIndex = 124;
            this.username.Text = "Nom de Production scientifique";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.date.Location = new System.Drawing.Point(312, 142);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(226, 24);
            this.date.TabIndex = 127;
            this.date.Text = "Nom de Production scientifique";
            // 
            // Deslike
            // 
            this.Deslike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deslike.AutoRoundedCorners = true;
            this.Deslike.BorderColor = System.Drawing.Color.DimGray;
            this.Deslike.BorderRadius = 17;
            this.Deslike.CheckedState.Parent = this.Deslike;
            this.Deslike.CustomImages.Parent = this.Deslike;
            this.Deslike.FillColor = System.Drawing.Color.White;
            this.Deslike.Font = new System.Drawing.Font("Advent Pro", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Deslike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.Deslike.HoverState.Parent = this.Deslike;
            this.Deslike.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.dislike;
            this.Deslike.Location = new System.Drawing.Point(166, 133);
            this.Deslike.Name = "Deslike";
            this.Deslike.ShadowDecoration.Parent = this.Deslike;
            this.Deslike.Size = new System.Drawing.Size(136, 36);
            this.Deslike.TabIndex = 126;
            this.Deslike.Text = "Dislike";
            this.Deslike.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Deslike.Click += new System.EventHandler(this.Deslike_Click);
            // 
            // like
            // 
            this.like.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.like.AutoRoundedCorners = true;
            this.like.BorderColor = System.Drawing.Color.DimGray;
            this.like.BorderRadius = 17;
            this.like.CheckedState.Parent = this.like;
            this.like.CustomImages.Parent = this.like;
            this.like.FillColor = System.Drawing.Color.White;
            this.like.Font = new System.Drawing.Font("Advent Pro", 9.749999F, System.Drawing.FontStyle.Bold);
            this.like.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.like.HoverState.Parent = this.like;
            this.like.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.like;
            this.like.Location = new System.Drawing.Point(24, 133);
            this.like.Name = "like";
            this.like.ShadowDecoration.Parent = this.like;
            this.like.Size = new System.Drawing.Size(136, 36);
            this.like.TabIndex = 125;
            this.like.Text = "Like";
            this.like.Click += new System.EventHandler(this.like_Click);
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
            this.addFile.Location = new System.Drawing.Point(608, 410);
            this.addFile.Name = "addFile";
            this.addFile.ShadowDecoration.Parent = this.addFile;
            this.addFile.Size = new System.Drawing.Size(180, 36);
            this.addFile.TabIndex = 130;
            this.addFile.Text = "Ajouter commantaire";
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
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
            this.fileName.Location = new System.Drawing.Point(13, 410);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.PlaceholderText = "";
            this.fileName.SelectedText = "";
            this.fileName.ShadowDecoration.Parent = this.fileName;
            this.fileName.Size = new System.Drawing.Size(588, 36);
            this.fileName.TabIndex = 128;
            // 
            // AfficherPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Deslike);
            this.Controls.Add(this.like);
            this.Controls.Add(this.username);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.Name = "AfficherPost";
            this.Text = "AfficherPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2HtmlLabel title;
        public Guna.UI2.WinForms.Guna2HtmlLabel desc;
        public Guna.UI2.WinForms.Guna2HtmlLabel username;
        public Guna.UI2.WinForms.Guna2Button like;
        public Guna.UI2.WinForms.Guna2Button Deslike;
        public Guna.UI2.WinForms.Guna2HtmlLabel date;
        private Guna.UI2.WinForms.Guna2Button addFile;
        private Guna.UI2.WinForms.Guna2TextBox fileName;
    }
}