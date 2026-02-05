namespace CinemaPathe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.listView = new System.Windows.Forms.ListView();
            this.NumV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = new System.Windows.Forms.Label();
            this.BtnAj = new System.Windows.Forms.Button();
            this.BtnSup = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.CboSalle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAn = new System.Windows.Forms.Button();
            this.BtnCom = new System.Windows.Forms.Button();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.BackColor = System.Drawing.Color.Goldenrod;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumV,
            this.PlaceV});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(38, 52);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(234, 333);
            this.listView.TabIndex = 17;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // NumV
            // 
            this.NumV.Text = "Lettre de Salle";
            this.NumV.Width = 80;
            // 
            // PlaceV
            // 
            this.PlaceV.Text = "Nombre de places";
            this.PlaceV.Width = 150;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(15, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(284, 40);
            this.Title.TabIndex = 18;
            this.Title.Text = "Gestion des Salles";
            // 
            // BtnAj
            // 
            this.BtnAj.AutoSize = true;
            this.BtnAj.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAj.ForeColor = System.Drawing.Color.White;
            this.BtnAj.Location = new System.Drawing.Point(12, 396);
            this.BtnAj.Name = "BtnAj";
            this.BtnAj.Size = new System.Drawing.Size(95, 23);
            this.BtnAj.TabIndex = 19;
            this.BtnAj.Text = "Ajouter une salle";
            this.BtnAj.UseVisualStyleBackColor = false;
            this.BtnAj.Click += new System.EventHandler(this.BtnAj_Click);
            // 
            // BtnSup
            // 
            this.BtnSup.AutoSize = true;
            this.BtnSup.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSup.ForeColor = System.Drawing.Color.White;
            this.BtnSup.Location = new System.Drawing.Point(12, 423);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Size = new System.Drawing.Size(109, 23);
            this.BtnSup.TabIndex = 20;
            this.BtnSup.Text = "Supprimer une salle";
            this.BtnSup.UseVisualStyleBackColor = false;
            this.BtnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.AutoSize = true;
            this.BtnMod.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMod.ForeColor = System.Drawing.Color.White;
            this.BtnMod.Location = new System.Drawing.Point(12, 455);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(109, 23);
            this.BtnMod.TabIndex = 21;
            this.BtnMod.Text = "Modifier une salle";
            this.BtnMod.UseVisualStyleBackColor = false;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // CboSalle
            // 
            this.CboSalle.BackColor = System.Drawing.Color.Goldenrod;
            this.CboSalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboSalle.FormattingEnabled = true;
            this.CboSalle.Location = new System.Drawing.Point(247, 425);
            this.CboSalle.Name = "CboSalle";
            this.CboSalle.Size = new System.Drawing.Size(39, 21);
            this.CboSalle.TabIndex = 22;
            this.CboSalle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Selectionner une salle:";
            this.label1.Visible = false;
            // 
            // BtnAn
            // 
            this.BtnAn.BackColor = System.Drawing.Color.DarkRed;
            this.BtnAn.ForeColor = System.Drawing.Color.Snow;
            this.BtnAn.Location = new System.Drawing.Point(12, 561);
            this.BtnAn.Name = "BtnAn";
            this.BtnAn.Size = new System.Drawing.Size(75, 23);
            this.BtnAn.TabIndex = 25;
            this.BtnAn.Text = "Annuler";
            this.BtnAn.UseVisualStyleBackColor = false;
            this.BtnAn.Visible = false;
            this.BtnAn.Click += new System.EventHandler(this.BtnAn_Click);
            // 
            // BtnCom
            // 
            this.BtnCom.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCom.ForeColor = System.Drawing.Color.Snow;
            this.BtnCom.Location = new System.Drawing.Point(221, 561);
            this.BtnCom.Name = "BtnCom";
            this.BtnCom.Size = new System.Drawing.Size(75, 23);
            this.BtnCom.TabIndex = 24;
            this.BtnCom.Text = "Comfirmer";
            this.BtnCom.UseVisualStyleBackColor = false;
            this.BtnCom.Visible = false;
            this.BtnCom.Click += new System.EventHandler(this.BtnCom_Click);
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.BackColor = System.Drawing.Color.Goldenrod;
            this.TxtBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxNom.Location = new System.Drawing.Point(140, 494);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxNom.TabIndex = 27;
            this.TxtBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxNom.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nouveau nom de la salle:";
            this.label2.Visible = false;
            // 
            // TxtBoxNum
            // 
            this.TxtBoxNum.BackColor = System.Drawing.Color.Goldenrod;
            this.TxtBoxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxNum.Location = new System.Drawing.Point(158, 528);
            this.TxtBoxNum.Name = "TxtBoxNum";
            this.TxtBoxNum.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxNum.TabIndex = 29;
            this.TxtBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxNum.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre de la nouvelle salle:";
            this.label3.Visible = false;
            // 
            // Mode
            // 
            this.Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Mode.Location = new System.Drawing.Point(142, 564);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(10, 10);
            this.Mode.TabIndex = 30;
            this.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mode.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(311, 596);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.TxtBoxNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAn);
            this.Controls.Add(this.BtnCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboSalle);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnSup);
            this.Controls.Add(this.BtnAj);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Salles";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NumV;
        private System.Windows.Forms.ColumnHeader PlaceV;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BtnAj;
        private System.Windows.Forms.Button BtnSup;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.ComboBox CboSalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAn;
        private System.Windows.Forms.Button BtnCom;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Mode;
    }
}