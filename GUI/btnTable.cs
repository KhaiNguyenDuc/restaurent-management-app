using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class btnTable : UserControl
    {
        public static string tableName;
        public btnTable()
        {
            InitializeComponent();
        }
        public void NumericalOrder(int num)
        {
            lblNum.Text = num.ToString();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {

            tableName = lblNum.Text;
        }
    }
}
