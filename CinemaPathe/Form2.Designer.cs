namespace CinemaPathe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CboGen = new System.Windows.Forms.ComboBox();
            this.Txt1 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.Label();
            this.BtnSup = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnAj = new System.Windows.Forms.Button();
            this.txtNb = new System.Windows.Forms.Label();
            this.BtnCom = new System.Windows.Forms.Button();
            this.BtnAn = new System.Windows.Forms.Button();
            this.TxtModNom = new System.Windows.Forms.Label();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.TxtSel = new System.Windows.Forms.Label();
            this.TxtNomSel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.NumV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mode = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboGen
            // 
            this.CboGen.BackColor = System.Drawing.Color.Goldenrod;
            this.CboGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboGen.FormattingEnabled = true;
            this.CboGen.Location = new System.Drawing.Point(124, 168);
            this.CboGen.Name = "CboGen";
            this.CboGen.Size = new System.Drawing.Size(121, 21);
            this.CboGen.TabIndex = 1;
            this.CboGen.SelectedIndexChanged += new System.EventHandler(this.CboGen_SelectedIndexChanged);
            // 
            // Txt1
            // 
            this.Txt1.AutoSize = true;
            this.Txt1.Location = new System.Drawing.Point(4, 171);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(114, 13);
            this.Txt1.TabIndex = 2;
            this.Txt1.Text = "Selectionner un genre:";
            // 
            // Txt2
            // 
            this.Txt2.AutoSize = true;
            this.Txt2.Location = new System.Drawing.Point(12, 243);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(92, 13);
            this.Txt2.TabIndex = 3;
            this.Txt2.Text = "Numéro du genre:";
            // 
            // BtnSup
            // 
            this.BtnSup.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSup.ForeColor = System.Drawing.Color.Snow;
            this.BtnSup.Location = new System.Drawing.Point(8, 294);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Size = new System.Drawing.Size(75, 23);
            this.BtnSup.TabIndex = 4;
            this.BtnSup.Text = "Supprimer";
            this.BtnSup.UseVisualStyleBackColor = false;
            this.BtnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMod.ForeColor = System.Drawing.Color.Snow;
            this.BtnMod.Location = new System.Drawing.Point(89, 294);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(75, 23);
            this.BtnMod.TabIndex = 5;
            this.BtnMod.Text = "Modifier";
            this.BtnMod.UseVisualStyleBackColor = false;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // BtnAj
            // 
            this.BtnAj.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAj.ForeColor = System.Drawing.Color.Snow;
            this.BtnAj.Location = new System.Drawing.Point(174, 294);
            this.BtnAj.Name = "BtnAj";
            this.BtnAj.Size = new System.Drawing.Size(75, 23);
            this.BtnAj.TabIndex = 6;
            this.BtnAj.Text = "Ajouter";
            this.BtnAj.UseVisualStyleBackColor = false;
            this.BtnAj.Click += new System.EventHandler(this.BtnAj_Click_1);
            // 
            // txtNb
            // 
            this.txtNb.BackColor = System.Drawing.Color.Goldenrod;
            this.txtNb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNb.Location = new System.Drawing.Point(110, 242);
            this.txtNb.Name = "txtNb";
            this.txtNb.Size = new System.Drawing.Size(92, 13);
            this.txtNb.TabIndex = 7;
            this.txtNb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnCom
            // 
            this.BtnCom.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCom.ForeColor = System.Drawing.Color.Snow;
            this.BtnCom.Location = new System.Drawing.Point(174, 294);
            this.BtnCom.Name = "BtnCom";
            this.BtnCom.Size = new System.Drawing.Size(75, 23);
            this.BtnCom.TabIndex = 8;
            this.BtnCom.Text = "Comfirmer";
            this.BtnCom.UseVisualStyleBackColor = false;
            this.BtnCom.Visible = false;
            this.BtnCom.Click += new System.EventHandler(this.BtnCom_Click);
            // 
            // BtnAn
            // 
            this.BtnAn.BackColor = System.Drawing.Color.DarkRed;
            this.BtnAn.ForeColor = System.Drawing.Color.Snow;
            this.BtnAn.Location = new System.Drawing.Point(8, 294);
            this.BtnAn.Name = "BtnAn";
            this.BtnAn.Size = new System.Drawing.Size(75, 23);
            this.BtnAn.TabIndex = 9;
            this.BtnAn.Text = "Annuler";
            this.BtnAn.UseVisualStyleBackColor = false;
            this.BtnAn.Visible = false;
            this.BtnAn.Click += new System.EventHandler(this.BtnAn_Click);
            // 
            // TxtModNom
            // 
            this.TxtModNom.AutoSize = true;
            this.TxtModNom.Location = new System.Drawing.Point(12, 243);
            this.TxtModNom.Name = "TxtModNom";
            this.TxtModNom.Size = new System.Drawing.Size(122, 13);
            this.TxtModNom.TabIndex = 11;
            this.TxtModNom.Text = "Nouveau nom du genre:";
            this.TxtModNom.Visible = false;
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.BackColor = System.Drawing.Color.Goldenrod;
            this.TxtBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxNom.Location = new System.Drawing.Point(140, 241);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxNom.TabIndex = 13;
            this.TxtBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxNom.Visible = false;
            // 
            // TxtSel
            // 
            this.TxtSel.AutoSize = true;
            this.TxtSel.Location = new System.Drawing.Point(12, 219);
            this.TxtSel.Name = "TxtSel";
            this.TxtSel.Size = new System.Drawing.Size(96, 13);
            this.TxtSel.TabIndex = 14;
            this.TxtSel.Text = "Genre séléctionné:";
            // 
            // TxtNomSel
            // 
            this.TxtNomSel.BackColor = System.Drawing.Color.Goldenrod;
            this.TxtNomSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNomSel.Location = new System.Drawing.Point(114, 218);
            this.TxtNomSel.Name = "TxtNomSel";
            this.TxtNomSel.Size = new System.Drawing.Size(92, 13);
            this.TxtNomSel.TabIndex = 15;
            this.TxtNomSel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.BackColor = System.Drawing.Color.Goldenrod;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumV,
            this.GenreV});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(242, 150);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // NumV
            // 
            this.NumV.Text = "Numéro Genre";
            this.NumV.Width = 90;
            // 
            // GenreV
            // 
            this.GenreV.Text = "Genre";
            this.GenreV.Width = 150;
            // 
            // Mode
            // 
            this.Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Mode.Location = new System.Drawing.Point(56, 264);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(150, 27);
            this.Mode.TabIndex = 17;
            this.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Message
            // 
            this.Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.Message.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(52, 192);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(150, 23);
            this.Message.TabIndex = 18;
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(255, 323);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.TxtNomSel);
            this.Controls.Add(this.TxtSel);
            this.Controls.Add(this.TxtBoxNom);
            this.Controls.Add(this.TxtModNom);
            this.Controls.Add(this.BtnAn);
            this.Controls.Add(this.BtnCom);
            this.Controls.Add(this.txtNb);
            this.Controls.Add(this.BtnAj);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnSup);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.CboGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Genres";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CboGen;
        private System.Windows.Forms.Label Txt1;
        private System.Windows.Forms.Label Txt2;
        private System.Windows.Forms.Button BtnSup;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnAj;
        private System.Windows.Forms.Label txtNb;
        private System.Windows.Forms.Button BtnCom;
        private System.Windows.Forms.Button BtnAn;
        private System.Windows.Forms.Label TxtModNom;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.Label TxtSel;
        private System.Windows.Forms.Label TxtNomSel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NumV;
        private System.Windows.Forms.ColumnHeader GenreV;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label Message;
    }
}