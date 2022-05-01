using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;
namespace BUS
{
    public class AdminBUS
    {
        AdminDAO adminDAO = new AdminDAO();
        public void insertAdmins(string adminName)
        {
            adminDAO.insertAdmins(adminName);
        }
        public void deleteAdmins(int adminID)
        {
            adminDAO.deleteAdmins(adminID);
        }
        public int getLatestID()
        {
            return adminDAO.getLatestID();
        }
        public bool isOldAdmins(int staffID)
        {
            DataTable data = adminDAO.isOldAdmins(staffID);
            return data.Rows[0]["admin_id"]!=DBNull.Value;
        }
        //public void getAdminID
        
    }
}
