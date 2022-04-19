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

                    btnTablec.NumericalOrder(k);
                    k++;
                    btnTables.Add(btnTablec);
                    this.panel1.Controls.Add(btnTablec);
                }
                   
            }
        }
    }
}
