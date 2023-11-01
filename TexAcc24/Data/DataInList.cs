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
    public class DataInList
    {
        public void GetDataInList(string proc, ComboBox cb, string valueMember, string DisplayMember, string? tableName = null)
        {
            try
            {
                Mcls.conn.Open();
                SqlCommand cmd = new SqlCommand(proc, Mcls.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                DataRow dataRow = dt.NewRow();

                dataRow[DisplayMember] = $"--< Select {tableName} >--";
                dataRow[valueMember] = 0;


                dt.Rows.InsertAt(dataRow, 0);


                cb.DataSource = dt;
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = valueMember;

                Mcls.conn.Close();
            }
            catch (Exception e)
            {
                Mcls.conn.Close();
                Mcls.ShowMessage("Unable to load data in list", "Error Data In List", "");
            }
        }
    }
}
