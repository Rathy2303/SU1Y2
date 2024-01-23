using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SU1Y2
{
    public partial class car_parking : Form
    {
        public car_parking()
        {
            InitializeComponent();
        }
        string parkNum;
        string[,] phonNumber = new string[2, 10];
        bool[,] parking = new bool[2, 10];
        bool[,] booking = new bool[2, 10];
        int countPark = 20;


        private void car_parking_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                parking[0, i] = false;
                parking[1, i] = false;
                booking[0, i] = false;
                booking[1, i] = false;
            }
        }

        private void txt_Click(object sender, EventArgs e)
        {

            TextBox txt = (TextBox)sender;
            parkNum = txt.Tag.ToString();
            if (txt.TabIndex <= 9)
            {
                txtFloor.Text = "1";
            }
            else
            {
                txtFloor.Text = "2";
            }
            txtParkNum.Text = parkNum.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkNum.Text))
                MessageBox.Show("Please Choose Park Number..!");
            else
            {
                int floorNum = int.Parse(txtFloor.Text);
                int num = int.Parse(txtParkNum.Text);
                if (txtFloor.Text == "1")
                {
                    if (booking[0, num - 1] == true)
                    {
                        if (txtPhone.Text == phonNumber[0, num - 1])
                        {
                            switch (num)
                            {
                                case 1:
                                    txtfirst1.BackColor = Color.Red;
                                    break;
                                case 2:
                                    txtfirst2.BackColor = Color.Red;
                                    break;
                                case 3:
                                    txtfirst3.BackColor = Color.Red;
                                    break;
                                case 4:
                                    txtfirst4.BackColor = Color.Red;
                                    break;
                                case 5:
                                    txtfirst5.BackColor = Color.Red;
                                    break;
                                case 6:
                                    txtfirst6.BackColor = Color.Red;
                                    break;
                                case 7:
                                    txtfirst7.BackColor = Color.Red;
                                    break;
                                case 8:
                                    txtfirst8.BackColor = Color.Red;
                                    break;
                                case 9:
                                    txtfirst9.BackColor = Color.Red;
                                    break;
                                case 10:
                                    txtfirst10.BackColor = Color.Red;
                                    break;
                            }
                            countPark--;
                            booking[0, num - 1] = false;
                        }
                        else
                            MessageBox.Show("Incorrect Phone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (parking[0, num - 1] == false)
                        {
                            switch (num)
                            {
                                case 1:
                                    txtfirst1.BackColor = Color.Red;
                                    break;
                                case 2:
                                    txtfirst2.BackColor = Color.Red;
                                    break;
                                case 3:
                                    txtfirst3.BackColor = Color.Red;
                                    break;
                                case 4:
                                    txtfirst4.BackColor = Color.Red;
                                    break;
                                case 5:
                                    txtfirst5.BackColor = Color.Red;
                                    break;
                                case 6:
                                    txtfirst6.BackColor = Color.Red;
                                    break;
                                case 7:
                                    txtfirst7.BackColor = Color.Red;
                                    break;
                                case 8:
                                    txtfirst8.BackColor = Color.Red;
                                    break;
                                case 9:
                                    txtfirst9.BackColor = Color.Red;
                                    break;
                                case 10:
                                    txtfirst10.BackColor = Color.Red;
                                    break;
                            }
                            parking[0, num - 1] = true;
                            countPark--;
                        }
                        else
                            MessageBox.Show("This Parking is Busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }
                else
                {
                    if (booking[1, num - 1] == true)
                    {
                        if (txtPhone.Text == phonNumber[1, num - 1])
                        {
                            switch (num)
                            {
                                case 1:
                                    txtSecond1.BackColor = Color.Red;
                                    break;
                                case 2:
                                    txtSecond2.BackColor = Color.Red;
                                    break;
                                case 3:
                                    txtSecond3.BackColor = Color.Red;
                                    break;
                                case 4:
                                    txtSecond4.BackColor = Color.Red;
                                    break;
                                case 5:
                                    txtSecond5.BackColor = Color.Red;
                                    break;
                                case 6:
                                    txtSecond6.BackColor = Color.Red;
                                    break;
                                case 7:
                                    txtSecond7.BackColor = Color.Red;
                                    break;
                                case 8:
                                    txtSecond8.BackColor = Color.Red;
                                    break;
                                case 9:
                                    txtSecond9.BackColor = Color.Red;
                                    break;
                                case 10:
                                    txtSecond10.BackColor = Color.Red;
                                    break;
                            }
                            countPark--;
                            booking[1, num - 1] = false;
                        }
                        else
                            MessageBox.Show("Incorrect Phone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (parking[1, num - 1] == false)
                        {
                            switch (num)
                            {
                                case 1:
                                    txtSecond1.BackColor = Color.Red;
                                    break;
                                case 2:
                                    txtSecond2.BackColor = Color.Red;
                                    break;
                                case 3:
                                    txtSecond3.BackColor = Color.Red;
                                    break;
                                case 4:
                                    txtSecond4.BackColor = Color.Red;
                                    break;
                                case 5:
                                    txtSecond5.BackColor = Color.Red;
                                    break;
                                case 6:
                                    txtSecond6.BackColor = Color.Red;
                                    break;
                                case 7:
                                    txtSecond7.BackColor = Color.Red;
                                    break;
                                case 8:
                                    txtSecond8.BackColor = Color.Red;
                                    break;
                                case 9:
                                    txtSecond9.BackColor = Color.Red;
                                    break;
                                case 10:
                                    txtSecond10.BackColor = Color.Red;
                                    break;
                            }
                            parking[1, num - 1] = true;
                            countPark--;
                        }
                        else
                            MessageBox.Show("This Parking is Busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
                lbNum.Text = countPark.ToString();
                txtParkNum.Text = "";
                txtFloor.Text = "";
                txtPhone.Text = "";
            }
            

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkNum.Text))
                MessageBox.Show("Please Choose Park Number...!");
            else
            {
                int parkNum = int.Parse(txtParkNum.Text);
                for (int i = parkNum - 1; i < parkNum; i++)
                {
                    if (txtFloor.Text == "1")
                    {

                        if (parking[0, i] == true)
                        {
                            MessageBox.Show("This Parking is Busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(txtPhone.Text))
                            {
                                switch (parkNum)
                                {
                                    case 1:
                                        txtfirst1.BackColor = Color.Green;
                                        break;
                                    case 2:
                                        txtfirst2.BackColor = Color.Green;
                                        break;
                                    case 3:
                                        txtfirst3.BackColor = Color.Green;
                                        break;
                                    case 4:
                                        txtfirst4.BackColor = Color.Green;
                                        break;
                                    case 5:
                                        txtfirst5.BackColor = Color.Green;
                                        break;
                                    case 6:
                                        txtfirst6.BackColor = Color.Green;
                                        break;
                                    case 7:
                                        txtfirst7.BackColor = Color.Green;
                                        break;
                                    case 8:
                                        txtfirst8.BackColor = Color.Green;
                                        break;
                                    case 9:
                                        txtfirst9.BackColor = Color.Green;
                                        break;
                                    case 10:
                                        txtfirst10.BackColor = Color.Green;
                                        break;
                                }
                                booking[0, i] = true;
                                parking[0, i] = true;
                                phonNumber[0, i] = txtPhone.Text;
                            }
                            else
                                MessageBox.Show("Please Enter Phone Number..!");
                            
                        }
                    }
                    else
                    {
                        if (parking[1, i] == true)
                        {
                            MessageBox.Show("This Parking is Busy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            switch (parkNum)
                            {
                                case 1:
                                    txtSecond1.BackColor = Color.Green;
                                    break;
                                case 2:
                                    txtSecond2.BackColor = Color.Green;
                                    break;
                                case 3:
                                    txtSecond3.BackColor = Color.Green;
                                    break;
                                case 4:
                                    txtSecond4.BackColor = Color.Green;
                                    break;
                                case 5:
                                    txtSecond5.BackColor = Color.Green;
                                    break;
                                case 6:
                                    txtSecond6.BackColor = Color.Green;
                                    break;
                                case 7:
                                    txtSecond7.BackColor = Color.Green;
                                    break;
                                case 8:
                                    txtSecond8.BackColor = Color.Green;
                                    break;
                                case 9:
                                    txtSecond9.BackColor = Color.Green;
                                    break;
                                case 10:
                                    txtSecond10.BackColor = Color.Green;
                                    break;
                            }
                            booking[1, i] = true;
                            parking[1, i] = true;
                            phonNumber[1, i] = txtPhone.Text;
                        }
                        
                    }
                }
            }
            txtParkNum.Text = "";
            txtFloor.Text = "";
            txtPhone.Text = "";

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtParkNum.Text))
                MessageBox.Show("Please Choose Park Number...!");
            else
            {
                int num = int.Parse(txtParkNum.Text);
                if (txtFloor.Text == "1")
                {
                    if (booking[0, num - 1] == true)
                    {
                        MessageBox.Show("This Parking is Not Parking", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (parking[0, num - 1] == true)
                        {
                            switch (num)
                            {
                                case 1:
                                    txtfirst1.BackColor = Color.White;
                                    break;
                                case 2:
                                    txtfirst2.BackColor = Color.White;
                                    break;
                                case 3:
                                    txtfirst3.BackColor = Color.White;
                                    break;
                                case 4:
                                    txtfirst4.BackColor = Color.White;
                                    break;
                                case 5:
                                    txtfirst5.BackColor = Color.White;
                                    break;
                                case 6:
                                    txtfirst6.BackColor = Color.White;
                                    break;
                                case 7:
                                    txtfirst7.BackColor = Color.White;
                                    break;
                                case 8:
                                    txtfirst8.BackColor = Color.White;
                                    break;
                                case 9:
                                    txtfirst9.BackColor = Color.White;
                                    break;
                                case 10:
                                    txtfirst10.BackColor = Color.White;
                                    break;
                            }
                            countPark++;
                            parking[0, num - 1] = false;
                        }

                    }
                }
                else if (txtFloor.Text == "2")
                {
                    if (booking[1, num - 1] == true)
                    {
                        MessageBox.Show("This Parking is Not Parking", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (parking[1, num - 1] == true)
                        {
                            switch (num)
                            {
                                case 1:
                                    txtSecond1.BackColor = Color.White;
                                    break;
                                case 2:
                                    txtSecond2.BackColor = Color.White;
                                    break;
                                case 3:
                                    txtSecond3.BackColor = Color.White;
                                    break;
                                case 4:
                                    txtSecond4.BackColor = Color.White;
                                    break;
                                case 5:
                                    txtSecond5.BackColor = Color.White;
                                    break;
                                case 6:
                                    txtSecond6.BackColor = Color.White;
                                    break;
                                case 7:
                                    txtSecond7.BackColor = Color.White;
                                    break;
                                case 8:
                                    txtSecond8.BackColor = Color.White;
                                    break;
                                case 9:
                                    txtSecond9.BackColor = Color.White;
                                    break;
                                case 10:
                                    txtSecond10.BackColor = Color.White;
                                    break;
                            }
                            parking[1, num - 1] = false;
                            countPark++;
                        }

                    }
                }
                lbNum.Text = countPark.ToString();
                txtFloor.Text = "";
                txtParkNum.Text = "";
            }
            
        }


      
    }

}
