using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BUS;
using Model;
namespace GUI
{
    public partial class frmAddRecipe : Form
    {
        IngredientBUS ingredientBUS = new IngredientBUS();
        Ingredient ingredient = new Ingredient();
        FoodBUS foodBUS = new FoodBUS();
        RecipeBUS recipeBUS = new RecipeBUS();
        public frmAddRecipe()
        {
            InitializeComponent();
            loadIngredientItems();
        }
        public void loadIngredientItems()
        {
            DataTable data = ingredientBUS.getIngredients();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                chlIngredientItems.Items.Add(data.Rows[i]["Tên"].ToString());
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            List<Recipe> recipes = new List<Recipe>();
            
            foreach (object itemChecked in chlIngredientItems.CheckedItems)
            {
               Recipe recipe = new Recipe();
               ingredient.Id = ingredientBUS.getIDByName(itemChecked.ToString());
               recipe.IngredientsID = ingredient.Id;
               recipe.FoodID = frmAdminFood.LatestID;
               totalPrice = totalPrice + ingredientBUS.getPriceById(ingredient.Id);
               recipes.Add(recipe);
            }
            double newPrice = totalPrice + (totalPrice / 2);
            foodBUS.updatePrice(frmAdminFood.LatestID, newPrice);
            
            foreach(Recipe re in recipes)
            {
                recipeBUS.insertRecipes(re);
            }
            MessageBox.Show("Thêm công thức thành công");
           // this.Close();
        }
    }
}
