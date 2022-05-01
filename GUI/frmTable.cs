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
    public partial class frmTable : Form
    { 
        TableBUS tableBUS = new TableBUS();
        AccountBUS accountBUS = new AccountBUS();
        public static int status;
        public static string defaultLocation = "Khu A (VIP)" ;


        public frmTable()
        {
            InitializeComponent();
            lblStaffNameData.Text = accountBUS.getStaffName(Properties.Settings.Default.Username);

            createTable(defaultLocation);
            cbcLocation.SelectedItem = defaultLocation;

         
        }
        void createTable(string location)
        {
            string state = "";
            List<btnTable> btnTables = new List<btnTable>();
            DataTable tables = tableBUS.getTables(location);
            int j = 0;
            int a =Convert.ToInt32(tables.Rows[0]["id"]);
            int b = 0;
            for (j = 0; j < tables.Rows.Count / 8 ; j++)
            {
                if (tables.Rows.Count < 7)
                {
                    for (int i = 0; i < tables.Rows.Count; i++)
                    {
                        btnTable btnTablec = new btnTable
                        {    
                            Location = new Point(i * 90, j * 80),
                        };
                        
                        btnTablec.Click += BtnTablec_Click;

                        // 0: trống ( xanh), 1: Đặt ( vàng ), 2: đang dùng ( đỏ)
                        state = tables.Rows[b++]["Trạng Thái"].ToString();

                        if(state.Equals("1"))
                        {
                            btnTablec.BackColor = Color.Yellow;
                        }
                        else if(state.Equals("2"))
                        {
                            btnTablec.BackColor = Color.Red;
                        }
                        btnTablec.NumericalOrder(a++);
                        this.pnlTable.Controls.Add(btnTablec);
                    }
                }
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        btnTable btnTablec = new btnTable
                        {
                            Location = new Point(i * 90, j * 80),
                        };
                        btnTablec.Click += BtnTablec_Click;
                        state = tables.Rows[b++]["Trạng Thái"].ToString();
                        if (state.Equals("1"))
                        {
                            btnTablec.BackColor = Color.Yellow;
                        }
                        else if (state.Equals("2"))
                        {
                            btnTablec.BackColor = Color.Red;
                        }
                        btnTablec.NumericalOrder(a++);
                        this.pnlTable.Controls.Add(btnTablec);
                    }
                }
            }

            for (int z = 0;z< tables.Rows.Count - j*7; z++)
            {
                btnTable btnTablec = new btnTable
                {
                    Location = new Point(z * 90, j * 80),
                };
                btnTablec.Click += BtnTablec_Click;
                state = tables.Rows[b++]["Trạng Thái"].ToString();
                if (state.Equals("1"))
                {
                    btnTablec.BackColor = Color.Yellow;
                }
                else if (state.Equals("2"))
                {
                    btnTablec.BackColor = Color.Red;
                }
                btnTablec.NumericalOrder(a++);
                this.pnlTable.Controls.Add(btnTablec);
            }


        }
        private void BtnTablec_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread thread = new Thread(OpenfrmTableDetail);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void OpenfrmTableDetail()
        {
            Application.Run(new frmTableDetail());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmProfile);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmProfile(object obj)
        {
            Application.Run(new frmProfile());
        }
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }

        private void frmTable_Load(object sender, EventArgs e)
        {

        }

        private void lblStaffName_Click(object sender, EventArgs e)
        {

        }

        private void cbcLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnlTable.Controls.Clear();
            createTable(cbcLocation.Text);
            if (!this.cbcLocation.Text.Equals("Khu A (VIP)"))
            {
                defaultLocation = cbcLocation.Text;
            }
            else
            {
                defaultLocation = "Khu A (VIP)";
            }
        }
    }
}
