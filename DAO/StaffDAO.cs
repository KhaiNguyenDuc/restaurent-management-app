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
    public class StaffDAO
    {
        SqlConnection conn = Config.getConnection();

        public void insertStaffs(Staff staff)
        {
            string query = "INSERT INTO staffs (staff_name,gender,birthdate,staff_address,phone_number,account_id) VALUES (@Name,@Gender,@Birthdate,@Address,@PhoneNumber,@AccountID)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = staff.Name;
                    command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Int));
                    command.Parameters["@Gender"].Value = staff.Gender;
                    command.Parameters.Add(new SqlParameter("@Birthdate", SqlDbType.Date));
                    command.Parameters["@Birthdate"].Value = staff.Birthday;
                    command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar));
                    command.Parameters["@Address"].Value = staff.Address;
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                    command.Parameters["@PhoneNumber"].Value = staff.PhoneNumber;
                    command.Parameters.Add(new SqlParameter("@AccountID", SqlDbType.Int));
                    command.Parameters["@AccountID"].Value = staff.AccountID;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public void insertProfileStaffs(Staff staff)
        {
            string query = "INSERT INTO staffs (image_url,staff_name,gender,birthdate,staff_address,phone_number,salary,account_id) VALUES (@Path,@Name,@Gender,@Birthdate,@Address,@PhoneNumber,@Salary,@AccountID)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = staff.Name;
                    command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Int));
                    command.Parameters["@Gender"].Value = staff.Gender;
                    command.Parameters.Add(new SqlParameter("@Birthdate", SqlDbType.Date));
                    command.Parameters["@Birthdate"].Value = staff.Birthday;
                    command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar));
                    command.Parameters["@Address"].Value = staff.Address;
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                    command.Parameters["@PhoneNumber"].Value = staff.PhoneNumber;
                    command.Parameters.Add(new SqlParameter("@AccountID", SqlDbType.Int));
                    command.Parameters["@AccountID"].Value = staff.AccountID;
                    command.Parameters.Add(new SqlParameter("@Path", SqlDbType.NVarChar));
                    command.Parameters["@Path"].Value = staff.Path;
                    command.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Real));
                    command.Parameters["@Salary"].Value = staff.Salary;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
            }
        }
        public DataTable getStaffs()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT staffs.id as ID, staff_name as [Tên], gender as [Giới tính], birthdate as [Ngày sinh], staff_address as [Địa chỉ], phone_number as [SDT], salary as [Lương], accounts.account_type as [Quyền] FROM staffs INNER JOIN accounts on staffs.account_id = accounts.id", conn);
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
        public void deleteStaffs(int staffID)
        {
            string query = "DELETE FROM staffs WHERE id = " + staffID + ";";
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
        public string getImage(int id)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT image_url FROM staffs WHERE id = " + id, conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data.Rows[0]["image_url"].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public int getAccountIDByStaffID(int staffID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT account_id FROM staffs WHERE id =  "+ staffID, conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return Convert.ToInt32(data.Rows[0]["account_id"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public void updateStaffs(Staff staff)
        {
            string query = "UPDATE staffs SET image_url = @Path, staff_name = @Name, gender = @Gender, birthdate = @birthdate, staff_address = @Address, phone_number = @PhoneNumber, salary = @Salary  WHERE id = " + staff.ID;

            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Path", SqlDbType.NVarChar));
                    command.Parameters["@Path"].Value = staff.Path;
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = staff.Name;
                    command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Int));
                    command.Parameters["@Gender"].Value = staff.Gender;
                    command.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.DateTime));
                    command.Parameters["@birthdate"].Value = staff.Birthday;
                    command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar));
                    command.Parameters["@Address"].Value = staff.Address;
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                    command.Parameters["@PhoneNumber"].Value = staff.PhoneNumber;
                    command.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Real));
                    command.Parameters["@Salary"].Value = staff.Salary;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {

            }
        }
        public DataTable getStaffByAccountID(int accountID)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM staffs WHERE account_id =  " + accountID, conn);
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
