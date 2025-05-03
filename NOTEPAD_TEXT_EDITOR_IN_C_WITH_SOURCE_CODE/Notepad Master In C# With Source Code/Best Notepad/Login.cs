using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Best_Notepad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((usernametextBox.Text == "hassan") && (passwordtextBox.Text == "hassan"))
            {
                this.Close();
                notepad1 obj = new notepad1();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
            notepad1 obj = new notepad1();
            obj.Show();
        }
    }
}
