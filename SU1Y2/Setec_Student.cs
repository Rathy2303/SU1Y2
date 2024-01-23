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
    public partial class Setec_Student : Form
    {
        public Setec_Student()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtGroup.Text) && cmbLevel.SelectedIndex >= 0 && cmbMajor.SelectedIndex>=0)
            {
                string name = txtName.Text.ToUpper();
                string sex = cmbSex.SelectedItem.ToString();
                string major = cmbMajor.SelectedItem.ToString();
                string group = txtGroup.Text.ToUpper();
                string level = cmbLevel.SelectedItem.ToString();
                if (level.Equals("Bachelor"))
                {
                    if (major.Equals("MIS"))
                    {
                        if (group.Substring(0, 1).ToUpper().Equals("S"))
                        {
                            int n;
                            bool isNum = int.TryParse(group.Substring(2, 1), out n);
                            if (isNum == true)
                            {
                                if (txtName.Text.Length >= 10)
                                    txtTable.Text += name + "\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                                else
                                    txtTable.Text += name + "\t\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                            }
                            else
                                MessageBox.Show("Unknow Group");
                        }
                        else
                            MessageBox.Show("Unknow Group");
                    }
                    else if (major.Equals("Design"))
                    {
                        if (group.Substring(0, 1).ToUpper().Equals("D"))
                        {
                            int n;
                            bool isNum = int.TryParse(group.Substring(2, 1), out n);
                            if (isNum == true)
                            {
                                if (txtName.Text.Length >= 10)
                                    txtTable.Text += name + "\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                                else
                                    txtTable.Text += name + "\t\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                            }
                            else
                                MessageBox.Show("Unknow Group");
                        }
                        else
                            MessageBox.Show("Unknow Group");
                    }
                    else if (major.Equals("BIT"))
                    {

                        if (group.Substring(0, 2).ToUpper().Equals("SB"))
                        {
                            if (group.Length > 3)
                            {
                                int n;
                                bool isNum = int.TryParse(group.Substring(3, 1), out n);
                                if (isNum == true)
                                {
                                    if (txtName.Text.Length >= 10)
                                        txtTable.Text += name + "\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                                    else
                                        txtTable.Text += name + "\t\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                                }
                                else
                                    MessageBox.Show("Unknow Group");
                            }
                            else
                                MessageBox.Show("Unknow Group");


                        }
                        else
                            MessageBox.Show("Unknow Group");
                    }
                }
                else
                {
                    if (major.Equals("MIS"))
                    {
                        if (group.Substring(0, 2).ToUpper().Equals("AS"))
                        {
                            int n;
                            bool isNum = int.TryParse(group.Substring(2, 1), out n);
                            if (isNum != true)
                            {
                                if (txtName.Text.Length >= 10)
                                    txtTable.Text += name + "\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                                else
                                    txtTable.Text += name + "\t\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                            }
                            else
                                MessageBox.Show("Unknow Group");
                        }
                        else
                            MessageBox.Show("Unknow Group");
                    }
                    else
                    {

                        if (group.Substring(0, 2).ToUpper().Equals("AD"))
                        {
                            int n;
                            bool isNum = int.TryParse(group.Substring(2, 1), out n);
                            if (isNum != true)
                            {
                                if (txtName.Text.Length >= 10)
                                    txtTable.Text += name + "\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                                else
                                    txtTable.Text += name + "\t\t" + sex + "\t" + level + "\t" + major + "\t" + group + "\r\n";
                            }
                            else
                                MessageBox.Show("Unknow Group");
                        }
                        else
                            MessageBox.Show("Unknow Group");
                    }
                }
                txtName.Text = null;
                txtName.Focus();
                txtGroup.Text = null;
                cmbSex.SelectedIndex = 0;
                cmbLevel.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Please Fill All Fields");       
        }
        private void cmbLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbLevel.SelectedIndex == 0)
            {
                cmbMajor.Items.Clear();
                cmbMajor.Items.Add("MIS");
                cmbMajor.Items.Add("Design");
                cmbMajor.Items.Add("BIT");
            }
            else
            {
                cmbMajor.Items.Clear();
                cmbMajor.Items.Add("MIS");
                cmbMajor.Items.Add("Design");
            }
        }
        private void Setec_Student_Load(object sender, EventArgs e)
        {
            
            txtTable.Text = "Name\t\tSex\tLevel\tMajor\tGroup\r\n";
            cmbSex.SelectedIndex = 0;
        }
    }
}
