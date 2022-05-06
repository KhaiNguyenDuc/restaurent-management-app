using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;
namespace BUS
{
    public class OrderFoodBUS
    {
        OrderFoodDAO orderDAO = new DAO.OrderFoodDAO();
        public DataTable getOrderItems(int tableID)
        {
            return orderDAO.getOrderItems(tableID);
        }
        public void insertOrderFoods(OrderFood orderFood)
        {
            orderDAO.insertOrderFoods(orderFood);
        }
        public bool isOldOrderFoods(DataGridView data,string name)
        {
            for(int i = 0; i < data.Rows.Count-1; i++)
            {
                Console.WriteLine(data.Rows[i].Cells[0].Value);
                if (name.Equals(data.Rows[i].Cells[0].Value)){
                    return true;
                }
            }
            return false;
        }
        public void deleteOrderFoods(int foodID)
        {
            orderDAO.deleteOrderFoods(foodID);
        }
        public void update(OrderFood orderFood,int oldFoodID)
        {
            orderDAO.update(orderFood, oldFoodID);
        }
        public DataTable getCheckoutItems(int tableID)
        {
            return orderDAO.getCheckoutItems(tableID);
        }
    }
}
