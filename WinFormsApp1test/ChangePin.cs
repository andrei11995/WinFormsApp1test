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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new UserMenu().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();


        }
    }
}
