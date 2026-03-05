namespace CinemaPathe
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCom = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnSup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CboFilms = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Film,
            this.Salle,
            this.Date,
            this.Projection});
            this.dataGridView1.Location = new System.Drawing.Point(49, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(353, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // Film
            // 
            this.Film.HeaderText = "Film";
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            // 
            // Salle
            // 
            this.Salle.HeaderText = "Salle";
            this.Salle.Name = "Salle";
            this.Salle.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Projection
            // 
            this.Projection.HeaderText = "Projection";
            this.Projection.Name = "Projection";
            this.Projection.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Séléctionnez une date";
            // 
            // BtnCom
            // 
            this.BtnCom.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCom.ForeColor = System.Drawing.Color.Snow;
            this.BtnCom.Location = new System.Drawing.Point(186, 76);
            this.BtnCom.Name = "BtnCom";
            this.BtnCom.Size = new System.Drawing.Size(75, 23);
            this.BtnCom.TabIndex = 9;
            this.BtnCom.Text = "Confirmer";
            this.BtnCom.UseVisualStyleBackColor = false;
            this.BtnCom.Click += new System.EventHandler(this.BtnCom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // BtnSup
            // 
            this.BtnSup.AutoSize = true;
            this.BtnSup.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSup.ForeColor = System.Drawing.Color.Snow;
            this.BtnSup.Location = new System.Drawing.Point(309, 418);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Size = new System.Drawing.Size(114, 23);
            this.BtnSup.TabIndex = 23;
            this.BtnSup.Text = "Supprimer Projection";
            this.BtnSup.UseVisualStyleBackColor = false;
            this.BtnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Selectionner une projection :";
            // 
            // CboFilms
            // 
            this.CboFilms.BackColor = System.Drawing.Color.Goldenrod;
            this.CboFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFilms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboFilms.FormattingEnabled = true;
            this.CboFilms.Location = new System.Drawing.Point(213, 418);
            this.CboFilms.Name = "CboFilms";
            this.CboFilms.Size = new System.Drawing.Size(70, 21);
            this.CboFilms.TabIndex = 33;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(454, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboFilms);
            this.Controls.Add(this.BtnSup);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Modification Projections";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projection;
        private System.Windows.Forms.Button BtnSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboFilms;
    }
}