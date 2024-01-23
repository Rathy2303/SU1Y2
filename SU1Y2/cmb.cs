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
    public partial class cmb : Form
    {
        public cmb()
        {
            InitializeComponent();
            
        }

        List<string> dataItem = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = txtnewitem.Text;
            if (string.IsNullOrWhiteSpace(newItem))
            {
                MessageBox.Show("Please Enter Item");
            }
            else
            {
                if (dataItem.Contains(newItem))
                {
                    MessageBox.Show("Already");
                }
                else
                {
                    cbGender.Items.Add(newItem);
                    dataItem.Add(newItem);
                    txtnewitem.Text = "";
                }
            }
        }

        private void cmb_Load(object sender, EventArgs e)
        {
            dataItem.Add("Male");
            foreach (string x in dataItem)
                cbGender.Items.Add(x);
              
            
        }
    }
}
