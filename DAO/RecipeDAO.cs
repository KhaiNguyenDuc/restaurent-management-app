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
    public class RecipeDAO
    {
        SqlConnection conn = Config.getConnection();
        public DataTable getIngredientsByFoodID(int foodID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Recipes INNER JOIN Ingredients ON Recipes.ingredient_id = Ingredients.id WHERE Recipes.food_id = "+ foodID+";", conn);
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
        public void insertRecipes(Recipe recipe)
        {
            string query = "INSERT INTO recipes VALUES (@FoodID,@IngredientID)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@FoodID", SqlDbType.Int));
                    command.Parameters["@FoodID"].Value = recipe.FoodID;
                    command.Parameters.Add(new SqlParameter("@IngredientID", SqlDbType.Int));
                    command.Parameters["@IngredientID"].Value = recipe.IngredientsID;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void deleteRecipeByFoodID(int foodID)
        {
            string query = "DELETE FROM recipes WHERE food_id = " + foodID + ";";
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

    }
}
