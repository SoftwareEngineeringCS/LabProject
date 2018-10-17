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
    public partial class StudentExamStatus : Form
    {
        public StudentExamStatus()
        {
            InitializeComponent();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
        private void gridStudentExamDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ManageStartExam m = new ManageStartExam();
                this.Hide();
                m.Show();
            }
            else if (e.ColumnIndex == 3)
            {
                StudentResult s = new StudentResult();
                this.Hide();
                s.Show();

            }
        }
    }
}
