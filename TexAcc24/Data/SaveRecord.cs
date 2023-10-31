using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexAcc24.Data
{
    internal class SaveRecord
    {
        public static void InsertUsers(string loginName, string username, string password, string roll, string isActive,
            string? phone = null)
        {
            try
            {
                Mcls.conn.Open();
                SqlCommand cmd = new SqlCommand("InsertUsers", Mcls.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loginname", loginName);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@isactive", isActive);
                if (phone == null)
                {
                    cmd.Parameters.AddWithValue("@phone", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone", phone);

                }

                cmd.ExecuteNonQuery();
                Mcls.conn.Close();
            }
            catch (Exception e)
            {
                Mcls.conn.Close();
                
            }

        }
        public static void InsertCategory(string cName)
        {
            try
            {
                Mcls.conn.Open();
                SqlCommand cmd = new SqlCommand("InsertCategory", Mcls.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", cName);
                
                cmd.ExecuteNonQuery();
                Mcls.conn.Close();
            }
            catch (Exception e)
            {
                Mcls.conn.Close();
                
            }

        }
    }
}
