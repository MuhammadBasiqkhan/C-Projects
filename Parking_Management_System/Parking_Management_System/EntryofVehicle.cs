using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Parking_Management_System
{
    public partial class EntryofVehicle : Form
    {
        public EntryofVehicle()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Services n = new Services();
            n.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            vehicledetail();
            printScriptNO();
        }


        void vehicledetail()
        {
            if (SelectVE.Text == "Car")
            {
                Cost.Text = "2000";
            }
           else if (SelectVE.Text == "Bike")
            {
                Cost.Text = "100";
            }
          else if (SelectVE.Text == "Bus")
            {
                Cost.Text = "5000";
            }
           else if (SelectVE.Text == "Auto")
            {
                Cost.Text = "150";
            }
          
            else if (SelectVE.Text == "Taxi")
            {
                Cost.Text = "500";
            }
        }

        void printScriptNO()
        {
           
            Random random = new Random();
            int no = random.Next(1, 10000);
            Receipt.Text= no.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string Qureey = "Insert into VEHICLE_DATABASE (Name, CNIC, Address, Receipt_NO ,Vehicle_Name, Vehicle_Model, Number_Plate, Cost_oF_Vehicle) values('" + name.Text + "','" + cnic.Text + "','" + Addres.Text + "','" + Receipt.Text + "','"+ SelectVE.Text + "','" + V_MODel.Text + "','" + Num_plate.Text + "','" + Cost.Text + "') ";
            DB db = new DB();

            if (db.insert_update_Delete(Qureey) == true)
            {
                MessageBox.Show("Are you Sure you want to Insert your data", "INSERT", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                MessageBox.Show("Insert Data Succesfully ", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Congratulations your "+ SelectVE.Text + " Successfully Parked in our Parking");

            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Receipt.ReadOnly = false;
            Cost.ReadOnly = false;

            updateGroup.Visible = true;
            hide.Visible = true;
            
        }


        void edit()
        {
            string query = "UPDATE VEHICLE_DATABASE SET Name='" + U_name.Text + "', CNIC='" + U_cnic.Text + "', Address='" + U_Address.Text + "', Receipt_NO='" + U_receipt.Text + "', Vehicle_Name='" + U_select.Text + "', Vehicle_Model='" + U_Vmodel.Text + "', Number_Plate='" + U_nump.Text + "', Cost_oF_Vehicle='" + U_Cost.Text + "' WHERE Name='" + name.Text + "' AND CNIC='" + cnic.Text + "' AND Address='" + Addres.Text + "' AND Receipt_NO='" + Receipt.Text + "' AND Vehicle_Name='" + SelectVE.Text + "' AND Vehicle_Model='" + V_MODel.Text + "' AND Number_Plate='" + Num_plate.Text + "' AND Cost_oF_Vehicle='" + Cost.Text + "'";

            DB obj = new DB();


            if (obj.insert_update_Delete(query) == true)
            {
                MessageBox.Show("Are you Sure you want to Update your data", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                MessageBox.Show("Updated Data Succesfully ", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "delete from VEHICLE_DATABASE where Name = '" + name.Text + "'";
            DB obj = new DB();
             
            if (obj.insert_update_Delete(query) == true)
            {
                MessageBox.Show("Are you Sure you want to Delete data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                MessageBox.Show("Deleted Data Succesfully","DELETE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        void updatevehicledetail()
        {
            if (U_select.Text == "Car")
            {
                U_Cost.Text = "2000";
            }
            else if (U_select.Text == "Bike")
            {
                U_Cost.Text = "100";
            }
            else if (U_select.Text == "Bus")
            {
                U_Cost.Text = "5000";
            }
            else if (U_select.Text == "Auto")
            {
                U_Cost.Text = "150";
            }

            else if (U_select.Text == "Taxi")
            {
                U_Cost.Text = "500";
            }
        }

        void updateprintScriptNO()
        {
            Random random = new Random();
            int no = random.Next(1, 10000);
            U_receipt.Text = no.ToString();
        }

        private void U_receipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            updatevehicledetail();
            updateprintScriptNO();
            edit();
        }

        private void button5_Click_3(object sender, EventArgs e)
        {
            name.Clear();
            cnic.Clear();
            Addres.Clear();
            Receipt.Clear();
            V_MODel.Clear();
            Num_plate.Clear();
            Cost.Clear();
            SelectVE.Text= " ";

        }

        private void update_Enter(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = hide.Checked;
            if (hide.Checked)
            {
                updateGroup.Visible = false;

            }
            else
            {
                updateGroup.Visible = true;
            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
