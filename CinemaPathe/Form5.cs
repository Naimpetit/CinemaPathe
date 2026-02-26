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

namespace CinemaPathe
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nosalle, dateproj, heureproj, titre from film " +
                    "inner join projeter on projeter.nofilm = film.nofilm inner join projection on projection.noproj=projeter.noproj" + 
                    "where dateproj = ?";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("", dateTimePicker1.Value); //2026-01-22
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                dataGridView1.Rows.Add(Convert.ToString(drr["titre"]), Convert.ToString(drr["nosalle"]), Convert.ToString(drr["dateproj"]));
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

        }
    }
}
