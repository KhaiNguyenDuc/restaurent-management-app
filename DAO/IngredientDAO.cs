using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    public class IngredientDAO
    {
        SqlConnection conn = Config.getConnection();
        public DataTable getIngredients()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id as [ID], ingredients_name as [Tên], quantity as [Số lượng], price as [Giá] FROM ingredients", conn);
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
        public void insertIngredients(Ingredient ingredient)
        {
            
            string query = "INSERT INTO ingredients (ingredients_name,quantity,price) VALUES (@Name,@Quantity,@Price)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = ingredient.Name;
                    command.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                    command.Parameters["@Quantity"].Value = ingredient.Quantity;
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));
                    command.Parameters["@Price"].Value = ingredient.Price;

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void deleteIngredients(int ingredientsID)
        {
            string query = "DELETE FROM ingredients WHERE id = " + ingredientsID + ";";
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
        public void updateIngredients(Ingredient ingredient)
        {
            string query = "UPDATE ingredients SET ingredients_name = @Name, quantity = @Quantity, price = @Price WHERE id = " + ingredient.Id;

            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = ingredient.Name;
                    command.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                    command.Parameters["@Quantity"].Value = ingredient.Quantity;
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));
                    command.Parameters["@Price"].Value = ingredient.Price;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {

            }
        }
        public int getIDByName(string name)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id FROM ingredients WHERE ingredients_name = N'"+ name + "';", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["id"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

        }
        public double getPriceById(int id)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT price FROM ingredients WHERE id = " + id + ";", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToDouble(data.Rows[0]["price"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1.0;
            }
        }
        public void minusIngredients(Ingredient ingredient)
        {
            string query = "UPDATE ingredients SET quantity = @Quantity WHERE id = " + ingredient.Id;

            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                    command.Parameters["@Quantity"].Value = ingredient.Quantity;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {

            }
        }
        public int getQuantityByFoodID(int foodID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Min(quantity) as quantity FROM Recipes INNER JOIN Ingredients ON Recipes.ingredient_id = Ingredients.id WHERE Recipes.food_id = " + foodID + ";", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["quantity"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
