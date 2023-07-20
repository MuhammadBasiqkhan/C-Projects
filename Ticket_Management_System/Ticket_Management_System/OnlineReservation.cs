using System;
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
    public partial class OnlineReservation : Form
    {
        public OnlineReservation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicketManagementSystem v = new TicketManagementSystem();
            v.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservationform form = new Reservationform();   
            form.Show();
            this.Hide();
        }
    }
}
