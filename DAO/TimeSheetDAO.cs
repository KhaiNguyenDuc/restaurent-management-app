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
    public class TimeSheetDAO
    {
        SqlConnection conn = Config.getConnection();
        public DataTable getTimeSheets()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TimeSheets", conn);
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
        public void updateSheets(TimeSheet timesheet)
        {
            string query = "UPDATE TimeSheets SET staff_id= @StaffID, start_time= @Start, end_time= @end , color = @Color, ts_location = @Location WHERE id = " + timesheet.Id + ";";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int));
                    command.Parameters["@StaffID"].Value = timesheet.StaffID;
                    command.Parameters.Add(new SqlParameter("@Start", SqlDbType.DateTime));
                    command.Parameters["@Start"].Value = timesheet.StartTime;
                    command.Parameters.Add(new SqlParameter("@end", SqlDbType.DateTime));
                    command.Parameters["@end"].Value = timesheet.EndTime;
                    command.Parameters.Add(new SqlParameter("@Color", SqlDbType.Int));
                    command.Parameters["@Color"].Value = timesheet.Color;
                    command.Parameters.Add(new SqlParameter("@Location", SqlDbType.NVarChar));
                    command.Parameters["@Location"].Value = timesheet.Location;


                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                Console.WriteLine("Lỗi");
            }
        }
        public void deleteSheet(int staffID, DateTime start, DateTime end)
        {
            string query = "DELETE FROM TimeSheets WHERE staff_id = " + staffID + " and start_time = '"+start+"' and end_time ='"+end+"';";
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
                Console.WriteLine("Lỗi"); ;
            }
        }
        public void deleteAllSheets()
        {
            string query = "TRUNCATE TABLE TimeSheets";
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
                Console.WriteLine("Lỗi"); ;
            }
        }
        public void addSheets(TimeSheet timeSheet)
        {
            string query = "INSERT INTO TimeSheets (staff_id,start_time,end_time,color,ts_location) VALUES (@StaffID,@Start,@End,@Color,@Location)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int));
                    command.Parameters["@StaffID"].Value = timeSheet.StaffID;
                    command.Parameters.Add(new SqlParameter("@Start", SqlDbType.DateTime));
                    command.Parameters["@Start"].Value = timeSheet.StartTime;
                    command.Parameters.Add(new SqlParameter("@End", SqlDbType.DateTime));
                    command.Parameters["@End"].Value = timeSheet.EndTime;
                    command.Parameters.Add(new SqlParameter("@Color", SqlDbType.Int));
                    command.Parameters["@Color"].Value = timeSheet.Color;
                    command.Parameters.Add(new SqlParameter("@Location", SqlDbType.NVarChar));
                    command.Parameters["@Location"].Value = timeSheet.Location;
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
