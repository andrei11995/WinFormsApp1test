using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1test
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
          
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserNameAdmin_TextChanged(object sender, EventArgs e)
        {

        }
        private void textpasswordAdmin_TextChanged(object sender, EventArgs e)
        {//aceasta modificare

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Start().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
