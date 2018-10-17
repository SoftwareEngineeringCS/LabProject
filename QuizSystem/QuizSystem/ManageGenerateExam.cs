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
    public partial class ManageGenerateExam : Form
    {
        public ManageGenerateExam()
        {
            InitializeComponent();
        }

        private void ManageGenerateExam_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmdGenerate(object sender, EventArgs e)
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

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageQuestions q = new ManageQuestions();
            this.Hide();
            q.Show();
        }

        private void examDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageExam m = new ManageExam();
            this.Hide();
            m.Show();
        }

        private void cmdDelete(object sender, EventArgs e)
        {

        }
    }
}
