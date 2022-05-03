using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace BUS
{
    public class IngredientBUS
    {
        IngredientDAO ingredientDAO = new IngredientDAO();
        RecipeDAO recipeDAO = new RecipeDAO();
        RecipeBUS recipeBUS = new RecipeBUS();
        Ingredient ingredient = new Ingredient();
        public DataTable getIngredients()
        {
            return ingredientDAO.getIngredients();
        }
        public void addIngredients(Ingredient ingredient)
        {
            ingredientDAO.insertIngredients(ingredient);
        }
        public void deleteIngredients(int ingredientsID)
        {
            ingredientDAO.deleteIngredients(ingredientsID);
        }
        public void updateIngredients(Ingredient ingredient)
        {
            ingredientDAO.updateIngredients(ingredient);
        }
        public int getIDByName(string name)
        {
            return ingredientDAO.getIDByName(name);
        }
        public double getPriceById(int id)
        {
            return ingredientDAO.getPriceById(id);
        }
        public void minusIngredients(int foodID,int quanity)
        {
            Dictionary<int, int> dataOld = recipeBUS.getIngredientsByFoodID(foodID);
            foreach (KeyValuePair<int, int> item in dataOld)
            {
                ingredient.Id = item.Key;
                ingredient.Quantity = item.Value - quanity;
                ingredientDAO.minusIngredients(ingredient);

            }
        }
        public bool isAvailable(int quantity, int foodID)
        {
            return quantity <= ingredientDAO.getQuantityByFoodID(foodID);
        }
    }
}
