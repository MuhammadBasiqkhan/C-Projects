using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class vehicle_data : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\mfaiq\Downloads\C# Project\Parking_Management_System\Parking_Management_System\Database1.mdf"";Integrated Security=True";
        public vehicle_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           DataGridView();

        }

        void DataGridView()
        {
            string Qureey = "select * from VEHICLE_DATABASE";
            SqlConnection con = new SqlConnection(conStr);

            SqlDataAdapter sda = new SqlDataAdapter(Qureey, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           
            DisplayData.DataSource = dt;



        }

        private void button2_Click(object sender, EventArgs e)
        {

            


        }

        private void DisplayData_DefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void DisplayData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            Services n = new Services();
            n.Show();
            this.Hide();
        }

        private void vehicle_data_Load(object sender, EventArgs e)
        {

        }
    }
}
