using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class StaffBUS
    {
        StaffDAO staff = new StaffDAO();
        public DataTable getStaffs()
        {

            return staff.getStaffs();
        }

    }
}
