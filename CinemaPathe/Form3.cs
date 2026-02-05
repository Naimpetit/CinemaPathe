using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaPathe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nosalle, nbplaces from salle";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                CboSalle.Items.Add(drr["nosalle"]);
                ListViewItem lv1 = new ListViewItem(Convert.ToString(drr["nosalle"]), 0);
                lv1.SubItems.Add(Convert.ToString(drr["nbplaces"]));
                listView.Items.Add(lv1);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close(); cnn.Close();
        }

        private void BtnAj_Click(object sender, EventArgs e)
        {

        }

        private void BtnSup_Click(object sender, EventArgs e)
        {

        }

        private void BtnMod_Click(object sender, EventArgs e)
        {

        }

        private void BtnAn_Click(object sender, EventArgs e)
        {

        }

        private void BtnCom_Click(object sender, EventArgs e)
        {

        }
    }
}
