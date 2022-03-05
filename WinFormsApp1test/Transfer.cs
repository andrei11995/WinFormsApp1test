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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            new UserMenu().Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ViewAccount().Show();
            this.Hide();
        }
    }
}
