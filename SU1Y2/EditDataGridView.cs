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
    public partial class EditDataGridView : Form
    {
        public EditDataGridView()
        {
            InitializeComponent();
        }

        public EditDataGridView(DataGridViewRowCollection rows,Form THIS)
        {
            InitializeComponent();
            this.rows = rows;
            this.THIS = THIS;
            foreach(DataGridViewRow row in rows)
            {
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                Image img = (Image)row.Cells[2].Value;
                DataGV1.Rows.Add(id, name, img);
            }
        }

        private DataGridViewRowCollection rows;
        Form THIS;


        private void EditDataGridView_Load(object sender, EventArgs e)
        {

        }

        private void DataGV1_SelectionChanged(object sender, EventArgs e)
        {
            if(DataGV1.Rows.Count > 0)
            {
                int rowsIndex = DataGV1.SelectedRows[0].Index;
                DataGridViewRow row = DataGV1.Rows[rowsIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                Image img = (Image)row.Cells[2].Value;
                pic1.Image = img;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /* string id = txtID.Text;
             string name = txtName.Text;
             Image img = pic1.Image;
             int rowsIndex = DataGV1.SelectedRows[0].Index;
             DataGridViewRow row = DataGV1.Rows[rowsIndex];
             row.Cells[0].Value = id;
             row.Cells[1].Value = name;
             row.Cells[2].Value = img;

             txtID.Clear();
             txtName.Clear();
             pic1.Image = Properties.Resources.noimage;

             rows[rowsIndex].Cells[0].Value = id;
             rows[rowsIndex].Cells[1].Value = name;
             rows[rowsIndex].Cells[2].Value = img;*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            THIS.Show();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Image img = Image.FromFile(of.FileName);
                pic1.Image = img;
            }
        }
    }
}
