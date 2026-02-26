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
    public partial class Form4 : Form


    {

        int nof, noproj;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            nof = 0; noproj = 0;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nosalle, dateproj, heureproj, titre, projection.noproj  from film inner join projeter on projeter.nofilm=film.nofilm " +
                "inner join projection on projection.noproj=projeter.noproj group by nosalle, dateproj, heureproj, titre, projection.noproj";


            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
               // MessageBox.Show(Convert.ToString(drr["noproj"]));
                //Console.Write(drr["noproj"]);
                noproj = Convert.ToInt32(drr["noproj"]);
                ListViewItem lv1 = new ListViewItem(Convert.ToString(drr["nosalle"]), 0);
                lv1.SubItems.Add(Convert.ToString(drr["dateproj"]));
                lv1.SubItems.Add(Convert.ToString(drr["heureproj"]));
                lv1.SubItems.Add(Convert.ToString(drr["titre"]));
                listView.Items.Add(lv1);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close(); cnn.Close();

            // Deuxième boucle

            OdbcConnection cnn1 = new OdbcConnection();
            OdbcCommand cmd1 = new OdbcCommand();
            OdbcDataReader drr1;
            Boolean existenreg1;

            cnn1.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn1.Open();
            cmd1.CommandText = "select titre from film";


            cmd1.Connection = cnn1;
            drr1 = cmd1.ExecuteReader();
            existenreg1 = drr1.Read();
            while (existenreg1 == true)
            {

                CboFilms.Items.Add(drr1["titre"]);
                existenreg1 = drr1.Read();
            }
            drr1.Close();
            cnn1.Close(); cnn1.Close();

            // Troisième boucle, le code est dégeulasse.

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
                CboSalle.Items.Add(drr2["nosalle"]);
                existenreg2 = drr2.Read();
            }
            drr2.Close();
            cnn2.Close(); cnn2.Close();
        }

        private void CboFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboFilms.SelectedIndex != -1)
            {
                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                OdbcDataReader drr;
                Boolean existenreg;

                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn.Open();
                cmd.CommandText = "select * from film where titre = ?";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("", CboFilms.SelectedItem);
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                while (existenreg == true)
                {
                    
                    nof = Convert.ToInt32(drr["nofilm"]);
                    TitreTxt.Text = "Titre: " + drr["titre"];
                    DureeTxt.Text = "Durée: " + drr["duree"];
                    ReaTxt.Text = "Réalisateurs: " + drr["realisateurs"];
                    pictureBoxFilm.Image = Image.FromFile(Application.StartupPath + "\\images\\" + drr["imgaffiche"]);
                    InfTxt.Text = "Info du film: " + drr["infofilm"];
                    DescFilm.Text = Convert.ToString(drr["synopsis"]);
                    existenreg = drr.Read();
                }
                drr.Close();
                cnn.Close();
               
            }
        }

        private void BtnAj_Click(object sender, EventArgs e)
        {
            if (CboFilms.SelectedIndex != -1 && CboSalle.SelectedIndex != -1)
            {
                // Boucle Normal
                int nb;
                nb = 0;
                listView.Items.Clear();

                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                Boolean existenreg;

                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn.Open();
                cmd.CommandText = "insert into projection values('', ?,?,?,?,?)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("", "");
                cmd.Parameters.AddWithValue("", nof);
                cmd.Parameters.AddWithValue("", Convert.ToString(CboSalle.SelectedItem));
                cmd.Connection = cnn;

                // Mise a jour de la table "avoirlieu"

                OdbcConnection cnn2 = new OdbcConnection();
                OdbcCommand cmd2 = new OdbcCommand();
              

                cnn2.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn2.Open();
                cmd2.CommandText = "insert into avoirlieu values(?,?)";
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("", noproj + 1);
                cmd2.Parameters.AddWithValue("", Convert.ToString(CboSalle.SelectedItem));
                cmd2.Connection = cnn2;
                cmd2.ExecuteNonQuery();

                // Mise a jour de la table "projeter"

                OdbcConnection cnn3 = new OdbcConnection();
                OdbcCommand cmd3 = new OdbcCommand();

                cnn3.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn3.Open();
                cmd3.CommandText = "insert into projeter values(?,?)";
                cmd3.Parameters.Clear();
                cmd3.Parameters.AddWithValue("", noproj + 1);
                cmd3.Parameters.AddWithValue("", nof);
                cmd3.Connection = cnn3;
                cmd3.ExecuteNonQuery();

                nb = cmd.ExecuteNonQuery();
                if (nb > 0)
                {
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nosalle, dateproj, heureproj, titre from film " +
                    "inner join projeter on projeter.nofilm = film.nofilm inner join projection on projection.noproj=projeter.noproj";

                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nosalle"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["dateproj"]));
                        lv1.SubItems.Add(Convert.ToString(drr1["heureproj"]));
                        lv1.SubItems.Add(Convert.ToString(drr1["titre"]));
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();
                    }
                    drr1.Close();
                    cnn.Close();
                }
                cnn.Close();
            }
        }
    }
}
