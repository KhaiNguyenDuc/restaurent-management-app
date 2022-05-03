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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCheckout_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        public void OpenFrmTableDetail()
        {
            frmTableDetail form = new frmTableDetail();
            Application.Run(form);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTableDetail);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        
    }
}
