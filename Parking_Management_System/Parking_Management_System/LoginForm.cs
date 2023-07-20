using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parking_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "Select * from Admin_Data where Admin_Email='" + Username.Text + "' AND Admin_Password='" + Password.Text + "' ";
            DB n = new DB();

            if (n.CheckAdmindata(query)==true)
            {
               Welcomeform oj = new Welcomeform();
                oj.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

       

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = false;

            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}
