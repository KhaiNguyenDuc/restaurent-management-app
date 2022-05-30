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
using Model;
using BUS;
namespace GUI
{
    public partial class frmProfile : Form
    {
        StaffBUS staffBUS = new StaffBUS();
        AccountBUS accountBUS = new AccountBUS();
        Account account = new Account();
        Staff staff = new Staff();
        public frmProfile()
        {
            InitializeComponent();
            staff.AccountID = accountBUS.getAccountID(Properties.Settings.Default.Username);
            staff = staffBUS.getStaffByAccountNotSalary(staff.AccountID);
            loadStaff();
        }
        public void loadStaff()
        {

            txtStaffName.Text = staff.Name;
            txtPhoneNumber.Text = staff.PhoneNumber;
            txtAddress.Text = staff.Address;

            if (staff.Gender == 0)
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }

            dtbStaffBirthDate.Value = staff.Birthday;
            
            string path = staff.Path;
            if (path != "")
            {
                pbStaffImage.Image = Image.FromFile(path);
                pbStaffImage.Text = path; 
            }
            else
            {
                pbStaffImage.Image = null;
                pbStaffImage.Text = "";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    
        private void frmProfile_Load(object sender, EventArgs e)
        {

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

        private void frmProfile_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            staff.Name = txtStaffName.Text;
            staff.PhoneNumber = txtPhoneNumber.Text;
            staff.Address = txtAddress.Text;

            if (rdoMale.Checked == true)
            {
                staff.Gender = 0;
            }
            else
            {
                staff.Gender = 1;
            }

            staff.Birthday = dtbStaffBirthDate.Value;

            staff.Path = pbStaffImage.Text;

            staffBUS.updateStaffs(staff);
            MessageBox.Show("Sửa thành công");
                  
        }
    }
}
