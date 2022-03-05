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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserMenu().Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Start().Show();
            this.Hide();
        }
    }
}
