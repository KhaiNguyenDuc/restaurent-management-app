using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Model;
namespace GUI
{
    public partial class frmAddAccount : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        Account account = new Account();
        AdminBUS adminBUS = new AdminBUS();
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            account.Username = txtUserName.Text;
            account.Password = txtPassword.Text;
            account.Type = Properties.Settings.Default.Staff_Type;
            
            if (account.Type == 0)
            {
                adminBUS.insertAdmins(Properties.Settings.Default.AdminName);
                account.AdminID = adminBUS.getLatestID();
                accountBUS.insertAdminAccounts(account);
            }
            else
            {
                accountBUS.addAccounts(account);
            }
            MessageBox.Show("Thêm tài khoản thành công");

            account.Username = "";
            account.Password = "";
            this.Close();
        }
    }
}
