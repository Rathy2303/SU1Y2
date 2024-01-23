using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SU1Y2
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            txtID.Text = stdId.ToString();
        }
        List<Image> imgList = new List<Image>();
        int stdId = 1;
        bool addImage = false;
        List<int> storeID = new List<int>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
    
                string id = txtID.Text;
                string name = txtName.Text.ToUpper();
                string gender = "";
                if (rdMale.Checked)
                    gender = "Male";
                else
                    gender = "Female";
                string address = txtAddress.Text.ToUpper();
                string phone = txtPhone.Text;
               
               
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(gender) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(phone) && cmbMajor.SelectedIndex > -1)
            {
                if (addImage == false)
                    MessageBox.Show("Please Choose Image");
                else
                {
                    if (storeID.Contains(int.Parse(id))){
                        MessageBox.Show("Exist ID");
                    }
                    else
                    {
                        imageList1.Images.Add(pic1.Image);
                        string major = cmbMajor.SelectedItem.ToString();
                        string[] row = { "", id, name, gender, address, phone, major };
                        ListViewItem item = new ListViewItem(row);
                        Image img = pic1.Image;
                        imgList.Add(img);
                        item.ImageIndex = imageList1.Images.Count - 1;
                        listviewStudent.Items.Add(item);
                        stdId++;
                        txtID.Text = stdId.ToString();
                        txtName.Text = null;
                        txtName.Focus();
                        txtAddress.Text = null;
                        txtPhone.Text = null;
                        cmbMajor.SelectedIndex = -1;
                        rdMale.Checked = false;
                        rdFemale.Checked = false;
                        pic1.Image = SU1Y2.Properties.Resources.noimage;
                        addImage = false;
                        storeID.Add(int.Parse(id));
                    }
                }
            }


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listviewStudent.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are You Sure To Delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = listviewStudent.SelectedItems[0].Index;
                    listviewStudent.SelectedItems[0].Remove();
                    imgList.RemoveAt(index);
                } 
            }
            else
            {
                MessageBox.Show("Please Select Item to Delete");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listviewStudent.SelectedItems.Count > 0)
            {
                int index = listviewStudent.SelectedItems[0].Index;
                if (btnEdit.Text == "Edit")
                {
                    pic1.Image = imgList[index];
                    txtID.Text = listviewStudent.SelectedItems[0].SubItems[1].Text;
                    txtName.Text = listviewStudent.SelectedItems[0].SubItems[2].Text;
                    txtAddress.Text = listviewStudent.SelectedItems[0].SubItems[4].Text;
                    txtPhone.Text = listviewStudent.SelectedItems[0].SubItems[5].Text;
                    cmbMajor.SelectedItem = listviewStudent.SelectedItems[0].SubItems[6].Text;
                    bool check = listviewStudent.SelectedItems[0].SubItems[3].Text == "Male" ? rdMale.Checked = true : rdFemale.Checked = true;
                    btnEdit.Text = "Update";
                }
                else
                {
                    string id = txtID.Text;
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone =  txtPhone.Text;
                    string gender = rdMale.Checked == true ? "Male" : "Female";
                    string major = cmbMajor.SelectedItem.ToString();
                    string[] row = { "", id, name, gender, address, phone, major };
                    ListViewItem item = new ListViewItem(row);
                    imageList1.Images.Add(pic1.Image);
                    Image img = pic1.Image;
                    imgList.RemoveAt(index);
                    imgList.Insert(index, img);
                    item.ImageIndex = imageList1.Images.Count - 1;
                    listviewStudent.Items.Insert(index,item);
                    listviewStudent.Items.RemoveAt(index+1);
                    txtID.Text = stdId.ToString();
                    txtName.Text = null;
                    txtName.Focus();
                    txtAddress.Text = null;
                    txtPhone.Text = null;
                    cmbMajor.SelectedIndex = -1;
                    rdMale.Checked = false;
                    rdFemale.Checked = false;
                    pic1.Image = SU1Y2.Properties.Resources.noimage;
                    btnEdit.Text = "Edit";
                }
            }
            else
                MessageBox.Show("Please Select Item to Edit"); 
        }

        private void listviewStudent_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Update")
            {
                int index = listviewStudent.SelectedItems[0].Index;
                txtID.Text = listviewStudent.SelectedItems[0].SubItems[1].Text;
                txtName.Text = listviewStudent.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = listviewStudent.SelectedItems[0].SubItems[4].Text;
                txtPhone.Text = listviewStudent.SelectedItems[0].SubItems[5].Text;
                cmbMajor.SelectedItem = listviewStudent.SelectedItems[0].SubItems[6].Text;
                bool check = listviewStudent.SelectedItems[0].SubItems[3].Text == "Male" ? rdMale.Checked = true : rdFemale.Checked = true;
                btnEdit.Text = "Update";
                pic1.Image = imgList[index];
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image img = Image.FromFile(of.FileName);
                pic1.Image = img;
                addImage = true;
                
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
        }
    }
}
