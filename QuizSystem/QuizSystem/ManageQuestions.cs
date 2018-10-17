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
    public partial class ManageQuestions : Form
    {
        public ManageQuestions()
        {
            InitializeComponent();
        }

        private void cmdAddQuestion(object sender, EventArgs e)
        {

        }

        private void cmdViewQuiz(object sender, EventArgs e)
        {
            ManageGenerateExam m = new ManageGenerateExam();
            this.Hide();
            m.Show();
        }

        private void examDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageExam m = new ManageExam();
            this.Hide();
            m.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
