using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class VehiclePrice : Form
    {
        public VehiclePrice()
        {
            InitializeComponent();
        }

        private void VehiclePrice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Services n = new Services();
            n.Show();
            this.Hide();
        }
    }
}
