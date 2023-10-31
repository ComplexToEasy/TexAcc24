using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexAcc24.Data
{
    public class Selection
    {
        public void GetUserData(DataGridView gv, DataGridViewColumn idGv, DataGridViewColumn loginNameGv, DataGridViewColumn usernameGv, DataGridViewColumn passwordGv, DataGridViewColumn rollGv, DataGridViewColumn isActiveGv, DataGridViewColumn PhoneGv, string? data = null)
        {
            SqlCommand cmd;
            Mcls.conn.Open();
            if (data == null)
            {
                cmd = new SqlCommand("GetUsersData", Mcls.conn);

            }
            else
            {
                cmd = new SqlCommand("GetUsersFindData", Mcls.conn);
                cmd.Parameters.AddWithValue("@data", data);
            }
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter sdr = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sdr.Fill(dt);
            idGv.DataPropertyName = dt.Columns["ID"].ToString();
            loginNameGv.DataPropertyName = dt.Columns["Login Name"].ToString();
            usernameGv.DataPropertyName = dt.Columns["User Name"].ToString();
            passwordGv.DataPropertyName = dt.Columns["Password"].ToString();
            isActiveGv.DataPropertyName = dt.Columns["Is Active"].ToString();
            rollGv.DataPropertyName = dt.Columns["Roll"].ToString();
            PhoneGv.DataPropertyName = dt.Columns["Phone"].ToString();
            gv.DataSource = dt;

            Mcls.conn.Close();
        }
    }
}
