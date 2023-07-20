using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Management_System
{
    public partial class TicketManagementSystem : Form
    {
        public TicketManagementSystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "Select * from AdminTable where Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "' ";

            Reservationdatabase db = new Reservationdatabase();
            if (db.Select(query) == true)
            {
            OnlineReservation j = new OnlineReservation();
            j.Show();
            this.Hide();
               
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
