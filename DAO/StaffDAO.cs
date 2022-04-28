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
            string query = "INSERT INTO staffs (staff_name,gender,birthdate,staff_address,phone_number) VALUES (@Name,@Gender,@Birthdate,@Address,@PhoneNumber)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                    command.Parameters["@Name"].Value = staff.Name;
                    command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar));
                    command.Parameters["@Gender"].Value = staff.Gender;
                    command.Parameters.Add(new SqlParameter("@Birthdate", SqlDbType.Date));
                    command.Parameters["@Birthdate"].Value = staff.Birthday;
                    command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar));
                    command.Parameters["@Address"].Value = staff.Address;
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                    command.Parameters["@PhoneNumber"].Value = staff.PhoneNumber;
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
                SqlCommand command = new SqlCommand("SELECT id as ID, staff_name as [Tên], gender as [Giới tính], birthdate as [Ngày sinh], staff_address as [Địa chỉ], phone_number as [SDT], salary as [Lương]  FROM staffs", conn);
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
