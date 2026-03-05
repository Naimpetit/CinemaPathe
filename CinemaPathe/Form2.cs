using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CinemaPathe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
                CboGen.Items.Add(drr["libgenre"]);
                ListViewItem lv1 = new ListViewItem(Convert.ToString(drr["nogenre"]), 0); // -- Cette ligne est VRAIMENT important, oublie pas comment sa fonctionne.
                lv1.SubItems.Add(Convert.ToString(drr["libgenre"]));
                listView.Items.Add(lv1);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close(); cnn.Close();
        }

        private void CboGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nogenre, libgenre from genre where libgenre = ?";
            cmd.Parameters.AddWithValue("", CboGen.SelectedItem);
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                TxtNomSel.Text = Convert.ToString(drr["libgenre"]);
                txtNb.Text = Convert.ToString(drr["nogenre"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close(); cnn.Close();
        }
       
        private void BtnCom_Click(object sender, EventArgs e) // -- Fonction principale, le reste sont des magouilles
        {
            if (Mode.Text == "Ajout") 
            {
                int nb;
                nb = 0;

                listView.Items.Clear();

                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                Boolean existenreg;
                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn.Open();
                cmd.CommandText = "insert into genre values('', ?)";
                cmd.Parameters.AddWithValue("", TxtBoxNom.Text);
                cmd.Connection = cnn;
                nb = cmd.ExecuteNonQuery();
                CboGen.Items.Clear();
                if (nb > 0)
                {
                    
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nogenre, libgenre from genre";
                    
                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nogenre"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["libgenre"]));
                        CboGen.Items.Add(drr1["libgenre"]);
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();
                    }
                    drr1.Close();
                   ; cnn.Close();
                }
                cnn.Close();
                Message.Text = "Genre Ajouter.";
                Task.Delay(3000).Wait();
                
                Message.Text = String.Empty;
            }
            if (Mode.Text == "Suppression")
            {
                int nb;
                nb = 0;
                
                listView.Items.Clear();

                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                Boolean existenreg;
                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn.Open();
                cmd.CommandText = "delete from genre where libgenre = ?";
                cmd.Parameters.AddWithValue("", TxtNomSel.Text);
                cmd.Connection = cnn;
                nb = cmd.ExecuteNonQuery();
                CboGen.Items.Clear();
                if (nb > 0)
                {
                    TxtBoxNom.Text = String.Empty;
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nogenre, libgenre from genre";

                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nogenre"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["libgenre"]));
                        CboGen.Items.Add(drr1["libgenre"]);
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();

                    }
                    drr1.Close();
                    ; cnn.Close();
                }
                cnn.Close();
                Message.Text = "Genre supprimer.";
                Task.Delay(3000).Wait();
                Message.Text = String.Empty;
            }
            if (Mode.Text == "Modification")
            {
                int nb;
                nb = 0;

                listView.Items.Clear();

                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                Boolean existenreg;
                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
                cnn.Open();
                cmd.CommandText = "update genre set libgenre= ? where libgenre = ?";
                cmd.Parameters.AddWithValue("", TxtBoxNom.Text);
                cmd.Parameters.AddWithValue("", TxtNomSel.Text);
                
                cmd.Connection = cnn;
                nb = cmd.ExecuteNonQuery();
                CboGen.Items.Clear();
                if (nb > 0)
                {
                    TxtBoxNom.Text = String.Empty;
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nogenre, libgenre from genre";

                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nogenre"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["libgenre"]));
                        CboGen.Items.Add(drr1["libgenre"]);
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();

                    }
                    drr1.Close();
                    ; cnn.Close();
                }
                cnn.Close();
                Message.Text = "Genre modifier.";
                Task.Delay(3000).Wait();
                Message.Text = String.Empty;
            }
            txtNb.Text = String.Empty;
            TxtNomSel.Text = String.Empty;
            CboGen.SelectedIndex = -1; // -- Rénitialise le combo box
            TxtBoxNom.Text = String.Empty;
        }

        private void BtnAj_Click_1(object sender, EventArgs e)
        {
            Mode.Text = "Ajout";
            Mode.BackColor = Color.DarkGreen;
            BtnMod.Visible = false;
            BtnSup.Visible = false;
            BtnAj.Visible = false;
            txtNb.Visible = false;
            Txt2.Visible = false;

            BtnCom.Visible = true;
            BtnAn.Visible = true;
            TxtBoxNom.Visible = true;
            TxtModNom.Visible = true;
        }

        private void BtnAn_Click(object sender, EventArgs e)
        {
            Mode.Text = string.Empty;
            Mode.BackColor = Color.FromArgb(240, 196, 40);
            BtnMod.Visible = true;
            BtnSup.Visible = true;
            BtnAj.Visible = true;
            txtNb.Visible = true;
            Txt2.Visible = true;

            BtnCom.Visible = false;
            BtnAn.Visible = false;
            TxtBoxNom.Visible = false;
            TxtModNom.Visible = false;     
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            Mode.Text = "Suppression";
            Mode.BackColor = Color.DarkRed;
            BtnMod.Visible = false;
            BtnSup.Visible = false;
            BtnAj.Visible = false;
            txtNb.Visible = false;
            Txt2.Visible = false;

            BtnCom.Visible = true;
            BtnAn.Visible = true;
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            Mode.Text = "Modification";
            Mode.BackColor = Color.RoyalBlue;
            BtnMod.Visible = false;
            BtnSup.Visible = false;
            BtnAj.Visible = false;
            txtNb.Visible = false;
            Txt2.Visible = false;

            TxtBoxNom.Visible = true;
            TxtModNom.Visible = true;
            BtnCom.Visible = true;
            BtnAn.Visible = true;
        }

      
    }
}
