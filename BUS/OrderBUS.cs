using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace BUS
{
    public class OrderBUS
    {
        OrderDAO orderDAO = new OrderDAO();
        public void insertOrders(int tableID)
        {
            orderDAO.insertOrders(tableID);
        }
        public int getLatestOrderIDByTableID(int tableID)
        {
            return orderDAO.getLatestOrderIDByTableID(tableID);
        }
        public void updateSumTotalAndState(int orderID, int total)
        {
            orderDAO.updateSumTotalAndState(orderID, total);
        }
        public void updateCustomersID(Customer customer, int orderID)
        {
            orderDAO.updateCustomersID(customer, orderID);
        }
    }
}
