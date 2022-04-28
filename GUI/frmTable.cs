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

namespace GUI
{
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();
            createTable();
        }
        void createTable()
        {
            
            List<btnTable> btnTables = new List<btnTable>();
            int k = 1;
            for (int i=0; i<=4; i++)
            {
                for (int j=0; j<=5; j++)
                {
                    btnTable btnTablec = new btnTable
                    { 
                        Location = new Point(j * 90, i*80)
                    };
                    btnTablec.Click += BtnTablec_Click;
                    btnTablec.NumericalOrder(k);
                    k++;
                    btnTables.Add(btnTablec);
                    this.panel1.Controls.Add(btnTablec);
                    /* 
                     * bàn trống = 1 đang dùng = 2 đặt bàn = 3
                     * có 1 list lưu table từ CSDL
                     * chạy dòng for hết list bàn
                     *  if (table.state == 1 (trống) )
                     *      btnTablec.Color = Color.white
                     */
                }
            }
        }

        private void BtnTablec_Click(object sender, EventArgs e)
        {
            
            frmTableDetail formTableDetail = new frmTableDetail();
            formTableDetail.Show();
            this.Visible = false;
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
