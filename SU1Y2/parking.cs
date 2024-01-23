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
    public partial class parking : Form
    {
        public parking(string user,string pwd)
        {
            InitializeComponent();
            this.user = user;
            this.pwd = pwd;
        }

        int park = 20;
        string[,] a = new string[2, 10];
        string[,] phone = new string[2, 10];
        string user;
        string pwd;

        private void parking_Load(object sender, EventArgs e)
        {
            lbParkcount.Text = park.ToString();
            lblUser.Text += user+pwd;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int f = int.Parse(txtFloor.Text);
            int n = int.Parse(txtParkingNumber.Text);
            --f;
            --n;
            if (a[f,n] != "b")
            {
                if (a[f,n] == "book")
                {
                    if(txtPhone.Text == phone[f, n])
                    {
                        a[f, n] = "b";
                        if (f == 0)
                        {
                            if (n == 0)
                                txt00.BackColor = Color.Red;
                            else if(n == 1)
                                txt01.BackColor = Color.Red;
                        }
                        phone[f, n] = "0";
                        --park;
                        lbParkcount.Text = park.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Phone Number");
                    }
                }
            }
            else
            {
                MessageBox.Show("Car park busy");
            }
            txtPhone.Text = "";
            txtFloor.Text = "";
            txtParkingNumber.Text = "";
            txtFloor.Focus();
        }

        private void txt00_MouseClick(object sender, MouseEventArgs e)
        {
            txtFloor.Text = 1.ToString();
            txtParkingNumber.Text = 1.ToString();
        }

        private void txt01_MouseClick(object sender, MouseEventArgs e)
        {
            txtFloor.Text = 1.ToString();
            txtParkingNumber.Text = 2.ToString();
        }
    }
}
