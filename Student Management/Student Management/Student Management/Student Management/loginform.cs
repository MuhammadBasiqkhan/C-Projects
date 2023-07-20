using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            String query;
           
             query = "Select * from AdminTable where user_name='" + usertxt.Text + "' AND user_password='" + passtxt.Text + "' ";

            Database db = new Database(); 

            if (db.Selecter(query)==true)
            {
                Student f2 = new Student();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
