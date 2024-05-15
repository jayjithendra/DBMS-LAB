using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Application
{
    public partial class Form1 : Form
    {
        string userid = "JayJ27";
        string pwdog = "student";
        
        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pwdog != textBox2.Text || userid != textBox1.Text)
            {
                label3.Text = "Login Unsuccessful";
            }
            else
            {
                label3.Text = "Login Successful";
                Form2 frm = new Form2();
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button2.Visible = true;
            if (pwdog == textBox4.Text)
            {
                pwdog = textBox3.Text;
                string message = "Password Updated";
                MessageBox.Show(message);
            }
            else
            {
                label7.Text = "Old Password does not match";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button2.Visible = true;
            if (pwdog == textBox4.Text)
            {
                pwdog = textBox3.Text;
                string message = "Password Updated";
                MessageBox.Show(message);
            }
            else
            {
                label7.Text = "Old Password does not match";
            }

        }
    }
}
