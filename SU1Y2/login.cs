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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pwd = txtPassword.Text;
            /*if(user == "rathy" && pwd.Equals("123"))
            {
                this.Hide();
                new parking(user).ShowDialog();

            }*/
            if(!string.IsNullOrEmpty(user)&&!string.IsNullOrEmpty(pwd)) {

                this.Hide();
                new parking(user,pwd).ShowDialog();
            }
        }
    }
}
