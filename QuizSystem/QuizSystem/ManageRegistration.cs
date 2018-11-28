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
    public partial class ManageRegistration : Form
    {
        public ManageRegistration()
        {
            InitializeComponent();
        }
        private void cmdRegister(object sender, EventArgs e)
        {
            
            bool incomplete = false;
            bool exist = false;
            if (txtName.Text == "" || txtCNIC.Text == "" || txtContactNo.Text == "" ||txtPassword.Text == ""|| txtRole.Text == "")
            {
                MessageBox.Show("Something wrong");
                incomplete = true;
            }

            foreach (UserClass u in ListClass.mylist)
            {
                if (txtName.Text == u.Username)
                {
                    MessageBox.Show("User already exist!");
                    exist = true;
                }
            }

            if (incomplete != true && exist != true)
            {
                UserClass a = new UserClass();
                a.Username = txtName.Text;
                a.Password = txtPassword.Text;
                a.Role = txtRole.Text;
                a.Cnic = txtCNIC.Text;
                a.ContactNumber = txtContactNo.Text;
                ListClass.mylist.Add(a);
                txtCNIC.Text = "";
                txtContactNo.Text = "";
                txtRole.Text = "";
                txtName.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("You have Registered successfully");

            }
        }

        private void cmdLogin(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
