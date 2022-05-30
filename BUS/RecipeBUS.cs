using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;
using System.Data;

namespace BUS
{
    public class RecipeBUS
    {
        RecipeDAO recipeDAO = new RecipeDAO();
        public Dictionary<int, int> getIngredientsByFoodID(int foodID)
        {
            Dictionary<int, int> data = new Dictionary<int, int>();

            DataTable Ingredients =  recipeDAO.getIngredientsByFoodID(foodID);
            for(int i=0;i< Ingredients.Rows.Count; i++)
            {
                data.Add(Convert.ToInt32(Ingredients.Rows[i]["id"]), Convert.ToInt32(Ingredients.Rows[i]["quantity"]));
            }
            return data;
        }
        public void insertRecipes(Recipe recipe)
        {
            recipeDAO.insertRecipes(recipe);
        }
        public void deleteRecipeByFoodID(int foodID)
        {
            recipeDAO.deleteRecipeByFoodID(foodID);
        }
    }
}
