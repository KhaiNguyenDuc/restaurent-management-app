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
    public partial class frmAdminFood : Form
    {
        public int foodID;
        public int indexRow;
        FoodBUS foodBUS = new FoodBUS();
        Food food = new Food();
        public static int LatestID;
        AccountBUS accountBUS = new AccountBUS();
        public frmAdminFood()
        {
            InitializeComponent();
            lblAdminNameData.Text = accountBUS.getStaffName(Properties.Settings.Default.Username);
            loadFoods();
        }
        public void loadFoods()
        {
            this.dtgvFood.DataSource = foodBUS.getFoods();
            this.dtgvFood.Columns[0].FillWeight = 40;
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminFood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.restaurantManagementDataSet.Foods);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
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

        private void Analysis_Click(object sender, EventArgs e)
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

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrice.Enabled = true;
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvFood.Rows[e.RowIndex];
                try
                {
                    foodID = Convert.ToInt32(row.Cells[0].Value);
                    food.Id = foodID;
                    txtFoodName.Text = row.Cells[1].Value.ToString();
                    txtPrice.Text = row.Cells[2].Value.ToString();
                    txtType.Text = row.Cells[3].Value.ToString();
                    string path = foodBUS.getImage(Convert.ToInt32(row.Cells[0].Value));
                    pBFoodImage.Image = Image.FromFile(path);
                }
                catch
                {

                }

            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtPrice.Enabled = false;
            try
            {
                if (txtFoodName.Text == "" || txtType.Text == "")
                {
                    MessageBox.Show("Thiếu thông tin thức ăn");
                    return;
                }
                food.Name = txtFoodName.Text;
                food.Price = 0;
                food.Type = Convert.ToInt32(txtType.Text);
                food.Path = pBFoodImage.Text;
                foodBUS.insertFoods(food);

                LatestID = foodBUS.getLatestID();
                frmAddRecipe form = new frmAddRecipe();
                form.ShowDialog();

                txtFoodName.Text = "";
                txtPrice.Text = "";
                txtType.Text = "";
                loadFoods();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thông tin sai");
            }
           
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pBFoodImage.Image = new Bitmap(open.FileName);
                // image file path  
                pBFoodImage.Text = open.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foodBUS.deleteFoods(foodID);
            txtFoodName.Text = "";
            txtPrice.Text = "";
            txtType.Text = "";
            loadFoods();
            MessageBox.Show("Xóa thành công");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            food.Name = txtFoodName.Text;
            food.Price = Convert.ToDouble(txtPrice.Text);
            food.Type = Convert.ToInt32(txtType.Text);
            food.Path = pBFoodImage.Text;
            foodBUS.updateFoods(food);

            
            loadFoods();
            MessageBox.Show("Sửa thành công");
        }
        public void OpenFrmAdminIngredient()
        {
            Application.Run(new frmAdminIngredient());
        }
        private void btnIngredient_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminIngredient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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

        private void frmAdminFood_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
