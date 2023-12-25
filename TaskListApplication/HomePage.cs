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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string task = textBox4.Text.ToString();
            string reminder = textBox6.Text.ToString();
            string description = textBox5.Text.ToString();


            if (checkBox1.Checked)
            {
                listBox4.Items.Add(task);
                listBox4.Items.Add(description);
                listBox6.Items.Add(task);
            }
            else
            {
                listBox4.Items.Add(task);
                listBox4.Items.Add(description);
                listBox5.Items.Add(reminder);
            }

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Focus();

            textBox5.Clear();
            textBox5.Focus();

            textBox6.Clear();
            textBox6.Focus();

            checkBox1.Checked = false;
           
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            if ((listBox4.SelectedIndex!= -1) && (listBox5.SelectedIndex != -1) && (listBox6.SelectedIndex != -1))
            {
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);
            }
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
