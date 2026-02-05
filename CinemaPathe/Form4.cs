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
        public Form4()
        {
            InitializeComponent();
        }

        List<int> lespublics = new List<int>();
        List<int> lesgenres = new List<int>();

        private void Form4_Load_1(object sender, EventArgs e)
        {
            listboxgenres.SelectionMode = SelectionMode.MultiSimple;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader drr,drr2;
            Boolean existenreg, existenreg2;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select libgenre,nogenre from genre";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                listboxgenres.Items.Add(drr["libgenre"]);
                lesgenres.Add(Convert.ToInt32(drr["nogenre"]));
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();


            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select libpublic,nopublic from public";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                Cbopublic.Items.Add(drr["libpublic"]);
                lespublics.Add(Convert.ToInt32(drr["nopublic"]));
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();


            listView.Items.Clear();
            //test
            //(algorithme avec 2 boucles imbriquées) :
            //faire une requête simple pour récupérer les film.
            //A chaque film affiché, écrire une 2ème requête imbriquée qui récupère ses genres et qui les affiche dans une colonne.
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select titre, libpublic, nofilm from film f inner join public p on f.nopublic=p.nopublic ";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {

                ListViewItem lv1 = new ListViewItem(Convert.ToString(drr["titre"]), 0); // -- Cette ligne est VRAIMENT important, oublie pas comment sa fonctionne.
                lv1.SubItems.Add(Convert.ToString(drr["libpublic"]));
                listView.Items.Add(lv1);

                //A chaque film affiché, écrire une 2ème requête imbriquée qui récupère SES genres et qui les affiche dans une colonne.
                string affgenres = "";

                cmd2.CommandText = "select libgenre from genre g inner join concerner c on g.nogenre=c.nogenre where nofilm=?";
                cmd2.Parameters.AddWithValue("", drr["nofilm"]);

                cmd2.Connection = cnn;
                drr2 = cmd2.ExecuteReader();
                existenreg2 = drr2.Read();

                while (existenreg2 == true)
                {
                    affgenres += drr2["libgenre"] + " ";

                    //Lecture du genre suivant
                    existenreg2 = drr2.Read();
                    cmd2.Parameters.Clear();
                }
                lv1.SubItems.Add(affgenres);
                drr2.Close();
                //Lecture du film suivant
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
        }

        private void BtnAj_Click(object sender, EventArgs e)
        {
            Mode.Text = "Ajout";
            Mode.BackColor = Color.DarkGreen;
            BtnAj.Visible = false;


            lblpublic.Visible = true;
            Cbopublic.Visible = true;

            lblgenre.Visible = true;
            listboxgenres.Visible = true;

            lblfilm.Visible = true;
            TxtBoxFilm.Visible = true;

            BtnCom.Visible = true;
            BtnAn.Visible = true;


        }

        private void BtnAn_Click_1(object sender, EventArgs e)
        {
            Mode.Text = string.Empty;
            Mode.BackColor = Color.FromArgb(240, 196, 40);
            lblpublic.Visible = false;
            Cbopublic.Visible = false;

            lblgenre.Visible = false;
            listboxgenres.Visible = false;

            lblfilm.Visible = false;
            TxtBoxFilm.Visible = false;

            BtnCom.Visible = false;
            BtnAn.Visible = false;


            BtnAj.Visible = true;

        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "insert into film values('',?,'','','','','','',?)";
            cmd.Parameters.AddWithValue("", TxtBoxFilm.Text);
            cmd.Parameters.AddWithValue("", lespublics[Cbopublic.SelectedIndex]);
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();  
            existenreg = drr.Read();
            drr.Close();
            cnn.Close();


            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcineDESOUSAMARTINS;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select max(nofilm) from film";
            cmd.Connection = cnn;
            int noderfilm = Convert.ToInt32(cmd.ExecuteScalar());

            for (int i = 0; i < listboxgenres.Items.Count; i++)
            {
                if (listboxgenres.GetSelected(i) == true)
                {
                    cmd2.Parameters.Clear();
                    cmd2.CommandText = "insert into concerner (nofilm , nogenre) values ( ? ,?)";
                    cmd2.Parameters.AddWithValue("", noderfilm);
                    cmd2.Parameters.AddWithValue("", lesgenres[i]); 
                    cmd2.Connection = cnn;
                    cmd2.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Film " + TxtBoxFilm.Text + " a été ajouté");
            Form4_Load_1(sender, e);

            drr.Close();
            cnn.Close();

        }

    }
}
