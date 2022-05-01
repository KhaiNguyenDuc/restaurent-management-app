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
    public class AdminDAO
    {
        SqlConnection conn = Config.getConnection();
        public void insertAdmins(string adminName)
        {
            
            string query = "INSERT INTO admins (admin_name) VALUES (@Name)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = adminName;        
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("insertAdmin");
            }
        }
        public int getLatestID()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM admins ORDER BY id DESC", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["id"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public void deleteAdmins(int adminID)
        {
            string query = "DELETE FROM admins WHERE id = " + adminID + ";";
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
        public DataTable isOldAdmins(int staffID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT admin_id FROM staffs INNER JOIN accounts on staffs.account_id = accounts.id WHERE staffs.id = " + staffID + ";", conn);
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
