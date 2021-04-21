
namespace Gestion_des_productions_scientifiques.Forms
{
    partial class AddConference
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
            this.addfiles = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dure = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.salle = new Guna.UI2.WinForms.Guna2TextBox();
            this.places = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.motcle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.ajouterConferenceButton = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.places)).BeginInit();
            this.SuspendLayout();
            // 
            // addfiles
            // 
            this.addfiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addfiles.AutoRoundedCorners = true;
            this.addfiles.BorderColor = System.Drawing.Color.DimGray;
            this.addfiles.BorderRadius = 17;
            this.addfiles.CheckedState.Parent = this.addfiles;
            this.addfiles.CustomImages.Parent = this.addfiles;
            this.addfiles.FillColor = System.Drawing.Color.White;
            this.addfiles.Font = new System.Drawing.Font("Advent Pro", 9.749999F, System.Drawing.FontStyle.Bold);
            this.addfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.addfiles.HoverState.Parent = this.addfiles;
            this.addfiles.Location = new System.Drawing.Point(560, 592);
            this.addfiles.Name = "addfiles";
            this.addfiles.ShadowDecoration.Parent = this.addfiles;
            this.addfiles.Size = new System.Drawing.Size(136, 36);
            this.addfiles.TabIndex = 100;
            this.addfiles.Text = "Ajouter fichiers";
            this.addfiles.Click += new System.EventHandler(this.addfiles_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Advent Pro SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(409, 7);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(259, 44);
            this.guna2HtmlLabel5.TabIndex = 99;
            this.guna2HtmlLabel5.Text = "Ajouter Conference";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(71, 643);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(37, 24);
            this.guna2HtmlLabel3.TabIndex = 98;
            this.guna2HtmlLabel3.Text = "Dure";
            // 
            // dure
            // 
            this.dure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dure.AutoRoundedCorners = true;
            this.dure.BorderRadius = 17;
            this.dure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dure.DefaultText = "";
            this.dure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dure.DisabledState.Parent = this.dure;
            this.dure.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dure.FocusedState.Parent = this.dure;
            this.dure.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.dure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.dure.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dure.HoverState.Parent = this.dure;
            this.dure.Location = new System.Drawing.Point(71, 674);
            this.dure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dure.Name = "dure";
            this.dure.PasswordChar = '\0';
            this.dure.PlaceholderText = "";
            this.dure.SelectedText = "";
            this.dure.ShadowDecoration.Parent = this.dure;
            this.dure.Size = new System.Drawing.Size(625, 36);
            this.dure.TabIndex = 97;
            this.dure.TextChanged += new System.EventHandler(this.dure_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(71, 476);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(41, 24);
            this.guna2HtmlLabel2.TabIndex = 96;
            this.guna2HtmlLabel2.Text = "Salle";
            // 
            // salle
            // 
            this.salle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salle.AutoRoundedCorners = true;
            this.salle.BorderRadius = 17;
            this.salle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salle.DefaultText = "";
            this.salle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salle.DisabledState.Parent = this.salle;
            this.salle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salle.FocusedState.Parent = this.salle;
            this.salle.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.salle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.salle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salle.HoverState.Parent = this.salle;
            this.salle.Location = new System.Drawing.Point(71, 507);
            this.salle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salle.Name = "salle";
            this.salle.PasswordChar = '\0';
            this.salle.PlaceholderText = "";
            this.salle.SelectedText = "";
            this.salle.ShadowDecoration.Parent = this.salle;
            this.salle.Size = new System.Drawing.Size(625, 36);
            this.salle.TabIndex = 95;
            // 
            // places
            // 
            this.places.AutoRoundedCorners = true;
            this.places.BackColor = System.Drawing.Color.Transparent;
            this.places.BorderRadius = 19;
            this.places.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.places.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.places.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.places.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.places.DisabledState.Parent = this.places;
            this.places.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.places.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.places.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.places.FocusedState.Parent = this.places;
            this.places.Font = new System.Drawing.Font("Advent Pro", 12F, System.Drawing.FontStyle.Bold);
            this.places.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.places.Location = new System.Drawing.Point(71, 424);
            this.places.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.places.Name = "places";
            this.places.ShadowDecoration.Parent = this.places;
            this.places.Size = new System.Drawing.Size(625, 40);
            this.places.TabIndex = 94;
            this.places.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(71, 393);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(50, 24);
            this.guna2HtmlLabel1.TabIndex = 93;
            this.guna2HtmlLabel1.Text = "Places";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(71, 561);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel6.TabIndex = 92;
            this.guna2HtmlLabel6.Text = "Fichers";
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
            this.FileName.Location = new System.Drawing.Point(71, 592);
            this.FileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileName.Name = "FileName";
            this.FileName.PasswordChar = '\0';
            this.FileName.PlaceholderText = "";
            this.FileName.SelectedText = "";
            this.FileName.ShadowDecoration.Parent = this.FileName;
            this.FileName.Size = new System.Drawing.Size(482, 36);
            this.FileName.TabIndex = 90;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(71, 313);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(32, 24);
            this.guna2HtmlLabel4.TabIndex = 91;
            this.guna2HtmlLabel4.Text = "Lieu";
            // 
            // lieu
            // 
            this.lieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lieu.AutoRoundedCorners = true;
            this.lieu.BorderRadius = 17;
            this.lieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lieu.DefaultText = "";
            this.lieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lieu.DisabledState.Parent = this.lieu;
            this.lieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lieu.FocusedState.Parent = this.lieu;
            this.lieu.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.lieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.lieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lieu.HoverState.Parent = this.lieu;
            this.lieu.Location = new System.Drawing.Point(71, 344);
            this.lieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lieu.Name = "lieu";
            this.lieu.PasswordChar = '\0';
            this.lieu.PlaceholderText = "";
            this.lieu.SelectedText = "";
            this.lieu.ShadowDecoration.Parent = this.lieu;
            this.lieu.Size = new System.Drawing.Size(625, 36);
            this.lieu.TabIndex = 89;
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
            this.nom.Location = new System.Drawing.Point(71, 58);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(625, 36);
            this.nom.TabIndex = 113;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(71, 27);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(231, 24);
            this.guna2HtmlLabel9.TabIndex = 115;
            this.guna2HtmlLabel9.Text = "Nom de Production scientifique";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(71, 101);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(86, 24);
            this.guna2HtmlLabel8.TabIndex = 116;
            this.guna2HtmlLabel8.Text = "Description";
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
            this.motcle.Location = new System.Drawing.Point(71, 270);
            this.motcle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motcle.Name = "motcle";
            this.motcle.PasswordChar = '\0';
            this.motcle.PlaceholderText = "";
            this.motcle.SelectedText = "";
            this.motcle.ShadowDecoration.Parent = this.motcle;
            this.motcle.Size = new System.Drawing.Size(625, 36);
            this.motcle.TabIndex = 114;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(71, 239);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(56, 24);
            this.guna2HtmlLabel7.TabIndex = 117;
            this.guna2HtmlLabel7.Text = "Mot Cle";
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
            this.desc.Location = new System.Drawing.Point(71, 132);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(625, 101);
            this.desc.TabIndex = 118;
            this.desc.Text = "";
            // 
            // ajouterConferenceButton
            // 
            this.ajouterConferenceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterConferenceButton.AutoRoundedCorners = true;
            this.ajouterConferenceButton.BorderRadius = 25;
            this.ajouterConferenceButton.CheckedState.Parent = this.ajouterConferenceButton;
            this.ajouterConferenceButton.CustomImages.Parent = this.ajouterConferenceButton;
            this.ajouterConferenceButton.FillColor = System.Drawing.Color.White;
            this.ajouterConferenceButton.Font = new System.Drawing.Font("Advent Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.ajouterConferenceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(191)))));
            this.ajouterConferenceButton.HoverState.Parent = this.ajouterConferenceButton;
            this.ajouterConferenceButton.Image = global::Gestion_des_productions_scientifiques.Properties.Resources.ADDprod1;
            this.ajouterConferenceButton.Location = new System.Drawing.Point(281, 726);
            this.ajouterConferenceButton.Name = "ajouterConferenceButton";
            this.ajouterConferenceButton.ShadowDecoration.Parent = this.ajouterConferenceButton;
            this.ajouterConferenceButton.Size = new System.Drawing.Size(187, 52);
            this.ajouterConferenceButton.TabIndex = 88;
            this.ajouterConferenceButton.Text = "Ajouter Conference";
            this.ajouterConferenceButton.Click += new System.EventHandler(this.ajouterConferenceButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 803);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.motcle);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.addfiles);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.dure);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.salle);
            this.Controls.Add(this.places);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.ajouterConferenceButton);
            this.Name = "AddConference";
            this.Text = "AddConference";
            ((System.ComponentModel.ISupportInitialize)(this.places)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button addfiles;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox dure;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox salle;
        private Guna.UI2.WinForms.Guna2NumericUpDown places;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox FileName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox lieu;
        private Guna.UI2.WinForms.Guna2Button ajouterConferenceButton;
        private Guna.UI2.WinForms.Guna2Button ModifierConferenceButton;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox motcle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}