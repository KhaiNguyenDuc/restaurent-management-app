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
    public class CustomerBUS
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public void insertCustomers(Customer customer)
        {
            customerDAO.insertCustomers(customer);
        }
        public int isOldCustomer(Customer customer)
        {
            // 0: false, 1: true, 2: Phone already have
            DataTable data =  customerDAO.getCustomers();
            for(int i=0;i< data.Rows.Count; i++)
            {
                if (customer.PhoneNumber.Equals(data.Rows[i]["customer_phone"].ToString())&& customer.Name.Equals(data.Rows[i]["customer_name"].ToString()))
                {
                    return 1;
                }
                else if(customer.PhoneNumber.Equals(data.Rows[i]["customer_phone"].ToString()) && !customer.Name.Equals(data.Rows[i]["customer_name"].ToString())){
                    return 2;
                }
            }
            return 0;
        }
        public void updateCustomerPoint(Customer customer)
        {
            customerDAO.updateCustomerPoint(customer);
        }
        public DataTable getCustomers()
        {
            return customerDAO.getCustomers();
        }
    }
}
