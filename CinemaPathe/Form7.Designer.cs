namespace CinemaPathe
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.listView = new System.Windows.Forms.ListView();
            this.Titre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Public = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mode = new System.Windows.Forms.Label();
            this.TxtBoxFilm = new System.Windows.Forms.TextBox();
            this.lblfilm = new System.Windows.Forms.Label();
            this.BtnAn = new System.Windows.Forms.Button();
            this.BtnCom = new System.Windows.Forms.Button();
            this.lblgenre = new System.Windows.Forms.Label();
            this.BtnAj = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.lblpublic = new System.Windows.Forms.Label();
            this.Cbopublic = new System.Windows.Forms.ComboBox();
            this.listboxgenres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.BackColor = System.Drawing.Color.Goldenrod;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titre,
            this.Public,
            this.Genres});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(5, 75);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(485, 333);
            this.listView.TabIndex = 31;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Titre
            // 
            this.Titre.Text = "Titre Film";
            this.Titre.Width = 132;
            // 
            // Public
            // 
            this.Public.DisplayIndex = 2;
            this.Public.Text = "Types de public";
            this.Public.Width = 191;
            // 
            // Genres
            // 
            this.Genres.DisplayIndex = 1;
            this.Genres.Text = "Genres";
            this.Genres.Width = 158;
            // 
            // Mode
            // 
            this.Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mode.BackColor = System.Drawing.Color.Transparent;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Mode.Location = new System.Drawing.Point(175, 576);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(141, 10);
            this.Mode.TabIndex = 44;
            this.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mode.Visible = false;
            // 
            // TxtBoxFilm
            // 
            this.TxtBoxFilm.BackColor = System.Drawing.Color.Goldenrod;
            this.TxtBoxFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxFilm.Location = new System.Drawing.Point(12, 464);
            this.TxtBoxFilm.Name = "TxtBoxFilm";
            this.TxtBoxFilm.ShortcutsEnabled = false;
            this.TxtBoxFilm.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxFilm.TabIndex = 41;
            this.TxtBoxFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxFilm.Visible = false;
            // 
            // lblfilm
            // 
            this.lblfilm.AutoSize = true;
            this.lblfilm.Location = new System.Drawing.Point(15, 440);
            this.lblfilm.Name = "lblfilm";
            this.lblfilm.Size = new System.Drawing.Size(62, 13);
            this.lblfilm.TabIndex = 40;
            this.lblfilm.Text = "Nom du film";
            this.lblfilm.Visible = false;
            // 
            // BtnAn
            // 
            this.BtnAn.BackColor = System.Drawing.Color.DarkRed;
            this.BtnAn.ForeColor = System.Drawing.Color.Snow;
            this.BtnAn.Location = new System.Drawing.Point(45, 589);
            this.BtnAn.Name = "BtnAn";
            this.BtnAn.Size = new System.Drawing.Size(75, 23);
            this.BtnAn.TabIndex = 39;
            this.BtnAn.Text = "Annuler";
            this.BtnAn.UseVisualStyleBackColor = false;
            this.BtnAn.Visible = false;
            this.BtnAn.Click += new System.EventHandler(this.BtnAn_Click_1);
            // 
            // BtnCom
            // 
            this.BtnCom.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCom.ForeColor = System.Drawing.Color.Snow;
            this.BtnCom.Location = new System.Drawing.Point(254, 589);
            this.BtnCom.Name = "BtnCom";
            this.BtnCom.Size = new System.Drawing.Size(75, 23);
            this.BtnCom.TabIndex = 38;
            this.BtnCom.Text = "Confirmer";
            this.BtnCom.UseVisualStyleBackColor = false;
            this.BtnCom.Visible = false;
            this.BtnCom.Click += new System.EventHandler(this.BtnCom_Click);
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(207, 440);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(120, 13);
            this.lblgenre.TabIndex = 37;
            this.lblgenre.Text = "Selectionner les genres:";
            this.lblgenre.Visible = false;
            // 
            // BtnAj
            // 
            this.BtnAj.AutoSize = true;
            this.BtnAj.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAj.ForeColor = System.Drawing.Color.White;
            this.BtnAj.Location = new System.Drawing.Point(180, 590);
            this.BtnAj.Name = "BtnAj";
            this.BtnAj.Size = new System.Drawing.Size(95, 23);
            this.BtnAj.TabIndex = 33;
            this.BtnAj.Text = "Ajouter un film";
            this.BtnAj.UseVisualStyleBackColor = false;
            this.BtnAj.Click += new System.EventHandler(this.BtnAj_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(111, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(280, 40);
            this.Title.TabIndex = 32;
            this.Title.Text = "Gestion des Films";
            // 
            // lblpublic
            // 
            this.lblpublic.AutoSize = true;
            this.lblpublic.Location = new System.Drawing.Point(9, 507);
            this.lblpublic.Name = "lblpublic";
            this.lblpublic.Size = new System.Drawing.Size(111, 13);
            this.lblpublic.TabIndex = 46;
            this.lblpublic.Text = "Selectionner le public:";
            this.lblpublic.Visible = false;
            // 
            // Cbopublic
            // 
            this.Cbopublic.BackColor = System.Drawing.Color.Goldenrod;
            this.Cbopublic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbopublic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbopublic.FormattingEnabled = true;
            this.Cbopublic.Location = new System.Drawing.Point(12, 523);
            this.Cbopublic.Name = "Cbopublic";
            this.Cbopublic.Size = new System.Drawing.Size(141, 21);
            this.Cbopublic.TabIndex = 45;
            this.Cbopublic.Visible = false;
            // 
            // listboxgenres
            // 
            this.listboxgenres.FormattingEnabled = true;
            this.listboxgenres.Location = new System.Drawing.Point(333, 440);
            this.listboxgenres.Name = "listboxgenres";
            this.listboxgenres.Size = new System.Drawing.Size(148, 173);
            this.listboxgenres.TabIndex = 47;
            this.listboxgenres.Visible = false;
            // 
            // Form4
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(493, 640);
            this.Controls.Add(this.listboxgenres);
            this.Controls.Add(this.lblpublic);
            this.Controls.Add(this.Cbopublic);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.TxtBoxFilm);
            this.Controls.Add(this.lblfilm);
            this.Controls.Add(this.BtnAn);
            this.Controls.Add(this.BtnCom);
            this.Controls.Add(this.lblgenre);
            this.Controls.Add(this.BtnAj);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Titre;
        private System.Windows.Forms.ColumnHeader Public;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.TextBox TxtBoxFilm;
        private System.Windows.Forms.Label lblfilm;
        private System.Windows.Forms.Button BtnAn;
        private System.Windows.Forms.Button BtnCom;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.Button BtnAj;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblpublic;
        private System.Windows.Forms.ComboBox Cbopublic;
        private System.Windows.Forms.ListBox listboxgenres;
        private System.Windows.Forms.ColumnHeader Genres;
    }
}