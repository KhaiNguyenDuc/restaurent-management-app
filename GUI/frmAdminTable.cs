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
    public partial class frmAdminTable : Form
    {
        TableBUS tableBUS = new TableBUS();
        Table table = new Table();
        public int indexRow;
        AccountBUS accountBUS = new AccountBUS();
        public frmAdminTable()
        {
            InitializeComponent();
            lblAdminNameData.Text = accountBUS.getStaffName(Properties.Settings.Default.Username);
            loadTables();
        }
        public void loadTables()
        {
            this.dtgvTable.DataSource = tableBUS.getTables();
            this.dtgvTable.Columns[0].FillWeight = 40;
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

        private void dtgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadContent()
        {
            table.Type = cbcType.Text;
            table.TableNumber = txtTableID.Text;
            string location = cbcLocation.Text;
            if (location.Equals("Khu A (VIP)"))
            {
                table.Location = "A";
            }
            else if (location.Equals("Khu B"))
            {
                table.Location = "B";
            }
            else if (location.Equals("Khu C"))
            {
                table.Location = "C";
            }
        }
        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTable.Rows[e.RowIndex];
                try
                {
                    table.TableNumber = txtTableID.Text;
                  
                    
                    table.Type = cbcType.Text;
                    table.Id = Convert.ToInt32(row.Cells[0].Value);
                    txtTableID.Text = row.Cells[1].Value.ToString();
                    string location = row.Cells[4].Value.ToString();
                    table.Location = location;
                    if (location.Equals("A"))
                    {
                        cbcLocation.SelectedIndex = cbcLocation.FindStringExact("Khu A (VIP)");
                       
                    }
                    else if (location.Equals("B"))
                    {
                        cbcLocation.SelectedIndex = cbcLocation.FindStringExact("Khu B");
                    }
                    else if (location.Equals("C"))
                    {
                        cbcLocation.SelectedIndex = cbcLocation.FindStringExact("Khu C");
                    }
                    else if (location.Equals("D"))
                    {
                        cbcLocation.SelectedIndex = cbcLocation.FindStringExact("Khu D");
                    }
                    string type = row.Cells[2].Value.ToString();
                    if (type.Equals("VIP"))
                    {
                        cbcType.SelectedIndex = cbcType.FindStringExact("VIP");
                    }
                    else if (type.Equals("Thường"))
                    {
                        cbcType.SelectedIndex = cbcType.FindStringExact("Thường");
                    }

                }
                catch
                {

                }

            }

        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            loadContent();
            tableBUS.addTables(table);

            txtTableID.Text = "";
            loadTables();
            MessageBox.Show("Thêm thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loadContent();
            tableBUS.deleteTables(table.Id);

            txtTableID.Text = "";
            loadTables();
            MessageBox.Show("Xóa thành công");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            loadContent();

            tableBUS.updateTables(table);

            
            loadTables();
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

        private void frmAdminTable_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
