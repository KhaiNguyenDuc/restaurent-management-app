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
using ClosedXML.Excel;

namespace GUI
{
    public partial class frmReport : Form
    {
        AnalysisBUS analysisBUS = new AnalysisBUS();
        public frmReport()
        {

            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            Dictionary<string, string> dictionary = analysisBUS.getRevenue();
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Val", typeof(string));

            foreach (var item in dictionary)
            {
                DataRow dr = dt.NewRow();
                dr["Key"] = item.Key;
                dr["Val"] = item.Value;
                dt.Rows.Add(dr);
            }
            this.dtgvMoney.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAnalysis);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmAnalysis()
        {
            Application.Run(new frmAnalysis());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmReport);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmReport(Object obj)
        {
            Application.Run(new frmReport());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = analysisBUS.getCost();
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Val", typeof(string));

            foreach (var item in dictionary)
            {
                DataRow dr = dt.NewRow();
                dr["Key"] = item.Key;
                dr["Val"] = item.Value;
                dt.Rows.Add(dr);
            }
            this.dtgvMoney.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSelect frm = new frmSelect();
            frm.Show();
            int value = frm.selectionValue();
            if (value == 1)
            {
                XLWorkbook wb = new XLWorkbook();
                DataTable dt = DicToDatatable(analysisBUS.getRevenue());
                wb.Worksheets.Add(dt, "DoanhThu");
            }
            else
            {
                XLWorkbook wb = new XLWorkbook();
                DataTable dt = DicToDatatable(analysisBUS.getCost());
                wb.Worksheets.Add(dt, "ChiPhi");
            }
        }
        DataTable DicToDatatable(Dictionary<string, string> dictionary)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Val", typeof(string));

            foreach (var item in dictionary)
            {
                DataRow dr = dt.NewRow();
                dr["Key"] = item.Key;
                dr["Val"] = item.Value;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminFood);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmAdminFood()
        {
            Application.Run(new frmAdminFood());
        }
    }
}
