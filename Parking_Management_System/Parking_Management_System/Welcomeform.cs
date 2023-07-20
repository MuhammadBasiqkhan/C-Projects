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
    public partial class Welcomeform : Form
    {
        public Welcomeform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Services n = new Services();
            n.Show();
            this.Hide();
        }

        private void Welcomeform_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode == Keys.Enter)
            {
                Enter.PerformClick();
                
            }
          
        }
    }
}
