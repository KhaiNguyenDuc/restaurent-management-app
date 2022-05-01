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
    public class FoodBUS
    {
        FoodDAO foodDAO = new FoodDAO();
        public DataTable getFoods()
        {
            return foodDAO.getFoods();
        }
        public string getImage(int id)
        {
            return foodDAO.getImage(id);
        }
        public void insertFoods(Food foods)
        {
            foodDAO.insertFoods(foods);
        }
        public void deleteFoods(int foodID)
        {
            foodDAO.deleteFoods(foodID);
        }
        public bool validate(Food food)
        {
            if (food.Name == "" || food.Path == "" || food.Price.ToString().Equals(null)|| food.Type.ToString().Equals(null))
            {
                return false;
            }
            return true;
        }
        public void updateFoods(Food food)
        {
            foodDAO.updateFoods(food);
        }
    }
}
