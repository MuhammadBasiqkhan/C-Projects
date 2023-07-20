using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Management_System
{
    internal class Reservationdatabase
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\mfaiq\Downloads\C# Project\Ticket_Management_System\Ticket_Management_System\Reservationdata.mdf"";Integrated Security=True";
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


        public bool Select(String query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
