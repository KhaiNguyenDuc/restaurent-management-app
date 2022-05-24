using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AnalysisDAO
    {
        SqlConnection conn = Config.getConnection();
        public DataTable getSumSalary()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Staffs", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public DataTable getIngredientsPrice()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Ingredients", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public DataTable getOrder()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Orders", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
