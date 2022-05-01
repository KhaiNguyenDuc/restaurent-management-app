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
namespace GUI
{
    public partial class frmAdminStaff : Form
    {
        public int indexRow;
        StaffBUS staffBUS = new StaffBUS();
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

                    if(row.Cells[7].Value.ToString().Equals("1"))
                    {
                        cbAdmin.Checked = true;
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
    }
}
