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
    public class AccountDAO
    {
        SqlConnection conn = Config.getConnection();
        public void insertAdminAccounts(Account account)
        {
            string query = "INSERT INTO accounts (account_user_name,account_password,account_type,admin_id) VALUES (@Username,@Password,@Type,@AdminID)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
                    command.Parameters["@Username"].Value = account.Username;
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
                    command.Parameters["@Password"].Value = account.Password;
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    command.Parameters["@Type"].Value = account.Type;
                    command.Parameters.Add(new SqlParameter("@AdminID", SqlDbType.Int));
                    command.Parameters["@AdminID"].Value = account.AdminID;
                    command.ExecuteNonQuery(); 
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void insertAccounts(Account account)
        {
            string query = "INSERT INTO accounts (account_user_name,account_password,account_type) VALUES (@Username,@Password,@Type)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
                    command.Parameters["@Username"].Value = account.Username;
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
                    command.Parameters["@Password"].Value = account.Password;
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    command.Parameters["@Type"].Value = account.Type;
                    
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public DataTable getAccounts()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM accounts", conn);
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
        public string getStaffName(string username)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT s.staff_name FROM accounts a inner join staffs s on a.id = s.account_id WHERE a.account_user_name = '"+username+"';", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data.Rows[0]["staff_name"].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public int getAccountID(string username)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id FROM accounts WHERE account_user_name = '" + username + "';", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["id"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public int getLatestID()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM accounts ORDER BY id DESC", conn);
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
        public int getAdminID(int accountID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT admin_id FROM accounts   WHERE accounts.id = " + accountID + ";", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["admin_id"]);
            }
            catch
            {
                return -1;
            }
        }
        public void deleteAccounts(int accountID)
        {
            string query = "DELETE FROM accounts WHERE id = " + accountID + ";";
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
        public void updatePermission(int type, int adminID, int accountID)
        {
            string query = "UPDATE accounts SET account_type = @Type, admin_id = @AdminID WHERE id = " + accountID;

            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    command.Parameters["@Type"].Value = type;
                    command.Parameters.Add(new SqlParameter("@AdminID", SqlDbType.Int));
                    command.Parameters["@AdminID"].Value = adminID;
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
