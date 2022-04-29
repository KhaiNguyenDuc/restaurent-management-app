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
    public partial class frmTableDetail : Form
    {
        OrderFoodBUS orderBUS = new OrderFoodBUS();
        TableBUS tableBUS = new TableBUS();
        Customer customer = new Customer();
        CustomerBUS customerBUS = new CustomerBUS();
        public frmTableDetail()
        {
            InitializeComponent(); 
            loadOrderItems();
            lblTableIDdata.Text = btnTable.tableName;
            loadStatus();
        }
        public bool SaveCustomers()
        {
            customer.Name = txtNameCustomer.Text;
            customer.PhoneNumber = txtPhoneNumber.Text ;
            customer.Point = calPoint();
            if(customer.Name == "")
            {
                MessageBox.Show("Tên không được trống");
                return false;
            }
            if (customer.PhoneNumber == "")
            {
                MessageBox.Show("Số điện thoại không được trống");
                return false;
            }
            return true;

        }
        public int calPoint()
        {
            int total = 0;
            int point = 0;
            for (int i = 0; i < dtgvOrderItems.Rows.Count - 1; i++)
            {
                total = total + Convert.ToInt32( dtgvOrderItems.Rows[i].Cells[2].Value.ToString());
            }
            point =Convert.ToInt32( Math.Round((1.0 * total) / 10000));
            
            return point;
        }
        public void loadStatus()
        {
            int status = tableBUS.getStatus(btnTable.tableName);
            if(status == 0)
            {
                cbcStatus.SelectedIndex = cbcStatus.FindStringExact("Trống");
            }
            else if(status == 1)
            {
                cbcStatus.SelectedIndex = cbcStatus.FindStringExact("Đặt bàn");
            }
            else if (status == 2)
            {
                cbcStatus.SelectedIndex = cbcStatus.FindStringExact("Đang dùng");
            }

        }
        public void loadOrderItems()
        {
            this.dtgvOrderItems.DataSource = orderBUS.getOrderItems(Convert.ToInt32(btnTable.tableName));
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            new frmCheckout().ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }
        void OpenFrmCheckout(object obj)
        {
            Application.Run(new frmCheckout());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTable);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }
        void OpenFrmTable(object obj)
        {
            Application.Run(new frmTable());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTable);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
        }

        private void pnlSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool result = SaveCustomers();
            if (result == false)
            {
                return;
            }
            if (this.dtgvOrderItems.Rows.Count <= 1)
            {
                MessageBox.Show("Bàn chưa có thức ăn");
                return;
            }
            if (customerBUS.isOldCustomer(customer))
            {
                customerBUS.updateCustomerPoint(customer);
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                customerBUS.insertCustomers(customer);
                MessageBox.Show("Lưu thành công");
            }

            
        }
    }
}
