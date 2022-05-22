using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;
using System.Data;

namespace BUS
{
    public class TimeSheetBUS
    {
        TimeSheetDAO timeSheetDAO = new DAO.TimeSheetDAO();
        public List<TimeSheet> getTimeSheets()
        {
            List<TimeSheet> timeSheet = new List<TimeSheet>();
            DataTable data = timeSheetDAO.getTimeSheets();
            foreach(DataRow row in data.Rows)
            {
                TimeSheet ts = new TimeSheet();
                ts.Id = Convert.ToInt32(row["id"]); 
                ts.StaffID = Convert.ToInt32(row["staff_id"]);
                ts.StartTime = DateTime.Parse(row["start_time"].ToString());
                ts.EndTime = DateTime.Parse(row["end_time"].ToString());
                ts.Color = Convert.ToInt32(row["color"]);
                ts.Location = row["ts_location"].ToString();
                timeSheet.Add(ts);
            }
            return timeSheet;
        }
        public void updateSheets(TimeSheet timeSheet)
        {
            timeSheetDAO.updateSheets(timeSheet);
        }
        public void deleteSheet(int staffID, DateTime start,DateTime end)
        {
            timeSheetDAO.deleteSheet(staffID, start,end);
        }
        public void deleteAllSheets()
        {
            timeSheetDAO.deleteAllSheets();
        }
        public void addSheets(TimeSheet timeSheet)
        {
            timeSheetDAO.addSheets(timeSheet);
        }
    }
}
