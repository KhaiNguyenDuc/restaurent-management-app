using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;
namespace BUS
{
    public class StaffBUS
    {
        StaffDAO staffDAO = new StaffDAO();
        public DataTable getStaffs()
        {
            return staffDAO.getStaffs();
        }
        public bool ValidateStaffs(Staff staff)
        {
            if (!Regex.IsMatch(staff.Name, @"^[\p{L} \.'\-]+$"))
            {
                MessageBox.Show("Tên không hợp lệ");
                return false;
            }
            if (!Regex.IsMatch(staff.PhoneNumber, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            if (staff.Address == "")
            {
                MessageBox.Show("Địa chỉ không hợp lệ");
                return false;
            }
            return true;
        }
        public void addStaffs(Staff staff)
        {
            staffDAO.insertStaffs(staff);
        }


    }
}
