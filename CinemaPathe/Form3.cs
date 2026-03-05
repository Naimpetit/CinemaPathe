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

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
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
            BtnAj.Enabled = false;
            BtnMod.Enabled = false;
            BtnSup.Enabled = false;
            label1.Visible = false;

            BtnAn.Visible = true;
            BtnCom.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            TxtBoxNom.Visible = true;
            TxtBoxNum.Visible = true;
            Mode.Text = "Ajout";
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            BtnAj.Enabled = false;
            BtnMod.Enabled = false;
            BtnSup.Enabled = false;

            BtnAn.Visible = true;
            BtnCom.Visible = true;

            label1.Visible = true;
            CboSalle.Visible = true;
                      
            Mode.Text = "Suppression";
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            BtnAj.Enabled = false;
            BtnMod.Enabled = false;
            BtnSup.Enabled = false;

            BtnAn.Visible = true;
            BtnCom.Visible = true;

            label1.Visible = true;
            CboSalle.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            TxtBoxNom.Visible = true;
            TxtBoxNum.Visible = true;

            Mode.Text = "Modification";
        }

        private void BtnAn_Click(object sender, EventArgs e)
        {
            BtnAj.Enabled = true;
            BtnMod.Enabled = true;
            BtnSup.Enabled = true;

            BtnAn.Visible = false;
            BtnCom.Visible = false;
           
            label1.Visible = false;
            CboSalle.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            TxtBoxNom.Visible = false;
            TxtBoxNum.Visible = false;

            Mode.Text = "";
        }

        private void BtnCom_Click(object sender, EventArgs e)
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
                cmd.CommandText = "insert into salle values(?, ?)";
                cmd.Parameters.AddWithValue("", TxtBoxNom.Text);
                cmd.Parameters.AddWithValue("", Convert.ToInt16(TxtBoxNum.Text));
                cmd.Connection = cnn;
                nb = cmd.ExecuteNonQuery();
                CboSalle.Items.Clear();
                if (nb > 0)
                {
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nosalle, nbplaces from salle";

                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        CboSalle.Items.Add(drr1["nosalle"]);
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nosalle"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["nbplaces"]));
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();
                    }
                    drr1.Close();
                    ; cnn.Close();
                }
                cnn.Close();
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
                cmd.CommandText = "delete from salle where nosalle = ?";
                cmd.Parameters.AddWithValue("", CboSalle.SelectedItem);
                cmd.Connection = cnn;
                nb = cmd.ExecuteNonQuery();
                CboSalle.Items.Clear();
                if (nb > 0)
                {
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nosalle, nbplaces from salle";

                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        CboSalle.Items.Add(drr1["nosalle"]);
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nosalle"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["nbplaces"]));
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();
                    }
                    drr1.Close();
                    ; cnn.Close();
                }
                cnn.Close();
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
                cmd.CommandText = "update salle set nosalle = ?,nbplaces = ?  where nosalle = ?";
                cmd.Parameters.AddWithValue("", TxtBoxNom.Text);
                cmd.Parameters.AddWithValue("", Convert.ToInt16(TxtBoxNum.Text));
                cmd.Parameters.AddWithValue("", CboSalle.SelectedItem.ToString());
                cmd.Connection = cnn;
                nb = cmd.ExecuteNonQuery();
                CboSalle.Items.Clear();
                if (nb > 0)
                {
                    OdbcDataReader drr1;
                    cmd.CommandText = "select nosalle, nbplaces from salle";

                    cmd.Connection = cnn;
                    drr1 = cmd.ExecuteReader();
                    existenreg = drr1.Read();
                    while (existenreg == true)
                    {
                        CboSalle.Items.Add(drr1["nosalle"]);
                        ListViewItem lv1 = new ListViewItem(Convert.ToString(drr1["nosalle"]), 0);
                        lv1.SubItems.Add(Convert.ToString(drr1["nbplaces"]));
                        listView.Items.Add(lv1);
                        existenreg = drr1.Read();
                    }
                    drr1.Close();
                    ; cnn.Close();
                }
                cnn.Close();
            }
        
        }
    }
}
