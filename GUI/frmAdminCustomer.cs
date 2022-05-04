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
    public partial class frmAdminCustomer : Form
    {
        public int indexRow;
        CustomerBUS customerBUS = new CustomerBUS();
        Customer customer = new Customer();
        AccountBUS accountBUS = new AccountBUS();
        public frmAdminCustomer()
        {
            InitializeComponent();
            lblAdminNameData.Text = accountBUS.getStaffName(Properties.Settings.Default.Username);
            loadCustomers();
        }
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }
        void OpenFrmAdminFood(object obj)
        {
            Application.Run(new frmAdminFood());
        }
        void OpenFrmAdminStaff(object obj)
        {
            Application.Run(new frmAdminStaff());
        }
        void OpenFrmAdminTable(object obj)
        {
            Application.Run(new frmAdminTable());
        }
        void OpenFrmAnalysis(object obj)
        {
            Application.Run(new frmAnalysis());
        }
        public void loadCustomers()
        {
            this.dtgvCustomer.DataSource = customerBUS.getCustomersAsName();
            this.dtgvCustomer.Columns[0].FillWeight = 40;
        }

        public void OpenFrmAdminCustomer()
        {
            Application.Run(new frmAdminCustomer());
        }
        public void OpenFrmAdminIngredient()
        {
            Application.Run(new frmAdminIngredient());
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminCustomer);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminFood);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminIngredient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminStaff);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminTable);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvCustomer.Rows[e.RowIndex];
                try
                {
                    customer.Id = Convert.ToInt32(row.Cells[0].Value);
                    txtCustomerName.Text = row.Cells[1].Value.ToString();
                    txtPhoneNumber.Text = row.Cells[2].Value.ToString();
                    nudPoint.Value = Convert.ToInt32(row.Cells[3].Value);
                    customer.Name = txtCustomerName.Text;
                    customer.PhoneNumber = txtPhoneNumber.Text;
                    customer.Point = Convert.ToInt32(nudPoint.Value);
                }
                catch
                {
                    MessageBox.Show("error");
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customer.Name = txtCustomerName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.Point = Convert.ToInt32(nudPoint.Value);

            customerBUS.addCustomers(customer);
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            nudPoint.Value = 0;
            loadCustomers();
            MessageBox.Show("Thêm thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customer.Name = txtCustomerName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.Point = Convert.ToInt32(nudPoint.Value);
            customerBUS.deleteCustomers(customer.Id);

            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            nudPoint.Value = 0;
            loadCustomers();
            MessageBox.Show("Xóa thành công");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            customer.Name = txtCustomerName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.Point = Convert.ToInt32(nudPoint.Value);

            customerBUS.updateCustomers(customer);
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            nudPoint.Value = 0;
            loadCustomers();
            MessageBox.Show("Sửa thành công");
        }

        private void frmAdminCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
