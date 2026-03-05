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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            bool trouve = false;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
           
            cmd.CommandText = "select nosalle, dateproj, heureproj, titre, projection.noproj from film " +
                    "inner join projeter on projeter.nofilm = film.nofilm inner join projection on projection.noproj=projeter.noproj";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            dataGridView1.Rows.Clear();
            while (existenreg == true)
            {
                if (Convert.ToDateTime(drr["dateproj"]).Day == dateTimePicker1.Value.Day && Convert.ToDateTime(drr["dateproj"]).Month == dateTimePicker1.Value.Month) 
                {
                    
                    DateTime dateProj = Convert.ToDateTime(drr["dateproj"]);
                    TimeSpan Heure = (TimeSpan)drr["heureproj"];              
                    trouve = true;
                    CboFilms.Items.Add(Convert.ToString(drr["noproj"]));
                    dataGridView1.Rows.Add(Convert.ToString(drr["titre"]), Convert.ToString(drr["nosalle"]), dateProj.ToString("dd/MM/yyyy") + " " + Heure.ToString(@"h\:mm"), Convert.ToString(drr["noproj"])); 
                }
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
            Task.Delay(100).Wait();
            if (trouve == false)
            {
                dataGridView1.Rows.Add("Aucun film trouvé.");
                this.Size = new Size(474, 456);
            }
            else
            {
                if (this.Size.Height < 457)
                {
                    int i;
                    double HeightSize = 456;
                    for (i = 1; i < 75; i++)
                    {
                        HeightSize = HeightSize + 0.63125;
                        this.Size = new Size(474, Convert.ToInt32(HeightSize));
                        Task.Delay(1).Wait();
                    }
                }
            }
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            int nb;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "delete from projection where noproj = ?";
            cmd.Parameters.AddWithValue("", CboFilms.SelectedItem.ToString());
            cmd.Connection = cnn;
            nb = cmd.ExecuteNonQuery();
           
            if (nb > 0)
            {
                BtnCom_Click(sender, e);               
            }
            cnn.Close();

            int nb2;
            OdbcConnection cnn2 = new OdbcConnection();
            OdbcCommand cmd2 = new OdbcCommand();
            cnn2.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn2.Open();
            cmd2.CommandText = "delete from projeter where noproj = ?";
            cmd2.Parameters.AddWithValue("", CboFilms.SelectedItem.ToString());
            cmd2.Connection = cnn2;
            nb2 = cmd2.ExecuteNonQuery();

            if (nb2 > 0)
            {
                MessageBox.Show("Selection bien supprimer");
            }
            cnn2.Close();

        }
    }
}
