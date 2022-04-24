using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class FoodBUS
    {
        FoodDAO food = new FoodDAO();
        public DataTable getFoods()
        {
            return food.getFoods();
        }
    }
}
