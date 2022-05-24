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
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }
        public int selectionValue()
        {
            if (rcp.Checked)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
