using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace DAO
{
    public class CustomerDAO
    {
        SqlConnection conn = Config.getConnection();
        public void insertCustomers(Customer customer)
        {
            string query = "INSERT INTO Customers (customer_name,customer_phone,customer_point) VALUES (@Name,@PhoneNumber,@Point)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = customer.Name;
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                    command.Parameters["@PhoneNumber"].Value = customer.PhoneNumber;
                    command.Parameters.Add(new SqlParameter("@Point", SqlDbType.Int));
                    command.Parameters["@Point"].Value = customer.Point;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public DataTable getCustomers()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customers", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void updateCustomerPoint(Customer customer)
        {
            string query = "UPDATE Customers SET customer_point = @Point WHERE customer_phone = '" + customer.PhoneNumber+ "' and customer_name = '"+customer.Name+"';";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Point", SqlDbType.NVarChar));
                    command.Parameters["@Point"].Value = customer.Point;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
    }
}
