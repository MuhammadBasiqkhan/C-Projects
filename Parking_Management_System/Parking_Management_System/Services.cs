using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class Services : Form
    {

        public Services()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcomeform n = new Welcomeform();
            n.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Services_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }


        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void Services_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void price_Click(object sender, EventArgs e)
        {
            VehiclePrice o = new VehiclePrice();
            o.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EntryofVehicle n = new EntryofVehicle();
            n.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_Click(object sender, EventArgs e)
        {
            vehicle_data n = new vehicle_data();

            n.Show();
            this.Hide();    
        }


     
    }
}
