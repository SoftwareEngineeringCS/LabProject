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
            bool reset = false;
            bool correct = false;
            foreach (UserClass u in ListClass.mylist)
            {
                if (txtCNIC.Text == u.Cnic)
                {
                    u.Password = txtNewPassword.Text;
                    reset = true;
                }
            }
            if(txtNewPassword.Text==txtConfirmPassword.Text)
            {
                correct = true;
            }
            txtCNIC.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            if (reset && correct)
            {
                MessageBox.Show("You are Successful to change your Password");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
            Main m = new Main();
            this.Hide();
            m.Show();
        }


        private void ManagePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
