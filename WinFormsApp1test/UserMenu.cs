﻿using System;
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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ViewAccount().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ChangePin().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Transfer().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Payment().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ViewPayments().Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            new Log().Show();
            this.Hide();
        }
    }
}
