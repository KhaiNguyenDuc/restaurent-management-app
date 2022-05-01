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
    public class OrderFoodBUS
    {
        OrderFoodDAO orderDAO = new DAO.OrderFoodDAO();
        public DataTable getOrderItems(int tableID)
        {
            return orderDAO.getOrderItems(tableID);
        }
        public void insertOrderFoods(OrderFood orderFood)
        {
            
        }
    }
}
