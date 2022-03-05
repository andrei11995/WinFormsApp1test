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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new UserMenu().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();


        }
    }
}
