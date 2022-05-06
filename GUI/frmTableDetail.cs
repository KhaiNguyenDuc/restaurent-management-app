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
        OrderFoodBUS orderFoodBUS = new OrderFoodBUS();
        TableBUS tableBUS = new TableBUS();
        Customer customer = new Customer();
        FoodBUS foodBUS = new FoodBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        frmTable form = new frmTable();
        OrderBUS orderBUS = new OrderBUS();
        Order order = new Order();
        OrderFood orderFood = new OrderFood();
        IngredientBUS ingredientBUS = new IngredientBUS();
        public string foodName;
        public int indexRow;
        public static string tableName ;
        public static int total;
        public static int itemTotal;
        public frmTableDetail()
        {
           
            InitializeComponent();
            tableName = btnTable.tableName;

            // load txtbox
            /* try
             {
                 txtNameCustomer.Text = customerBUS.getNameByTableID(Convert.ToInt32(btnTable.tableName));
                 txtPhoneNumber.Text = customerBUS.getPhoneNumberByTableID(Convert.ToInt32(btnTable.tableName));
             }
             catch
             {

             }*/


            // new and don't have order
            if (!tableBUS.isNewOrder(Convert.ToInt32(btnTable.tableName)))
            {
                orderBUS.insertOrders(Convert.ToInt32(btnTable.tableName));
                try
                {
                    txtNameCustomer.Text = customerBUS.getNameByTableID(Convert.ToInt32(btnTable.tableName));
                    txtPhoneNumber.Text = customerBUS.getPhoneNumberByTableID(Convert.ToInt32(btnTable.tableName));
                }
                catch
                {

                }

            }
            else
            {
                try
                {
                    txtNameCustomer.Text = customerBUS.getNameByTableID(Convert.ToInt32(btnTable.tableName));
                    txtPhoneNumber.Text = customerBUS.getPhoneNumberByTableID(Convert.ToInt32(btnTable.tableName));
                }
                catch
                {

                }
            }
            loadOrderItems();
            lblTableIDdata.Text = btnTable.tableName;

            loadStatus();
            loadFoodName();

        }
        public bool SaveCustomers()
        {
            customer.Name = txtNameCustomer.Text;
            customer.PhoneNumber = txtPhoneNumber.Text ;
            customer.Point = calPoint();
            if(customer.Name == "" || customer.PhoneNumber == "")
            {
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
        
        public int calTotal()
        {
            int total = 0;
            for (int i = 0; i < dtgvOrderItems.Rows.Count - 1; i++)
            {
                total = total + Convert.ToInt32(dtgvOrderItems.Rows[i].Cells[2].Value.ToString());
            }
            return total;
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
            this.dtgvOrderItems.DataSource = orderFoodBUS.getOrderItems(Convert.ToInt32(btnTable.tableName));
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
            frmTable form = new frmTable();
            Application.Run(form);
           
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
           
            if (!SaveCustomers())
            {
                // ko có customer

                tableBUS.updateStatus(cbcStatus.Text, btnTable.tableName);
                MessageBox.Show("Lưu thành công");
                return;
            }
            
            //MessageBox.Show(customer.Id.ToString());
            if (this.dtgvOrderItems.Rows.Count <= 1)
            {
                MessageBox.Show("Bàn chưa có thức ăn");
                return;
            }
            if (customerBUS.isOldCustomer(customer) == 1)
            {
                // có rồi
                tableBUS.updateStatus(cbcStatus.Text, btnTable.tableName);
                customer.Id = customerBUS.getIdByNameAndPhone(customer);
                orderBUS.updateCustomersID(customer, orderBUS.getLatestOrderIDByTableID(Convert.ToInt32(btnTable.tableName)));
                MessageBox.Show("Lưu thành công");
            }
            else if(customerBUS.isOldCustomer(customer) == 2)
            {
                //  đã có số điện thoại
                MessageBox.Show("Số điện thoại đã tồn tại");
                return;
            }
            else
            {
                // chưa có tài khoản
                customerBUS.insertCustomers(customer);
                customer.Id = customerBUS.getIdByNameAndPhone(customer);
                orderBUS.updateCustomersID(customer, orderBUS.getLatestOrderIDByTableID(Convert.ToInt32(btnTable.tableName))) ;
                tableBUS.updateStatus(cbcStatus.Text, btnTable.tableName);
                MessageBox.Show("Lưu thành công");
            }
            

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvOrderItems.Rows[e.RowIndex];
                try
                {
                
                   
                    foodName = row.Cells[0].Value.ToString();
                    cbcFoodName.Text = row.Cells[0].Value.ToString();
                    
                    nudQuantity.Value = Convert.ToInt32(row.Cells[1].Value);
                    if(row.Cells[3].Value.ToString().Equals("Đã nấu"))
                    {
                        cbCooked.Checked = true;
                        cbCooked.Enabled = false;
                        nudQuantity.Enabled = false;
                    }
                    else if(row.Cells[3].Value.ToString().Equals("Chưa nấu"))
                    {
                        cbCooked.Checked = false;
                        cbCooked.Enabled = true;
                        nudQuantity.Enabled = true;
                    }
          
                }
                catch
                {
                    cbCooked.Checked = false;
                    nudQuantity.Value = 0;
                    nudQuantity.Enabled = true;
                    return;
                }

            }

        }
        public void loadFoodName()
        {
            DataTable data = foodBUS.getFoods();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                cbcFoodName.Items.Add(data.Rows[i]["Tên món"].ToString());
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if(nudQuantity.Value <= 0)
            {
                MessageBox.Show("Số lượng không thể bằng không");
                return;
            }
            if(cbCooked.Checked == true)
            {
                MessageBox.Show("Không thể thêm món ăn đã nấu");
                return;
            }
            if (orderFoodBUS.isOldOrderFoods(this.dtgvOrderItems, cbcFoodName.Text))
            {
                MessageBox.Show("Không thể thêm món đã có");
                return;
            }
            int tableID = Convert.ToInt32(lblTableIDdata.Text);
            order.TableID = tableID;
            order.Id = orderBUS.getLatestOrderIDByTableID(tableID);
            orderFood.OrderID = order.Id;
            orderFood.FoodID = foodBUS.getIDByName(cbcFoodName.Text);
            orderFood.Quantity = Convert.ToInt32(nudQuantity.Value);
            orderFood.TotalPrice = foodBUS.getPriceByID(orderFood.FoodID) * orderFood.Quantity;

            if (!ingredientBUS.isAvailable(orderFood.Quantity, orderFood.FoodID))
            {
                MessageBox.Show("Không đủ nguyên liệu");
                return;
            }

            orderFoodBUS.insertOrderFoods(orderFood);

            cbcFoodName.Text = "";
            nudQuantity.Value = 0;
            MessageBox.Show("Thêm thành công");
            loadOrderItems();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            orderFood.FoodID = foodBUS.getIDByName(cbcFoodName.Text);
            orderFoodBUS.deleteOrderFoods(orderFood.FoodID);
            cbcFoodName.Text = "";
            nudQuantity.Value = 0;
            cbCooked.Checked = false;
            MessageBox.Show("Xóa thành công");
            loadOrderItems();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int oldFoodID = foodBUS.getIDByName(foodName);
            orderFood.Quantity = Convert.ToInt32(nudQuantity.Value);
            orderFood.FoodID = foodBUS.getIDByName(cbcFoodName.Text);
            orderFood.TotalPrice = foodBUS.getPriceByID(orderFood.FoodID) * orderFood.Quantity;
            if(cbCooked.Checked == true)
            {
                orderFood.State = "Đã nấu";
            }
            else
            {
                orderFood.State = "Chưa nấu";
            }

            if (!ingredientBUS.isAvailable(orderFood.Quantity, orderFood.FoodID))
            {
                MessageBox.Show("Không đủ nguyên liệu");
                return;
            }
            orderFoodBUS.update(orderFood,oldFoodID);
            
            if(orderFood.State.Equals("Đã nấu"))
            {
                ingredientBUS.minusIngredients(orderFood.FoodID,orderFood.Quantity);
            }

            cbcFoodName.Text = "";
            nudQuantity.Value = 0;
            cbCooked.Checked = false;
            cbCooked.Enabled = false;
            MessageBox.Show("Sửa thành công");
            loadOrderItems();
        }

        private void btnPrintBill_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                DataRow dataRow =  orderFoodBUS.getOrderItems(Convert.ToInt32(btnTable.tableName)).Rows[0];
            }
            catch
            {
                MessageBox.Show("Bàn chưa có thức ăn");
                return;
            }
            // save customer
            btnSave.PerformClick();
          

            customerBUS.updateCustomerPoint(customer);
            if(cbVIP.Checked == true)
            {
                int point = customerBUS.getPoint(customer);
                int money = point*500;
                total = this.calTotal() ;
                // VAT
                total = total + Convert.ToInt32(total * 0.1);
                total = total - money;
                if (total < 0)
                {
                    total = 0;
                }
                string type = tableBUS.getTypeById(Convert.ToInt32(btnTable.tableName));
                // table VIP
                if (type.Equals("VIP"))
                {
                    total = total + 10000;
                }
         
                customer.Point = 0;
                customerBUS.updateToZeroPoint(customer);
                orderBUS.updateSumTotalAndState(orderBUS.getLatestOrderIDByTableID(Convert.ToInt32(btnTable.tableName)), total);
                tableBUS.updateStatus("Trống",btnTable.tableName);
                itemTotal = this.calTotal();
            }
            else
            {
                 total = this.calTotal();
                // VAT
                total = total + Convert.ToInt32(total * 0.1);
                string type = tableBUS.getTypeById(Convert.ToInt32(btnTable.tableName));
                // table VIP 
                if (type.Equals("VIP"))
                {
                    total = total + 10000;
                }
              
                orderBUS.updateSumTotalAndState(orderBUS.getLatestOrderIDByTableID(Convert.ToInt32(btnTable.tableName)), total);
                tableBUS.updateStatus("Trống", btnTable.tableName);
                itemTotal = this.calTotal();
            }


            this.Close();
            Thread thread = new Thread(OpenFrmCheckout);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            //this.loadOrderItems();


        }

        private void frmTableDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frmTableDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
