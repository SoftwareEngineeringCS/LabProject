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
    public partial class StudentQuiz : Form
    {
        public StudentQuiz()
        {
            InitializeComponent();
        }

        private void cmdPrevious(object sender, EventArgs e)
        {

        }

        private void cmdNext(object sender, EventArgs e)
        {

        }

        private void cmdSubmit(object sender, EventArgs e)
        {
            StudentExamStatus s = new StudentExamStatus();
            this.Hide();
            s.Show();
        }
        
        private void StudentQuiz_Load(object sender, EventArgs e)
        {
            Time.Start();
        }
        //public int i = 60;
        int m=1;
        int s=0;
        private void Time_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if(s==-1)
            {
                m = m - 1;
                s = 59;
            }
            if(m==0 && s==0)
            {
                Time.Stop();
                TimeCounter.Text = "Time Over";
                
            }
            lblSeconds.Text = s.ToString();
            lblMinutes.Text = m.ToString();
        }
    }
}
