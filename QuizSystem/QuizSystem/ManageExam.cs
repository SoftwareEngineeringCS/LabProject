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
    public partial class ManageExam : Form
    {
        public ManageExam()
        {
            InitializeComponent();
        }

        private void cmdExam(object sender, EventArgs e)
        {
            ManageQuestions q = new ManageQuestions();
            this.Hide();
            q.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
