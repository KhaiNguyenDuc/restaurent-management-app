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
    public partial class frmAnalysis : Form
    {
        AnalysisBUS analysisBUS = new AnalysisBUS();
        public frmAnalysis()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 1", 100000);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 2", 300000);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 3", 250000);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 4", 90000);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 5", 130000);
            /*Dictionary<String, String> revenue = analysisBUS.getRevenue();
            foreach (KeyValuePair<string, string> item in revenue)
            {
                chart1.Series["Doanh thu"].Points.AddXY(item.Key, item.Value);

            }*/
            chart1.Series["Chi phí"].Points.AddXY("Tháng 1", 700000);
            chart1.Series["Chi phí"].Points.AddXY("Tháng 2", 300000);
            chart1.Series["Chi phí"].Points.AddXY("Tháng 3", 500000);
            chart1.Series["Chi phí"].Points.AddXY("Tháng 4", 200000);
            chart1.Series["Chi phí"].Points.AddXY("Tháng 5", 100000);
            /*Dictionary<String, String> cost = analysisBUS.getCost();
            foreach (KeyValuePair<string, string> item in cost)
            {
                chart1.Series["Chi phí"].Points.AddXY(item.Key, item.Value);

            }*/

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Silver;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Silver;
            chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Silver;
            chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Silver;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(1, 33, 43, 52);
            chart1.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Blue;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Silver;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Silver;
            chart1.Legends[0].BackColor = Color.FromArgb(1, 33, 43, 52);
            chart1.Legends[0].ForeColor = Color.White;
            chart1.Titles.Add("Biểu đồ doanh thu và chi phí");
            chart1.Titles[0].ForeColor = Color.White;
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 12);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = true;
            chart1.Series["Doanh thu"].Enabled = true;
            chart1.Series["Chi phí"].IsVisibleInLegend = true;
            chart1.Series["Chi phí"].Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["Chi phí"].IsVisibleInLegend = false;
            chart1.Series["Chi phí"].Enabled = false;
            chart1.Series["Doanh thu"].IsVisibleInLegend = true;
            chart1.Series["Doanh thu"].Enabled = true;
            try
            {
                chart1.Titles.RemoveAt(0);
            }
            catch (Exception)
            {


            }

            chart1.Titles.Add("Biểu đồ doanh thu");
            chart1.Titles[0].ForeColor = Color.White;
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 12);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = false;
            chart1.Series["Doanh thu"].Enabled = false;
            chart1.Series["Chi phí"].IsVisibleInLegend = true;
            chart1.Series["Chi phí"].Enabled = true;
            chart1.Titles.RemoveAt(0);
            chart1.Titles.Add("Biểu đồ chi phí");
            chart1.Titles[0].ForeColor = Color.White;
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 12);
        }

        private void button6_Click(object sender, EventArgs e)
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
    }
}
