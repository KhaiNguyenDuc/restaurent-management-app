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
                SqlCommand command = new SqlCommand("SELECT id as ID,table_name as [Mã bàn], table_type as [Loại], table_state as [Trạng thái], table_location as [Vị trí] FROM tables", conn);
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
        public DataTable getTables(string location)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id as ID,table_name as [Mã bàn], table_type as [Loại], table_state as [Trạng thái] FROM tables WHERE table_location =  '"+location+"';", conn);
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
            catch 
            {
                return -1;
            }
        }
        public void updateStatus(int state, string tableID)
        {
            string query = "UPDATE tables SET table_state = @State WHERE id = " + tableID+";";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    command.Parameters.Add(new SqlParameter("@State", SqlDbType.Int));
                    command.Parameters["@State"].Value = state;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
    }
}
