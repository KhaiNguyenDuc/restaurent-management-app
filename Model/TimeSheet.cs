using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TimeSheet
    {
        private int id;
        private int staffID;
        private DateTime startTime;
        private DateTime endTime;
        private int color;
        private string location;
        public int Id { get => id; set => id = value; }
        public int StaffID { get => staffID; set => staffID = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int Color { get => color; set => color = value; }
        public string Location { get => location; set => location = value; }

        public TimeSheet(int id, int staffID, DateTime startTime, DateTime endTime)
        {
            this.id = id;
            this.staffID = staffID;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public TimeSheet()
        {
        }
    }
}
