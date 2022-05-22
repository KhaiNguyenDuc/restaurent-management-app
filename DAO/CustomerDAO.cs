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
            string query = "INSERT INTO Customers (customer_name,customer_phone) VALUES (@Name,@PhoneNumber)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = customer.Name;
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                    command.Parameters["@PhoneNumber"].Value = customer.PhoneNumber;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void insertWithPoint(Customer customer)
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
            catch
            {
                MessageBox.Show("lalal");
                return null;
            }
        }

        public void updateCustomerPoint(Customer customer)
        {
            string query = "UPDATE Customers SET customer_point = customer_point +  @Point WHERE customer_phone = '" + customer.PhoneNumber+ "' and customer_name = N'"+customer.Name+"';";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Point", SqlDbType.Int));
                    command.Parameters["@Point"].Value = customer.Point;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        public int getPoint(Customer customer)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT customer_point FROM Customers WHERE customer_phone = '" + customer.PhoneNumber + "' and customer_name = N'" + customer.Name + "';", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["customer_point"]);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public void updateToZeroPoint(Customer customer)
        {
            string query = "UPDATE Customers SET customer_point = 0 WHERE customer_phone = '" + customer.PhoneNumber + "' and customer_name = N'" + customer.Name + "';";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        public DataTable getCustomersAsName()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id as ID, customer_name as [Tên], customer_phone as [Số điện thoại], customer_point as [Điểm] FROM Customers", conn);
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
        public void deleteCustomers(int customerID)
        {
            string query = "DELETE FROM customers WHERE id = " + customerID + ";";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void updateCustomers(Customer customer)
        {
            string query = "UPDATE customers SET customer_name = @Name, customer_phone = @PhoneNumber, customer_point = @Point WHERE id = " + customer.Id;

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
        public DataTable getCustomerByTableID(int tableID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT customer_name, customer_phone FROM customers WHERE customers.id = (SELECT orders.customer_id FROM orders WHERE orders.id = (SELECT TOP 1 id FROM orders WHERE table_id = "+ tableID+ " ORDER BY id DESC))", conn);
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
        public int getIdByNameAndPhone(Customer customer)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id FROM customers WHERE customer_phone = '" + customer.PhoneNumber + "' and customer_name = N'" + customer.Name + "';", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["id"]);
            }
            catch
            {
                MessageBox.Show("oooo");
                return -1;
            }
        }
    }
}
