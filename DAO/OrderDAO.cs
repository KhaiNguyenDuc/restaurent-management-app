using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace DAO
{
    public class OrderDAO
    {

        public void insertOrders(int tableID)
        {
            SqlConnection conn = Config.getConnection();
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
    }
}
