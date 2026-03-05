using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPathe
{
    public partial class Option_Projection : Form
    {
        Form4 Formulaire;
        Form5 Formulaire2;
        bool Form1Vis = false;
        bool Form2Vis = false;
        
        public Option_Projection()
        {
            InitializeComponent();
        }

        private void Option_Projection_Load(object sender, EventArgs e)
        {
            Formulaire2 = null;
            Form1Vis = true;
            checkBox1.Checked = true;   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (Form2Vis == true) { Formulaire2.Close(); }       
                Formulaire = new Form4();
                Formulaire.Show();
                checkBox2.Checked = false;
                Form1Vis = true;
                Form2Vis = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (Form1Vis == true) { Formulaire.Close(); }
                Formulaire2 = new Form5();
                Formulaire2.Show();
                checkBox1.Checked = false;
                Form1Vis = false;
                Form2Vis = true;
            }
        }
    }
}
