using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU1Y2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt101.Text = "101";
            txt102.Text = "102";
            txt103.Text = "103";
            txt104.Text = "104";
            txt105.Text = "105";
            txt201.Text = "201";
            txt202.Text = "202";
            txt203.Text = "203";
            txt204.Text = "204";
            txt205.Text = "205";
        }

        private void txt_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txtRoom.Text = txt.Text;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string txtroom = txtRoom.Text;
            if(txtRoom.Text == "101" && txt101.BackColor == Color.Red)
            {
                MessageBox.Show("Room " + txtroom + " is busy", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(txtRoom.Text == "201" && txt201.BackColor == Color.Red)
            {
                MessageBox.Show("Room " + txtroom + " is busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtRoom.Text == "203" && txt203.BackColor == Color.Red)
            {
                MessageBox.Show("Room " + txtroom + " is busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtRoom.Text == "105" && txt105.BackColor == Color.Red)
            {
                MessageBox.Show("Room "+txtroom+" is busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            switch (txtroom)
            {
                case "101":
                    txt101.BackColor = Color.Red;
                    break;
                case "102":
                    txt102.BackColor = Color.Green;
                    break;
                case "103":
                    txt103.BackColor = Color.Green;
                    break;
                case "104":
                    txt104.BackColor = Color.Green;
                    break;
                case "105":
                    txt105.BackColor = Color.Red;
                    break;
                case "201":
                    txt201.BackColor = Color.Red;
                    break;
                case "202":
                    txt202.BackColor = Color.Green;
                    break;
                case "203":
                    txt203.BackColor = Color.Red;
                    break;
                case "204":
                    txt204.BackColor = Color.Green;
                    break;
                case "205":
                    txt205.BackColor = Color.Green;
                    break;
            }

        }
    }
}
