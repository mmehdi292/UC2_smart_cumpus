
namespace Gestion_des_productions_scientifiques.Forms
{
    partial class AddLivre
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
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.version = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.addPdf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.langue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pages = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.motcle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ajouterLivreButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.version)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Advent Pro SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(288, 12);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(177, 44);
            this.guna2HtmlLabel5.TabIndex = 93;
            this.guna2HtmlLabel5.Text = "Ajouter Livre";
            this.guna2HtmlLabel5.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(78, 548);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 24);
            this.guna2HtmlLabel1.TabIndex = 106;
            this.guna2HtmlLabel1.Text = "Version";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // version
            // 
            this.version.AutoRoundedCorners = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.BorderRadius = 19;
            this.version.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.version.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.version.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.version.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.version.DisabledState.Parent = this.version;
            this.version.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.version.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.version.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.version.FocusedState.Parent = this.version;
            this.version.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.version.Location = new System.Drawing.Point(78, 578);
            this.version.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.version.Name = "version";
            this.version.ShadowDecoration.Parent = this.version;
            this.version.Size = new System.Drawing.Size(625, 40);
            this.version.TabIndex = 105;
            this.version.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.version.ValueChanged += new System.EventHandler(this.version_ValueChanged);
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
            this.addPdf.Location = new System.Drawing.Point(567, 504);
            this.addPdf.Name = "addPdf";
            this.addPdf.ShadowDecoration.Parent = this.addPdf;
            this.addPdf.Size = new System.Drawing.Size(136, 36);
            this.addPdf.TabIndex = 104;
            this.addPdf.Text = "Ajouter fichiers";
            this.addPdf.Click += new System.EventHandler(this.addPdf_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(78, 634);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 24);
            this.guna2HtmlLabel3.TabIndex = 103;
            this.guna2HtmlLabel3.Text = "Langue";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
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
            this.langue.Location = new System.Drawing.Point(78, 665);
            this.langue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.langue.Name = "langue";
            this.langue.PasswordChar = '\0';
            this.langue.PlaceholderText = "";
            this.langue.SelectedText = "";
            this.langue.ShadowDecoration.Parent = this.langue;
            this.langue.Size = new System.Drawing.Size(625, 36);
            this.langue.TabIndex = 102;
            this.langue.TextChanged += new System.EventHandler(this.langue_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(78, 388);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(47, 24);
            this.guna2HtmlLabel2.TabIndex = 101;
            this.guna2HtmlLabel2.Text = "Pages";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
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
            this.pages.Location = new System.Drawing.Point(78, 418);
            this.pages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pages.Name = "pages";
            this.pages.ShadowDecoration.Parent = this.pages;
            this.pages.Size = new System.Drawing.Size(625, 40);
            this.pages.TabIndex = 100;
            this.pages.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.pages.ValueChanged += new System.EventHandler(this.pages_ValueChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(78, 473);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel6.TabIndex = 99;
            this.guna2HtmlLabel6.Text = "Fichers";
            this.guna2HtmlLabel6.Click += new System.EventHandler(this.guna2HtmlLabel6_Click);
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
            this.fileName.Location = new System.Drawing.Point(78, 504);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.PlaceholderText = "";
            this.fileName.SelectedText = "";
            this.fileName.ShadowDecoration.Parent = this.fileName;
            this.fileName.Size = new System.Drawing.Size(482, 36);
            this.fileName.TabIndex = 98;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.BackColor = System.Drawing.Color.White;
            this.desc.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.desc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.desc.Location = new System.Drawing.Point(78, 196);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(625, 101);
            this.desc.TabIndex = 124;
            this.desc.Text = "";
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(78, 303);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel7.TabIndex = 123;
            this.guna2HtmlLabel7.Text = "Mot Cle";
            this.guna2HtmlLabel7.Click += new System.EventHandler(this.guna2HtmlLabel7_Click);
            // 
            // motcle
            // 
            this.motcle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motcle.AutoRoundedCorners = true;
            this.motcle.BorderRadius = 17;
            this.motcle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.motcle.DefaultText = "";
            this.motcle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.motcle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.motcle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.motcle.DisabledState.Parent = this.motcle;
            this.motcle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.motcle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.motcle.FocusedState.Parent = this.motcle;
            this.motcle.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.motcle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.motcle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.motcle.HoverState.Parent = this.motcle;
            this.motcle.Location = new System.Drawing.Point(78, 334);
            this.motcle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motcle.Name = "motcle";
            this.motcle.PasswordChar = '\0';
            this.motcle.PlaceholderText = "";
            this.motcle.SelectedText = "";
            this.motcle.ShadowDecoration.Parent = this.motcle;
            this.motcle.Size = new System.Drawing.Size(625, 36);
            this.motcle.TabIndex = 120;
            this.motcle.TextChanged += new System.EventHandler(this.motcle_TextChanged);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(78, 165);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(86, 24);
            this.guna2HtmlLabel8.TabIndex = 122;
            this.guna2HtmlLabel8.Text = "Description";
            this.guna2HtmlLabel8.Click += new System.EventHandler(this.guna2HtmlLabel8_Click);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(78, 91);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(231, 24);
            this.guna2HtmlLabel9.TabIndex = 121;
            this.guna2HtmlLabel9.Text = "Nom de Production scientifique";
            this.guna2HtmlLabel9.Click += new System.EventHandler(this.guna2HtmlLabel9_Click);
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
            this.nom.Location = new System.Drawing.Point(78, 122);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(625, 36);
            this.nom.TabIndex = 119;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
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
            this.ajouterLivreButton.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.ADDprod1;
            this.ajouterLivreButton.Location = new System.Drawing.Point(288, 708);
            this.ajouterLivreButton.Name = "ajouterLivreButton";
            this.ajouterLivreButton.ShadowDecoration.Parent = this.ajouterLivreButton;
            this.ajouterLivreButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterLivreButton.TabIndex = 97;
            this.ajouterLivreButton.Text = "Ajouter livre";
            this.ajouterLivreButton.Click += new System.EventHandler(this.ajouterLivreButton_Click);
            // 
            // AddLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 772);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.motcle);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.addPdf);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.langue);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.ajouterLivreButton);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Name = "AddLivre";
            this.Text = "AddLivre";
            ((System.ComponentModel.ISupportInitialize)(this.version)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2NumericUpDown version;
        public Guna.UI2.WinForms.Guna2Button addPdf;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Guna.UI2.WinForms.Guna2TextBox langue;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2NumericUpDown pages;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        public Guna.UI2.WinForms.Guna2TextBox fileName;
        public Guna.UI2.WinForms.Guna2Button ajouterLivreButton;
        public System.Windows.Forms.RichTextBox desc;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        public Guna.UI2.WinForms.Guna2TextBox motcle;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        public Guna.UI2.WinForms.Guna2TextBox nom;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}