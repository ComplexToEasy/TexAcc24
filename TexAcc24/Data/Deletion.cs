using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexAcc24.Data
{
    internal class Deletion
    {
        public void DeleteIt(string proc, int id)
        {
            try
            {
                Mcls.conn.Open();
                
                SqlCommand cmd = new SqlCommand(proc, Mcls.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                Mcls.conn.Close();
                Mcls.ShowMessage("Successfully Deleted", "Delete info", "success");

            }
            catch (Exception e)
            {
                Mcls.conn.Close();
                Mcls.ShowMessage("Error in Deletion", "Delete info", "");

            }
        }
    }
}
