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
    public class FoodDAO
    {
        SqlConnection conn = Config.getConnection();

        public DataTable getFoods()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id as ID, food_name as [Tên món],price as [Giá tiền], food_type as [Loại] FROM foods", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public string getImage(int id)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT food_path FROM foods WHERE id = "+id, conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data.Rows[0]["food_path"].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void insertFoods(Food food)
        {
            SqlConnection conn = Config.getConnection();
            string query = "INSERT INTO foods (food_name,price,food_type,food_path) VALUES (@Name,@Price,@Type,@Path)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = food.Name;
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));
                    command.Parameters["@Price"].Value = food.Price;
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    command.Parameters["@Type"].Value = food.Type;
                    command.Parameters.Add(new SqlParameter("@Path", SqlDbType.NVarChar));
                    command.Parameters["@Path"].Value = food.Path;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
               
            }
        }
        public void deleteFoods(int foodID)
        {
            string query = "DELETE FROM foods WHERE id = " + foodID + ";";
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
        public void updateFoods(Food food)
        {
            string query = "UPDATE foods SET food_name = @Name, price = @Price, food_type = @Type, food_path = @Path WHERE id = " + food.Id;
            
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = food.Name ;
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));
                    command.Parameters["@Price"].Value = food.Price;
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    command.Parameters["@Type"].Value = food.Type;
                    command.Parameters.Add(new SqlParameter("@Path", SqlDbType.NVarChar));
                    command.Parameters["@Path"].Value = food.Path;
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
