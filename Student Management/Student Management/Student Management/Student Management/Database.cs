using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Management
{
    public class Database
    {

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\mfaiq\Downloads\C# Project\Student Management\Student Management\Student Management\Student Management\Student.mdf"";Integrated Security=True";

        public bool Insert_Update_Delete(String query)
        {             
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Selecter(String query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows==true)
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                        connection.Close();
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
