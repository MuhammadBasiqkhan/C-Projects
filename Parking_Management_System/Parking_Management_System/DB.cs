using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Parking_Management_System
{
    internal class DB
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\mfaiq\Downloads\C# Project\Parking_Management_System\Parking_Management_System\Database1.mdf"";Integrated Security=True";


        public bool CheckAdmindata(string qureey)
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qureey, con);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows==true)
                {
                        return true;
                    
                }
                con.Close();

            }
            catch
            {
                return false;
            }
            return false;
        }



        public bool insert_update_Delete(string qureey)
        {
            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qureey, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }

            catch (Exception ex)
            {
                return false;
            }

        }

       
      
    }
}
