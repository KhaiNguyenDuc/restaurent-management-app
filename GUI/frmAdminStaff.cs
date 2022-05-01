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
    public partial class frmAdminStaff : Form
    {
        public int indexRow;
        StaffBUS staffBUS = new StaffBUS();
        Staff staff = new Staff();
        frmAddAccount addAccount = new frmAddAccount();
        AccountBUS accountBUS = new AccountBUS();
        AdminBUS adminBUS = new AdminBUS();
        public frmAdminStaff()
        {
            InitializeComponent();
            loadStaffs();
        }
        public void loadStaffs()
        {
            this.dtgvStaff.DataSource = staffBUS.getStaffs(); 
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }

        private void dtgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvStaff.Rows[e.RowIndex];
                try
                {
                    
                    txtStaffName.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value.ToString().Equals("0"))
                    {
                        rdoMale.Checked = true;
                    }
                    else
                        rdoFemale.Checked = true;

                    dtpBirthDate.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                   
                    txtAddress.Text = row.Cells[4].Value.ToString();
                    txtPhoneNumber.Text = row.Cells[5].Value.ToString();
                    txtSalary.Text = row.Cells[6].Value.ToString();
                    staff.ID = Convert.ToInt32(row.Cells[0].Value);

                    string path = staffBUS.getImage(Convert.ToInt32(row.Cells[0].Value));
                    if (path != "")
                    {
                        pbStaffImage.Image = Image.FromFile(path);
                    }
                    
                    if (row.Cells[7].Value.ToString().Equals("0"))
                    {

                        cbAdmin.Checked = true;
                    }
                    else
                    {
                        cbAdmin.Checked = false;
                    }

                }
                catch
                {

                }

            }
        }

        private void frmAdminStaff_Load(object sender, EventArgs e)
        {

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
                pbStaffImage.Image = new Bitmap(open.FileName);
                // image file path  
                pbStaffImage.Text = open.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            

            try
            {
                if (txtStaffName.Text == "" || txtSalary.Text == "" || txtPhoneNumber.Text == ""||txtAddress.Text=="")
                {
                    MessageBox.Show("Thiếu thông tin nhân viên");
                    return;
                }
                if (cbAdmin.Checked)
                {
                    Properties.Settings.Default.Staff_Type = 0;
                }
                else
                {
                    Properties.Settings.Default.Staff_Type = 1;
                }
                Properties.Settings.Default.AdminName = txtStaffName.Text;
                addAccount.ShowDialog();
                staff.Name = txtStaffName.Text;
                staff.PhoneNumber = txtPhoneNumber.Text;
                staff.Salary = Convert.ToDouble(txtSalary.Text);
                staff.Path = pbStaffImage.Text;
                staff.Address = txtAddress.Text;
                if(rdoMale.Checked)
                {
                    staff.Gender = 0;
                }
                else
                {
                    staff.Gender = 1;
                }
                staff.Birthday = dtpBirthDate.Value;
                staff.AccountID = accountBUS.getLatestID();
                staffBUS.addProfileStaffs(staff);
                MessageBox.Show("Thêm thành công");
                loadStaffs();
            }
            catch
            {
                MessageBox.Show("Thông tin sai");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int accountID = staffBUS.getAccountIDByStaffID(staff.ID);
            int adminID = accountBUS.getAdminID(accountID);
            staffBUS.deleteStaffs(staff.ID);
            accountBUS.deleteAccounts(accountID);
            adminBUS.deleteAdmins(adminID);
            staff.Name = "";
            staff.PhoneNumber = "";
            staff.Salary = 0;
            staff.Path = "";
            staff.Address = "";
            rdoMale.Checked = true;
            staff.Birthday = DateTime.Now;
            cbAdmin.Checked = false;
            MessageBox.Show("Xóa thành công");
            loadStaffs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            staff.Name = txtStaffName.Text;
            staff.PhoneNumber = txtPhoneNumber.Text;
            staff.Salary = Convert.ToDouble(txtSalary.Text);
            staff.Path = pbStaffImage.Text;
            staff.Address = txtAddress.Text;
            
            if(rdoFemale.Checked == true)
            {
                staff.Gender = 1;
            }
            else
            {
                staff.Gender = 0;
            }
          
            staff.Birthday = dtpBirthDate.Value;
            if (cbAdmin.Checked)
            {
                if (adminBUS.isOldAdmins(staff.ID))
                { 
                    // update admin cũ 
                    staffBUS.updateStaffs(staff);
                    accountBUS.updatePermission(0, adminBUS.getLatestID(), staffBUS.getAccountIDByStaffID(staff.ID));
                    MessageBox.Show("Sửa thành công");
                    loadStaffs();
                    return;
                }
                // người thường thành admin
                adminBUS.insertAdmins(staff.Name);
                accountBUS.updatePermission(0, adminBUS.getLatestID(),staffBUS.getAccountIDByStaffID(staff.ID));
                staffBUS.updateStaffs(staff);
            }
            else
            {
                // update người thường
                if (!adminBUS.isOldAdmins(staff.ID))
                {
                    staffBUS.updateStaffs(staff);
                }
                else
                {
                    // admin thành người thường
                    
                    int accountID = staffBUS.getAccountIDByStaffID(staff.ID);
                    accountBUS.updatePermission(1, accountBUS.getAdminID(accountID), accountID);
                    staffBUS.updateStaffs(staff);
               
                }
            }
            MessageBox.Show("Sửa thành công");
            loadStaffs();
            

        }
    }
}
