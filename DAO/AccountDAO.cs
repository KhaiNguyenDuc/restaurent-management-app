using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    public class AccountDAO
    {
        SqlConnection conn = Config.getConnection();

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
    }
}
