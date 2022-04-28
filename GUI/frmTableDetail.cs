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
    public partial class frmTableDetail : Form
    {
        public frmTableDetail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            new frmCheckout().ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }
        void OpenFrmCheckout(object obj)
        {
            Application.Run(new frmCheckout());
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
    }
}
