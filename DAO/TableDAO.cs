using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace DAO
{
    public class TableDAO
    {
        SqlConnection conn = Config.getConnection();
        Table table = new Table();
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
        public void insertTables(Table table)
        {

            string query = "INSERT INTO tables (table_name,table_type,table_state,table_location) VALUES (@Name,@Type,@State,@Location)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = table.TableNumber;
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar));
                    command.Parameters["@Type"].Value = table.Type;
                    command.Parameters.Add(new SqlParameter("@State", SqlDbType.Int));
                    command.Parameters["@State"].Value = 0;
                    command.Parameters.Add(new SqlParameter("@Location", SqlDbType.NVarChar));
                    command.Parameters["@Location"].Value = table.Location;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void deleteTables(int tableID)
        {
            string query = "DELETE FROM tables WHERE id = " + tableID + ";";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void updateTables(Table table)
        {
            string query = "UPDATE tables SET table_name = @Name, table_type = @Type, table_location = @Location WHERE id = " + table.Id;

            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = table.TableNumber;
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar));
                    command.Parameters["@Type"].Value = table.Type;
                    command.Parameters.Add(new SqlParameter("@Location", SqlDbType.NVarChar));
                    command.Parameters["@Location"].Value = table.Location;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                
            }
        }
        public bool isNewOrder(int tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM orders WHERE table_id = "+tableID+"ORDER BY id DESC ", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["order_state"])==1;
            }
            catch
            {
                return false;
            }
        }
    }
}
