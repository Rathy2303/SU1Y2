using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SU1Y2
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            txtInformation.Text = "Name\t\tSex\tMajor\tGen\tShift\r\n";
            txtSex.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtGroup.Text) && txtSex.SelectedItem != null)
            {
                string name = txtName.Text;
                string sex = txtSex.SelectedItem.ToString();
                string group = txtGroup.Text;
                string shift = "";
                int groupnum = 0;
                int promotion = 0;
                string major = "";
                char letter;

                if (group.Substring(0, 2) == "SB" || group.Substring(0, 2) == "sb")
                {
                    int n;
                    bool isNumeric = int.TryParse(group.Substring(2),out n);
                    if (isNumeric != true)
                    {
                            groupnum = int.Parse(group.Substring(group.Length-1));
                            letter = char.Parse(group.Substring(2, 1));
                            promotion = char.ToUpper(letter) - 64;
                            if (groupnum == 0 || groupnum == 5)
                                shift = "Evening";
                            else if (groupnum <= 2 || groupnum > 5)
                                shift = "Morning";
                            else if (groupnum <= 4)
                                shift = "Afternoon";
                            major = "BIT";
                    }
                    else
                    {
                        if (isNumeric != true)
                            MessageBox.Show("Unknow Group. Please Enter Again");
                        else
                        {
                            groupnum = int.Parse(group.Substring(group.Length - 1));
                            letter = char.Parse(group.Substring(1, 1));
                            promotion = char.ToUpper(letter) - 64;
                            if (groupnum == 0 || groupnum == 5)
                                shift = "Evening";
                            else if (groupnum <= 2 || groupnum > 5)
                                shift = "Morning";
                            else if (groupnum <= 4)
                                shift = "Afternoon";
                            major = "MIS";
                        }
                    }

                }
                else if (group.Substring(0, 1) == "S" || group.Substring(0, 1) == "s")
                {
                    int n;
                    bool isNumeric = int.TryParse(group.Substring(2), out n);
                    if (isNumeric != true)
                        MessageBox.Show("Unknow Group. Please Enter Again");
                    else
                    {
                        groupnum = int.Parse(group.Substring(group.Length - 1));
                        letter = char.Parse(group.Substring(1, 1));
                        promotion = char.ToUpper(letter) - 64;
                        if (groupnum == 0 || groupnum == 5)
                            shift = "Evening";
                        else if (groupnum <= 2 || groupnum > 5)
                            shift = "Morning";
                        else if (groupnum <= 4)
                            shift = "Afternoon";
                        major = "MIS";
                    }
                    
                }
                else if (group.Substring(0, 1) == "D" || group.Substring(0, 1) == "d")
                {
                    int n;
                    bool isNumeric = int.TryParse(group.Substring(2), out n);
                    if (isNumeric != true)
                        MessageBox.Show("Unknow Group. Please Enter Again");
                    else
                    {
                        groupnum = int.Parse(group.Substring(group.Length - 1));
                        letter = char.Parse(group.Substring(1, 1));
                        promotion = char.ToUpper(letter) - 64;
                        if (groupnum == 0 || groupnum == 5)
                            shift = "Evening";
                        else if (groupnum <= 2 || groupnum > 5)
                            shift = "Morning";
                        else if (groupnum <= 4)
                            shift = "Afternoon";
                        major = "DESIGN";
                    }
                    
                }
                else
                {
                    MessageBox.Show("Unknow Group. Please Enter Again");
                    txtGroup.Text = "";
                    txtGroup.Focus();
                }
                if (major != "")
                {
                    if (name.Length < 12)
                        txtInformation.Text += name + "\t\t" + sex + "\t" + major + "\t" + promotion + "\t" + shift + "\r\n";
                    else
                        txtInformation.Text += name + "\t" + sex + "\t" + major + "\t" + promotion + "\t" + shift + "\r\n";
                    txtName.Text = "";
                    txtGroup.Text = "";
                    txtSex.SelectedIndex = 0;
                    txtName.Focus();

                }
                    
            }
            else
                MessageBox.Show("Please Fill all Field..!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
