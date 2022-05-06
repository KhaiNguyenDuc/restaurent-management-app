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
    public class OrderFoodDAO
    {
        SqlConnection conn = Config.getConnection();

        public DataTable getOrderItems(int tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Foods.food_name AS [Tên], Order_food.quantity AS [Số Lượng], Order_food.total AS [Tổng giá], order_food_state as [Trạng thái]  FROM Foods inner join Order_food ON Foods.id = Order_food.food_id  inner join Orders ON Orders.id = Order_food.order_id inner join tables ON tables.id = Orders.table_id WHERE tables.id = " + tableID +" and Orders.id = (SELECT TOP 1 id FROM orders WHERE table_id = " + tableID + " ORDER BY id DESC)" , conn);
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
        public void insertOrderFoods(OrderFood orderFood)
        {
            string query = "INSERT INTO order_food( quantity,total,food_id,order_id) VALUES (@Quantity,@Total,@FoodID,@OrderID)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                    command.Parameters["@Quantity"].Value = orderFood.Quantity;
                    command.Parameters.Add(new SqlParameter("@Total", SqlDbType.Real));
                    command.Parameters["@Total"].Value = orderFood.TotalPrice;
                    command.Parameters.Add(new SqlParameter("@FoodID", SqlDbType.Int));
                    command.Parameters["@FoodID"].Value = orderFood.FoodID;
                    command.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                    command.Parameters["@OrderID"].Value = orderFood.OrderID;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {  
            }

        }
        public void deleteOrderFoods(int foodID)
        {
            string query = "DELETE FROM order_food WHERE food_id = " + foodID + ";";
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
        public void update(OrderFood orderFood, int oldFoodID)
        {
            string query = "UPDATE order_food SET quantity = @Quantity, total = @Total, food_id = @FoodID, order_food_state = @State WHERE food_id = " + oldFoodID + ";";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    command.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                    command.Parameters["@Quantity"].Value = orderFood.Quantity;
                    command.Parameters.Add(new SqlParameter("@Total", SqlDbType.Real));
                    command.Parameters["@Total"].Value = orderFood.TotalPrice;
                    command.Parameters.Add(new SqlParameter("@FoodID", SqlDbType.Int));
                    command.Parameters["@FoodID"].Value = orderFood.FoodID;
                    command.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar));
                    command.Parameters["@State"].Value = orderFood.State;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public DataTable getCheckoutItems(int tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Foods.food_name AS [Tên], Order_food.quantity AS [Số Lượng], Order_food.total AS [Tổng giá]  FROM Foods inner join Order_food ON Foods.id = Order_food.food_id  inner join Orders ON Orders.id = Order_food.order_id inner join tables ON tables.id = Orders.table_id WHERE tables.id = " + tableID + " and Orders.id = (SELECT TOP 1 id FROM orders WHERE table_id = " + tableID + " ORDER BY id DESC)", conn);
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
