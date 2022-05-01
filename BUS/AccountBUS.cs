using System;
using System.Collections;
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
    public class AccountBUS
    {
        AccountDAO accountDAO = new AccountDAO();
        
        public bool ValidateAccounts(Account account)
        {
            if (account.Password == "")
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                return false;
            }
            if (account.Username == "")
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ");
                return false;
            }
            return true;
        }
        public int Authenticate(Account account)
        {
            int accountType = 0; 
            DataTable accounts = getAccounts();
            
            for (int i = 0; i < accounts.Rows.Count;i++)
            {
                if (account.Username == accounts.Rows[i]["account_user_name"].ToString()){
                    if (account.Password == accounts.Rows[i]["account_password"].ToString()){
                        accountType = Convert.ToInt32(accounts.Rows[i]["account_type"]);
                        return accountType;
                    }
                    else
                    {
                        return 3; // password wrong
                    }
                }
            }
            return 2; // not have account, 1: staff, 0: admin
        }
        public DataTable getAccounts()
        {
            return accountDAO.getAccounts();
        }
        public void addAccounts(Account account)
        {
            accountDAO.insertAccounts(account);
        }
        public string getStaffName(string username)
        {
           return accountDAO.getStaffName(username);
        }
        public int getLatestID()
        {
            return accountDAO.getLatestID();
        }
        public void insertAdminAccounts(Account account)
        {
            accountDAO.insertAdminAccounts(account);
        }
        public int getAdminID(int accountID)
        {
            return accountDAO.getAdminID(accountID);
        }
        public void deleteAccounts(int accountID)
        {
            accountDAO.deleteAccounts(accountID);
        }
        public void updatePermission(int type, int adminID, int accountID)
        {
            accountDAO.updatePermission(type, adminID, accountID);
        }
    }
}
