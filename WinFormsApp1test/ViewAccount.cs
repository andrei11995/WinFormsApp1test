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
    public partial class ViewAccount : Form
    {
        public ViewAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new UserMenu().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();


        }
    }
}
