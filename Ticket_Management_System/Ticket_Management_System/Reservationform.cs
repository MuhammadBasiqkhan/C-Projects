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
    public partial class Reservationform : Form
    {
        public Reservationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservationno();
            seatno();
        }

        void reservationno()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 10);
            textBox2.Text = n.ToString();

        }
        void seatno()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 200);
            textBox3.Text = n.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Insert into Resservation_Table (Name, train_name, Reservation_time, Reservation_Date ,Reservation_no,Seat_no) values('" + textBox1.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value + "','" + datePicker1.Value + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            Reservationdatabase db = new Reservationdatabase();
            if (db.Insert_Update_Delete(query) == true)
            {
                MessageBox.Show("Data Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Error in Inserting Data");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String query;
            query = "Delete from Resservation_Table where Reservation_Date = '" + datePicker1.Value + "'";
            Reservationdatabase db = new Reservationdatabase();
            if (db.Insert_Update_Delete(query))
            {
                MessageBox.Show("Data Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Error in Deleting Data");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
           textBox2.ReadOnly = false;
           textBox3.ReadOnly = false;
        }
        void updatedata(string query)
        {
            Reservationdatabase db = new Reservationdatabase();
            if (db.Insert_Update_Delete(query) == true)
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error in Updating Data");
            }
        }

        void datacheck()
        {
            if (select.Text == "Name")
            {
                String query = "UPDATE Resservation_Table SET Name='" + update_text.Text + "'WHERE Name='" + textBox1.Text + "'";
                updatedata(query);
            }

            else if (select.Text == "Roll No")
            {
                String query = "UPDATE StudentDetailTable SET train_name='" + update_text.Text + "'WHERE train_name='" + textBox4.Text + "'";
                updatedata(query);
            }

            else if (select.Text == "No of Course")
            {
                String query = "UPDATE StudentDetailTable SET Reservation_time='" + update_text.Text + "'WHERE Reservation_time='" + dateTimePicker2.Value + "'";
                updatedata(query);
            }

            else if (select.Text == "Semester")
            {
                String query = "UPDATE StudentDetailTable SET Reservation_Date='" + update_text.Text + "'WHERE Reservation_Date='" + datePicker1.Value + "'";
                updatedata(query);
            }

            else if (select.Text == "Department")
            {
                String query = "UPDATE StudentDetailTable SET Reservation_no='" + update_text.Text + "'WHERE Reservation_no='" + textBox2.Text + "'";
                updatedata(query);
            }

            else if (select.Text == "Department")
            {
                String query = "UPDATE StudentDetailTable SET Seat_no='" + update_text.Text + "'WHERE Seat_no='" + textBox3.Text + "'";
                updatedata(query);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            datacheck();
        }
    }
}