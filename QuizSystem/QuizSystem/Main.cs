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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DatabaseConnection.getInstance().ConnectionString = "";
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdLogin(object sender, EventArgs e)
        {
            //if(txtName.Text == "admin")
            //{
            //    //teacher
            //    ManageExam m = new ManageExam();
            //    this.Hide();
            //    m.Show();
            //}
            //else if(txtName.Text=="student")
            //{
            //    //student
            //    StudentExamStatus s = new StudentExamStatus();
            //    this.Hide();
            //    s.Show();
            //}
            bool isfound = false;
            foreach (UserClass u in ListClass.mylist)
            {
                if (txtName.Text == u.Username && txtPassword.Text == u.Password && u.Role==txtRole.Text)
                {
                    isfound = true;
                    MyUtil.loginuser = u;
                }
            }
            if (isfound && txtRole.Text == "Teacher")
            {
                MessageBox.Show("Login successfully");
                txtName.Text = "";
                txtPassword.Text = "";
                ManageExam m = new ManageExam();
                this.Hide();
                m.Show();
            }
            else if(isfound)
            {
                MessageBox.Show("Login successfully");
                txtName.Text = "";
                txtPassword.Text = "";
                StudentExamStatus s = new StudentExamStatus();
                this.Hide();
                s.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void cmdSignup(object sender, EventArgs e)
        {
            ManageRegistration r = new ManageRegistration();
            this.Hide();
            r.Show();
        }

        private void lnkForgetPassword(object sender, EventArgs e)
        {
            ManagePassword p = new ManagePassword();
            this.Hide();
            p.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lnkForgetPass(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagePassword m = new ManagePassword();
            this.Hide();
            m.Show();
        }
    }
}
