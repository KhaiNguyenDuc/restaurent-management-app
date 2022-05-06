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
    public partial class frmCheckout : Form
    {
        OrderFoodBUS orderFoodBUS = new OrderFoodBUS();
        public int tableID = Convert.ToInt32(frmTableDetail.tableName);
        public frmCheckout()
        {
            InitializeComponent();
            lblTableNumberData.Text = tableID.ToString();
            int total = frmTableDetail.total;
            int itemtotal = frmTableDetail.itemTotal;
            lblFinalPriceValue.Text = total.ToString();
            lblTotalPriceValue.Text = itemtotal.ToString();
            int tax = Convert.ToInt32(itemtotal * 0.1);
            lblTaxValue.Text = tax.ToString();
            loadCheckout();
        }
        public void loadCheckout()
        {
            this.dtgvOrderFood.DataSource = orderFoodBUS.getCheckoutItems(tableID);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCheckout_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        public void OpenFrmTable()
        {
            frmTable form = new frmTable();
            Application.Run(form);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTable);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        
    }
}
