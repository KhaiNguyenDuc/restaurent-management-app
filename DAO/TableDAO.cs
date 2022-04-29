using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class TableDAO
    {
        SqlConnection conn = Config.getConnection();

        public DataTable getTables()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id as ID,table_name as [Mã bàn], table_type as [Loại], table_state as [Trạng thái] FROM tables", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public int getStatus(string tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT table_state FROM tables WHERE ID = "+ tableID+";", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["table_state"]);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
    }
}
