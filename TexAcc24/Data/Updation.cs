using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexAcc24.Data
{
    internal class Updation
    {
        public static void UpdateUsers(int userId, string loginName, string username, string password, string roll, string isActive,
            string? phone = null)
        {
            try
            {
                if (Mcls.conn.State == ConnectionState.Closed)
                {
                    Mcls.conn.Open();

                }
                else
                {
                    Mcls.conn.Close();

                }
                SqlCommand cmd = new SqlCommand("UpdateUsers", Mcls.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", userId);
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
        public static void UpdateCategory(int id,string cName)
        {
            try
            {
                Mcls.conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateCategory", Mcls.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", cName);
                cmd.Parameters.AddWithValue("@id", id);

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
