using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.Odbc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaPathe
{
    public partial class Form1 : Form
    {
        public int s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SoundPlayer BootUpSound = new SoundPlayer(Properties.Resources.startup);
            BootUpSound.Play();

           

            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
           
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nogenre, libgenre from genre";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
               ListViewItem lv1 = new ListViewItem(Convert.ToString(drr["nogenre"]), 0);
               lv1.SubItems.Add(Convert.ToString(drr["libgenre"]));         
               listView1.Items.Add(lv1);
               existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close(); cnn.Close();

            OdbcConnection cnn2 = new OdbcConnection();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader drr2;
            Boolean existenreg2;

            cnn2.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn2.Open();
            cmd2.CommandText = "select nosalle, nbplaces from salle";
            cmd2.Connection = cnn2;
            drr2 = cmd2.ExecuteReader();
            existenreg2 = drr2.Read();
            while (existenreg2 == true)
            {
                ListViewItem lv1 = new ListViewItem(Convert.ToString(drr2["nosalle"]), 0);
                lv1.SubItems.Add(Convert.ToString(drr2["nbplaces"]));
                listView2.Items.Add(lv1);
                existenreg2 = drr2.Read();
            }
            drr2.Close();
            cnn2.Close(); cnn2.Close();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
           
            new Form2().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = +s;
            s++;
            if (progressBar1.Value == 1)
            {
                timer1.Stop();
                //Task.Delay(3000).Wait();
                btnGenre.Visible = true;
                listView1.Visible = true;
                BtnSalle.Visible = true;
                BtnPr.Visible = true;
                listView2.Visible = true;
                progressBar1.Visible = false;
                LogoMid.Visible = false;
                TitleStart.Visible = false;
            }
        }

        private void BtnSalle_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void BtnPr_Click(object sender, EventArgs e)
        {
            new Option_Projection().Show();
        }

        private void btform7_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void btpdf_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }
    }
}
