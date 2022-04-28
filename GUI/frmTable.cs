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
        public frmTable()
        {
            InitializeComponent();
            createTable();
        }
        void createTable()
        {
            string state = "";
            List<btnTable> btnTables = new List<btnTable>();
            DataTable tables = tableBUS.getTables();
            int j = 0;
            int a = 0;
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
                        // 0: trống ( xanh), 1: Đặt ( vàng ), 2: đang dùng ( đỏ)
                        state = tables.Rows[a++]["Trạng Thái"].ToString();
                        if(state.Equals("1"))
                        {
                            btnTablec.BackColor = Color.Yellow;
                        }
                        else if(state.Equals("2"))
                        {
                            btnTablec.BackColor = Color.Red;
                        }
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
                        state = tables.Rows[a++]["Trạng Thái"].ToString();
                        if (state.Equals("1"))
                        {
                            btnTablec.BackColor = Color.Yellow;
                        }
                        else if (state.Equals("2"))
                        {
                            btnTablec.BackColor = Color.Red;
                        }
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
                state = tables.Rows[a++]["Trạng Thái"].ToString();
                if (state.Equals("1"))
                {
                    btnTablec.BackColor = Color.Yellow;
                }
                else if (state.Equals("2"))
                {
                    btnTablec.BackColor = Color.Red;
                }
                this.pnlTable.Controls.Add(btnTablec);
            }


        }

        private void BtnTablec_Click(object sender, EventArgs e)
        {
            
            frmTableDetail formTableDetail = new frmTableDetail();
            formTableDetail.ShowDialog();
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
    }
}
