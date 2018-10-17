using System;
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
    public partial class ManageStartExam : Form
    {
        public ManageStartExam()
        {
            InitializeComponent();
        }

        private void cmdStart(object sender, EventArgs e)
        {

            StudentQuiz s = new StudentQuiz();
            this.Hide();
            s.Show();
        }

        private void examDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentExamStatus s = new StudentExamStatus();
            this.Hide();
            s.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
