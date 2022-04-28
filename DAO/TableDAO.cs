using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
