using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskListApplication
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = "User123";
            string password = "User123@";


            if (textBoxUserName.Text.Equals(username) && textBoxPassword.Text.Equals(password))
            {
               
                new HomePage().Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Wrong Username or Password! Try again");
                textBoxUserName.Clear();       
                textBoxPassword.Clear();
                textBoxUserName.Focus();
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            textBoxUserName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonSignIn_click(object sender, EventArgs e) 
        {
            this.Hide();
            RegisterPage registerpage = new RegisterPage();
            registerpage.Show();
        
        }

        private void buttonSignIn_Click_1(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
