namespace CinemaPathe
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenre = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogoMid = new System.Windows.Forms.PictureBox();
            this.TitleStart = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSalle = new System.Windows.Forms.Button();
            this.btnfilms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenre
            // 
            this.btnGenre.AutoSize = true;
            this.btnGenre.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenre.Location = new System.Drawing.Point(52, 114);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(107, 23);
            this.btnGenre.TabIndex = 1;
            this.btnGenre.Text = "Modifier les Genres";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Visible = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Goldenrod;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumGenre,
            this.NomGenre});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 225);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // NumGenre
            // 
            this.NumGenre.Text = "Num";
            // 
            // NomGenre
            // 
            this.NomGenre.Text = "Nom du Genre";
            this.NomGenre.Width = 135;
            // 
            // LogoMid
            // 
            this.LogoMid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogoMid.Image = global::CinemaPathe.Properties.Resources.logo1;
            this.LogoMid.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoMid.InitialImage")));
            this.LogoMid.Location = new System.Drawing.Point(207, 143);
            this.LogoMid.Name = "LogoMid";
            this.LogoMid.Size = new System.Drawing.Size(199, 179);
            this.LogoMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMid.TabIndex = 3;
            this.LogoMid.TabStop = false;
            // 
            // TitleStart
            // 
            this.TitleStart.AutoSize = true;
            this.TitleStart.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleStart.Location = new System.Drawing.Point(174, 82);
            this.TitleStart.Name = "TitleStart";
            this.TitleStart.Size = new System.Drawing.Size(276, 35);
            this.TitleStart.TabIndex = 4;
            this.TitleStart.Text = "Cinéma Pathé Mâcon";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 328);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Goldenrod;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(412, 143);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(199, 225);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salle";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nb de places";
            this.columnHeader2.Width = 135;
            // 
            // BtnSalle
            // 
            this.BtnSalle.AutoSize = true;
            this.BtnSalle.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnSalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalle.Location = new System.Drawing.Point(462, 114);
            this.BtnSalle.Name = "BtnSalle";
            this.BtnSalle.Size = new System.Drawing.Size(107, 23);
            this.BtnSalle.TabIndex = 6;
            this.BtnSalle.Text = "Modifier les Salles";
            this.BtnSalle.UseVisualStyleBackColor = false;
            this.BtnSalle.Visible = false;
            this.BtnSalle.Click += new System.EventHandler(this.BtnSalle_Click);
            // 
            // btnfilms
            // 
            this.btnfilms.AutoSize = true;
            this.btnfilms.BackColor = System.Drawing.Color.Goldenrod;
            this.btnfilms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfilms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfilms.Location = new System.Drawing.Point(261, 32);
            this.btnfilms.Name = "btnfilms";
            this.btnfilms.Size = new System.Drawing.Size(107, 23);
            this.btnfilms.TabIndex = 8;
            this.btnfilms.Text = "Visu film";
            this.btnfilms.UseVisualStyleBackColor = false;
            this.btnfilms.Visible = false;
            this.btnfilms.Click += new System.EventHandler(this.btnfilms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 565);
            this.Controls.Add(this.btnfilms);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.BtnSalle);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TitleStart);
            this.Controls.Add(this.LogoMid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NumGenre;
        private System.Windows.Forms.ColumnHeader NomGenre;
        private System.Windows.Forms.PictureBox LogoMid;
        private System.Windows.Forms.Label TitleStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button BtnSalle;
        private System.Windows.Forms.Button btnfilms;
    }
}

