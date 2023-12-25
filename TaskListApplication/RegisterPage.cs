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
    public partial class RegisterPage : Form
 {
       public static RegisterPage instance;
        public RegisterPage()
        {
            InitializeComponent();
            instance = this;

        }
         private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginpage = new LoginPage();
            loginpage.Show();
            

        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                textBoxUserName.Focus();
                errorProvider1.SetError(this.textBoxUserName, "Please Fill Name");
            }
            else if (String.IsNullOrEmpty(textBoxemailId.Text))
            {
                textBoxemailId.Focus();
                errorProvider4.SetError(this.textBoxemailId, "Please enter valid email");


            }
            else if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Focus();
                errorProvider2.SetError(this.textBoxPassword, "Please enter a strong password");
            }
            else if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                textBoxConfirmPassword.Focus();
                errorProvider3.SetError(this.textBoxConfirmPassword, "Password Missmath");
            }
            else
            {
                MessageBox.Show("User SignUp Successfully");
                this.Hide();
                HomePage homepage = new HomePage();
                homepage.Show();
              };
            
            
     
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxUserName.Clear();
            this.textBoxPassword.Clear();
            this.textBoxConfirmPassword.Clear();
            this.textBoxemailId.Clear();
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                textBoxUserName.Focus();
                errorProvider1.SetError(this.textBoxUserName, "Please Fill Name");
            }
            else {
                errorProvider1.Clear();
            }

        }

       

        private void textBoxemailId_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxemailId.Text))
            {
                textBoxemailId.Focus();
                errorProvider4.SetError(this.textBoxemailId, "Please enter valid email");


            }
            else {
                errorProvider4.Clear();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Focus();
                errorProvider2.SetError(this.textBoxPassword, "Please enter a strong password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                textBoxConfirmPassword.Focus();
                errorProvider3.SetError(this.textBoxConfirmPassword, "Password Missmath");
            }
            else {
                errorProvider3.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
