﻿using System;
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
    public partial class DataGridViewLearning : Form
    {
        public DataGridViewLearning()
        {
            InitializeComponent();
        }

        int selectedRow = -1;
        private void pic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult rs = of.ShowDialog();
            if(rs == DialogResult.OK)
            {
                Image img = Image.FromFile(of.FileName);
                pic1.Image = img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name  = txtName.Text.Trim();
            DataGV1.Rows.Add(id, name, pic1.Image);
            txtID.Text = null;
            txtName.Text = null;
            pic1.Image = Properties.Resources.noimage;
            txtID.Focus();
            DataGV1.ClearSelection();
        }

        private void DataGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                int row = e.RowIndex;
                OpenFileDialog of = new OpenFileDialog();
                DialogResult rs = of.ShowDialog();
                if(rs == DialogResult.OK)
                {
                    Image img = Image.FromFile(of.FileName);
                    DataGV1.Rows[row].Cells[2].Value = img;
                }
            }
            
            
        }

        private void DataGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;
                txtID.Text = DataGV1.Rows[selectedRow].Cells[0].Value.ToString();
                txtName.Text = DataGV1.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(selectedRow >= 0)
            {
                DataGV1.Rows.RemoveAt(selectedRow);
            }
        }

        private void DataGridViewLearning_Click(object sender, EventArgs e)
        {
            DataGV1.ClearSelection();
            selectedRow = -1;
        }
    }
}