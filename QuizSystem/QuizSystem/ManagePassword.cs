﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystem
{
    public partial class ManagePassword : Form
    {
        public ManagePassword()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmdReset(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }


        private void ManagePassword_Load(object sender, EventArgs e)
        {

        }
    }
}