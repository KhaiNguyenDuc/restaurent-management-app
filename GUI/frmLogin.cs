using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Model;
namespace GUI
{
    public partial class frmLogin : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        public frmLogin()
        {
           
            
            InitializeComponent();
           

        }
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = txtUserName.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();

            Account account = new Account(txtUserName.Text, txtPassword.Text);
            int result = accountBUS.Authenticate(account);
            if (result == 2)
            {
                MessageBox.Show("Không tồn tại tài khoảng");
            }
            else if(result == 0)
            {
                this.Close();
                Thread thread = new Thread(OpenFrmAdminFood);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (result == 3)
            {
                MessageBox.Show("Mật khẩu sai");
            }
            else
            {
                this.Close();
                Thread thread = new Thread(OpenFrmTable);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            
        }

        private void OpenFrmAdminFood(object obj)
        {
            Application.Run(new frmAdminFood());
        }
        private void OpenFrmTable(object obj)
        {
            Application.Run(new frmTable());
        }
        private void OpenFrmRegister(object obj)
        {
            
            Application.Run(new frmRegister());
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
