using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SU1Y2
{
    public partial class String_txt : Form
    {
        public String_txt()
        {
            InitializeComponent();
            
        }

        private void btntoupper_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrWhiteSpace(input))
                MessageBox.Show("Field Cannot be null..!");
            else
            {
                if (btntoupper.Text == "==>")
                {
                    txttoupper.Text = input.ToUpper();
                    txttoupper.BackColor = Color.Red;
                    btntoupper.Text = "<==";
                }
                else
                {

                    txttoupper.Text = "ToUpper";
                    txttoupper.BackColor = Color.White;
                    btntoupper.Text = "==>";
                }
            }
            
        }

        private void btntolower_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrWhiteSpace(input))
                MessageBox.Show("Field Cannot be null..!");
            else
            {
                if (btntolower.Text == "==>")
                {
                    txttolower.Text = input.ToLower();
                    txttolower.BackColor = Color.Red;
                    btntolower.Text = "<==";
                }
                else
                {

                    txttolower.Text = "ToLower";
                    txttolower.BackColor = Color.White;
                    btntolower.Text = "==>";
                }
            }
                
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtInput.Text)) {
                string input = txtInput.Text;
                txtInput.Text = input.Substring(0, input.Length - 1);
            }
            else
                MessageBox.Show("Field Cannot be null..!");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                string input = txtInput.Text;
                if (cmbinput.Items.Contains(input.ToUpper()) || cmbinput.Items.Contains(input.ToLower()) || cmbinput.Items.Contains(input))
                {
                    MessageBox.Show("Exists");
                }
                else
                {
                    cmbinput.Items.Add(input);
                    txtInput.Text = "";
                }
            }
            else
                MessageBox.Show("Field Cannot be null..!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(cmbinput.SelectedIndex >= 0)
            {
                int ind = int.Parse(cmbinput.SelectedIndex.ToString());
                string value = cmbinput.SelectedItem.ToString();
                string input = Interaction.InputBox("Please Input Value","",value);
                cmbinput.Items[ind] = input;

            }
            else
                MessageBox.Show("Please Select Value to Edit..!");
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(cmbinput.SelectedIndex >= 0)
            {
                int ind = cmbinput.SelectedIndex;
                cmbinput.Items.RemoveAt(ind);
                MessageBox.Show("Remove Successfull...!");
            }
            else
                MessageBox.Show("Please Select Value to Remove..!");
        }

        private void String_txt_Load(object sender, EventArgs e)
        {




































        }
    }
}