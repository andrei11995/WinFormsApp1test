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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SingUp().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Log().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
               Point p = PointToScreen(e.Location);
                Location = new Point(p.X-this.startPoint.X, p.Y-this.startPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
           

        }
    }
}
