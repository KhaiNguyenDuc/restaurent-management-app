using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class OrderFoodBUS
    {
        OrderFoodDAO order = new DAO.OrderFoodDAO();
        public DataTable getOrderItems()
        {

            return order.getOrderItems();
        }
    }
}
