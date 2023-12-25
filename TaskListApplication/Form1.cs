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
    public partial class TastLsitLoginSignUpPage : Form
    {
        public static TastLsitLoginSignUpPage instance;
        public TastLsitLoginSignUpPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
           // this.Hide();
        }

        private void TastLsitLoginSignUpPage_Load(object sender, EventArgs e)
        {

        }
    }
}
