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
    public partial class frmAdminIngredient : Form
    {
        public int indexRow;
        IngredientBUS ingredientBUS = new IngredientBUS();
        Ingredient ingredient = new Ingredient();
        AccountBUS accountBUS = new AccountBUS();
        public frmAdminIngredient()
        {
            InitializeComponent();
            lblAdminNameData.Text = accountBUS.getStaffName(Properties.Settings.Default.Username);
            loadIngredient();
        }
        public void loadIngredient()
        {
            this.dtgvIngredient.DataSource = ingredientBUS.getIngredients();
            this.dtgvIngredient.Columns[0].FillWeight = 40;
        }
        void OpenFrmAdminStaff(object obj)
        {
            Application.Run(new frmAdminStaff());
        }
        void OpenFrmAdminFood(object obj)
        {
            Application.Run(new frmAdminFood());
        }
        void OpenFrmAdminTable(object obj)
        {
            Application.Run(new frmAdminTable());
        }
        public void OpenFrmAdminIngredient()
        {
            Application.Run(new frmAdminIngredient());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminFood);
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

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminIngredient);
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
        void OpenFrmAnalysis(object obj)
        {
            Application.Run(new frmAnalysis());
        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAnalysis);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void dtgvIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvIngredient.Rows[e.RowIndex];
                try
                {
                    ingredient.Id = Convert.ToInt32(row.Cells[0].Value);
                    ingredient.Name = row.Cells[1].Value.ToString();
                    ingredient.Quantity = Convert.ToInt32(row.Cells[2].Value);
                    ingredient.Price = Convert.ToDouble(row.Cells[3].Value);

                    txtIngredientName.Text = ingredient.Name;
                    nudQuantity.Value = ingredient.Quantity;
                    txtPrice.Text = ingredient.Price.ToString();

                }
                catch
                {
                   // MessageBox.Show("Lỗi dữ liệu");
                }

            }
        }

        private void dtgvIngredient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ingredient.Name = txtIngredientName.Text;
            ingredient.Quantity = Convert.ToInt32(nudQuantity.Value);
            ingredient.Price = Convert.ToDouble(txtPrice.Text);

            ingredientBUS.addIngredients(ingredient);

            txtIngredientName.Text = "";
            nudQuantity.Value = 0;
            txtPrice.Text = "";
            loadIngredient();
            MessageBox.Show("Thêm thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ingredientBUS.deleteIngredients(ingredient.Id);

            txtIngredientName.Text = "";
            nudQuantity.Value = 0;
            txtPrice.Text = "";
            loadIngredient();
            MessageBox.Show("Xóa thành công");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ingredient.Name = txtIngredientName.Text;
            ingredient.Quantity = Convert.ToInt32(nudQuantity.Value);
            ingredient.Price = Convert.ToDouble(txtPrice.Text);

            ingredientBUS.updateIngredients(ingredient);

            txtIngredientName.Text = "";
            nudQuantity.Value = 0;
            txtPrice.Text = "";
            loadIngredient();
            MessageBox.Show("Sửa thành công");
        }
        public void OpenFrmAdminCustomer()
        {
            Application.Run(new frmAdminCustomer());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminCustomer);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void frmAdminIngredient_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            frmScheduler frmScheduler = new frmScheduler();
            frmScheduler.ShowDialog();
        }

    }
}
