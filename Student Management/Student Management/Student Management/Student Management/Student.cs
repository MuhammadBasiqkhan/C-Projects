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

namespace Student_Management
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            String query;
            query = "Insert into StudentDetailTable (stu_name, stu_regId, stu_numofcourses, stu_semester ,stu_department) values('" + nametxt.Text + "','" + rolltxt.Text + "','" + coursetxt.Text + "','" + semtxt.Text + "','" + deptxt.Text + "')";
            Database db = new Database();

            if(db.Insert_Update_Delete(query)==true)
            {
                MessageBox.Show("Data Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Error in Inserting Data");
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            String query;
            query = "Delete from StudentDetailTable where stu_regId = '" + rolltxt.Text + "'";
            Database db = new Database();
            if (db.Insert_Update_Delete(query))
            {
                MessageBox.Show("Data Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Error in Deleting Data");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            datecheck();
        }

        void updatedata( string query)
        {
            Database db = new Database();
            if (db.Insert_Update_Delete(query)==true)
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error in Updating Data");
            }
        }

        void datecheck()
        {
            if (selection.Text == "Name")
            {
                String query = "UPDATE StudentDetailTable SET stu_name='" + update_text.Text + "'WHERE stu_name='" + nametxt.Text + "'";
                updatedata(query);
            }
            
            else if (selection.Text == "Roll No")
            {
                String query = "UPDATE StudentDetailTable SET stu_regId='" + update_text.Text + "'WHERE stu_regId='" + rolltxt.Text + "'";
                updatedata(query);
            }
            
            else if (selection.Text == "No of Course")
            {
                String query = "UPDATE StudentDetailTable SET stu_numofcourses='" + update_text.Text + "'WHERE stu_numofcourses='" + coursetxt.Text + "'";
                updatedata(query);
            }
            
            else if (selection.Text == "Semester")
            {
                String query = "UPDATE StudentDetailTable SET stu_semester='" + update_text.Text + "'WHERE stu_semester='" + semtxt.Text + "'";
                updatedata(query);
            }

           else if (selection.Text == "Department")
            {
                String query = "UPDATE StudentDetailTable SET stu_department='" + update_text.Text + "'WHERE stu_department='" + deptxt.Text + "'";
                updatedata(query);
            }
        }
    }
}
