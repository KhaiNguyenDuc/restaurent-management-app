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
        public void addProfileStaffs(Staff staff)
        {
            staffDAO.insertProfileStaffs(staff);
        }
        public void deleteStaffs(int staffID)
        {
            staffDAO.deleteStaffs(staffID);
        }
        public string getImage(int id)
        {
            return staffDAO.getImage(id);
        }
        public int getAccountIDByStaffID(int staffID)
        {
            return staffDAO.getAccountIDByStaffID(staffID);
        }
        public void updateStaffs(Staff staff)
        {
            staffDAO.updateStaffs(staff);
        }
        public Staff getStaffByAccountID(int accountID)
        {
            Staff staff = new Staff();
            DataTable data = staffDAO.getStaffByAccountID(accountID);
            staff.Name = data.Rows[0]["staff_name"].ToString();
            staff.PhoneNumber = data.Rows[0]["phone_number"].ToString();
            staff.Salary = Convert.ToDouble(data.Rows[0]["salary"]);
            staff.Path = data.Rows[0]["image_url"].ToString();
            staff.Gender = Convert.ToInt32(data.Rows[0]["gender"]);
            staff.Birthday = Convert.ToDateTime(data.Rows[0]["birthdate"]);
            staff.Address = data.Rows[0]["staff_address"].ToString();
            staff.ID = Convert.ToInt32(data.Rows[0]["id"]);
            return staff;

        }
    }
}
