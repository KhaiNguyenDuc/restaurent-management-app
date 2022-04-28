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

        public DataTable getOrderItems()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("select Foods.food_name as [Tên], Order_food.quantity as [ Số Lượng ], Order_food.total as [ Tổng giá ]from Foods inner join Order_food on Foods.id = Order_food.food_id", conn);
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
