namespace CinemaPathe
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btpdf = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btpdf
            // 
            this.btpdf.Location = new System.Drawing.Point(187, 152);
            this.btpdf.Name = "btpdf";
            this.btpdf.Size = new System.Drawing.Size(75, 23);
            this.btpdf.TabIndex = 1;
            this.btpdf.Text = "Génerer pdf";
            this.btpdf.UseVisualStyleBackColor = true;
            this.btpdf.Click += new System.EventHandler(this.btpdf_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2026, 1, 22, 11, 38, 0, 0);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(482, 262);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btpdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "PDF";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btpdf;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}