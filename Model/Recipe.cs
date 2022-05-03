using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recipe
    {
        private int foodID;
        private int ingredientsID;

        public int FoodID { get => foodID; set => foodID = value; }
        public int IngredientsID { get => ingredientsID; set => ingredientsID = value; }
        public Recipe()
        {
        }

        public Recipe(int foodID, int ingredientsID)
        {
            this.foodID = foodID;
            this.ingredientsID = ingredientsID;
        }
    }
}
