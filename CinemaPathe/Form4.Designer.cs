namespace CinemaPathe
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.listView = new System.Windows.Forms.ListView();
            this.SalleV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraireV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilmV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CboFilms = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFilm = new System.Windows.Forms.PictureBox();
            this.TitreTxt = new System.Windows.Forms.Label();
            this.ReaTxt = new System.Windows.Forms.Label();
            this.DureeTxt = new System.Windows.Forms.Label();
            this.CboSalle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.InfTxt = new System.Windows.Forms.Label();
            this.DescFilm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.BackColor = System.Drawing.Color.Goldenrod;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SalleV,
            this.DateV,
            this.HoraireV,
            this.FilmV});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 61);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(361, 333);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // SalleV
            // 
            this.SalleV.Text = "Salle";
            this.SalleV.Width = 38;
            // 
            // DateV
            // 
            this.DateV.Text = "Date";
            this.DateV.Width = 116;
            // 
            // HoraireV
            // 
            this.HoraireV.Text = "Horaire";
            this.HoraireV.Width = 81;
            // 
            // FilmV
            // 
            this.FilmV.Text = "Film";
            this.FilmV.Width = 120;
            // 
            // CboFilms
            // 
            this.CboFilms.BackColor = System.Drawing.Color.Goldenrod;
            this.CboFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFilms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboFilms.FormattingEnabled = true;
            this.CboFilms.Location = new System.Drawing.Point(379, 100);
            this.CboFilms.Name = "CboFilms";
            this.CboFilms.Size = new System.Drawing.Size(165, 21);
            this.CboFilms.TabIndex = 19;
            this.CboFilms.SelectedIndexChanged += new System.EventHandler(this.CboFilms_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Horaire :";
            // 
            // pictureBoxFilm
            // 
            this.pictureBoxFilm.Image = global::CinemaPathe.Properties.Resources.logo2;
            this.pictureBoxFilm.Location = new System.Drawing.Point(550, 49);
            this.pictureBoxFilm.Name = "pictureBoxFilm";
            this.pictureBoxFilm.Size = new System.Drawing.Size(197, 197);
            this.pictureBoxFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilm.TabIndex = 23;
            this.pictureBoxFilm.TabStop = false;
            // 
            // TitreTxt
            // 
            this.TitreTxt.AutoSize = true;
            this.TitreTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreTxt.Location = new System.Drawing.Point(546, 249);
            this.TitreTxt.Name = "TitreTxt";
            this.TitreTxt.Size = new System.Drawing.Size(78, 19);
            this.TitreTxt.TabIndex = 24;
            this.TitreTxt.Text = "Titre: N/A";
            // 
            // ReaTxt
            // 
            this.ReaTxt.AutoSize = true;
            this.ReaTxt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ReaTxt.Location = new System.Drawing.Point(547, 287);
            this.ReaTxt.Name = "ReaTxt";
            this.ReaTxt.Size = new System.Drawing.Size(110, 17);
            this.ReaTxt.TabIndex = 25;
            this.ReaTxt.Text = "Réalisateur: N/A";
            // 
            // DureeTxt
            // 
            this.DureeTxt.AutoSize = true;
            this.DureeTxt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.DureeTxt.Location = new System.Drawing.Point(547, 268);
            this.DureeTxt.Name = "DureeTxt";
            this.DureeTxt.Size = new System.Drawing.Size(77, 17);
            this.DureeTxt.TabIndex = 26;
            this.DureeTxt.Text = "Durée: N/A";
            // 
            // CboSalle
            // 
            this.CboSalle.BackColor = System.Drawing.Color.Goldenrod;
            this.CboSalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboSalle.FormattingEnabled = true;
            this.CboSalle.Location = new System.Drawing.Point(429, 187);
            this.CboSalle.Name = "CboSalle";
            this.CboSalle.Size = new System.Drawing.Size(44, 21);
            this.CboSalle.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Salle :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(429, 161);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // InfTxt
            // 
            this.InfTxt.AutoSize = true;
            this.InfTxt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.InfTxt.Location = new System.Drawing.Point(547, 304);
            this.InfTxt.Name = "InfTxt";
            this.InfTxt.Size = new System.Drawing.Size(114, 17);
            this.InfTxt.TabIndex = 30;
            this.InfTxt.Text = "Info du film: N/A";
            // 
            // DescFilm
            // 
            this.DescFilm.Location = new System.Drawing.Point(393, 342);
            this.DescFilm.Name = "DescFilm";
            this.DescFilm.Size = new System.Drawing.Size(395, 99);
            this.DescFilm.TabIndex = 31;
            this.DescFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Selectionner un film :";
            // 
            // BtnAj
            // 
            this.BtnAj.AutoSize = true;
            this.BtnAj.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAj.ForeColor = System.Drawing.Color.White;
            this.BtnAj.Location = new System.Drawing.Point(379, 223);
            this.BtnAj.Name = "BtnAj";
            this.BtnAj.Size = new System.Drawing.Size(99, 23);
            this.BtnAj.TabIndex = 33;
            this.BtnAj.Text = "Ajouter projection";
            this.BtnAj.UseVisualStyleBackColor = false;
            this.BtnAj.Click += new System.EventHandler(this.BtnAj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Liste des projections de prévu: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescFilm);
            this.Controls.Add(this.InfTxt);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboSalle);
            this.Controls.Add(this.DureeTxt);
            this.Controls.Add(this.ReaTxt);
            this.Controls.Add(this.TitreTxt);
            this.Controls.Add(this.pictureBoxFilm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CboFilms);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Projection";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader SalleV;
        private System.Windows.Forms.ColumnHeader DateV;
        private System.Windows.Forms.ColumnHeader HoraireV;
        private System.Windows.Forms.ColumnHeader FilmV;
        private System.Windows.Forms.ComboBox CboFilms;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFilm;
        private System.Windows.Forms.Label TitreTxt;
        private System.Windows.Forms.Label ReaTxt;
        private System.Windows.Forms.Label DureeTxt;
        private System.Windows.Forms.ComboBox CboSalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label InfTxt;
        private System.Windows.Forms.Label DescFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAj;
        private System.Windows.Forms.Label label4;
    }
}