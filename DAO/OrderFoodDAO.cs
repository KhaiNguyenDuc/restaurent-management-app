using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrderFoodDAO
    {
        SqlConnection conn = Config.getConnection();

        public DataTable getOrderItems(int tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Foods.food_name AS [Tên], Order_food.quantity AS [Số Lượng], Order_food.total AS [Tổng giá]FROM Foods inner join Order_food ON Foods.id = Order_food.food_id inner join Orders ON Orders.id = Order_food.order_id inner join tables ON tables.id = Orders.table_id WHERE tables.id = "+ tableID+";", conn);
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
