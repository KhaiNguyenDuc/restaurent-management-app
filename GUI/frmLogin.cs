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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( txtUserName.Text == "a" && txtPassword.Text == "a")
            {
                this.Close();
                Thread thread = new Thread( OpenFrmAdminFood );
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }    
            else
            {
                this.Close();
                Thread thread = new Thread(OpenFrmTable);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void OpenFrmAdminFood(object obj)
        {
            Application.Run(new frmAdminFood());
        }
        private void OpenFrmTable(object obj)
        {
            Application.Run(new frmTable());
        }
        private void OpenFrmRegister(object obj)
        {
            
            Application.Run(new frmRegister());
            
        }
    }
}
