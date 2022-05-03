using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;
namespace DAO
{
    public class OrderDAO
    {
        SqlConnection conn = Config.getConnection();
        public void insertOrders(int tableID)
        {
            
            string query = "INSERT INTO orders (order_date,table_id) VALUES (@OrderDate,@TableID)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime));
                    command.Parameters["@OrderDate"].Value = DateTime.Now;
                    command.Parameters.Add(new SqlParameter("@TableID", SqlDbType.Int));
                    command.Parameters["@TableID"].Value = tableID;
                    
                    
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public int getLatestOrderIDByTableID(int tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM orders WHERE table_id = " + tableID + "ORDER BY id DESC ", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["id"]);
            }
            catch
            {
                return -1;
            }
             
        }
        public void updateSumTotalAndState(int orderID,int total)
        {
            string query = "UPDATE orders SET sum_total = @Total, order_state = 0  WHERE id = " + orderID + ";";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    command.Parameters.Add(new SqlParameter("@Total", SqlDbType.Int));
                    command.Parameters["@Total"].Value = total;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("kkkk");
            }
        }

    }
}
