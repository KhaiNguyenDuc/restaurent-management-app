using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class AnalysisBUS
    {
        AnalysisDAO analysisDAO = new AnalysisDAO();
        public double getSumSalary()
        {
            DataTable data = new DataTable();
            data = analysisDAO.getSumSalary();
            double sum = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(data.Rows[i]["salary"]);
            }
            return sum;
        }
        public Double getIngredientsPrice()
        {
            DataTable data = new DataTable();
            data = analysisDAO.getIngredientsPrice();
            double sum = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(data.Rows[i]["price"]);
            }
            return sum;
        }
        public Dictionary<String, String> getCost()
        {
            Dictionary<String, String> cost = new Dictionary<string, string>();
            double salary = getSumSalary();
            double price = getIngredientsPrice();
            Random random = new Random();
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                string key = "Tháng " + i.ToString();
                string value = (salary + 10000 * random.Next(i, i + 10) + price - 10000 * random.Next(i - 10, i)).ToString();
                cost.Add(key, value);
                //Console.WriteLine("salary: " + salary + " price:" + price + " value: " + value+"month: " + DateTime.Now.Month);
            }
            return cost;
        }
        public Dictionary<String, String> getOrderMoney()
        {
            DataTable data = new DataTable();
            data = analysisDAO.getOrder();
            Dictionary<String, String> money = new Dictionary<string, string>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DateTime dateTime = new DateTime();
                dateTime = Convert.ToDateTime(data.Rows[i]["order_date"]);
                string key = dateTime.Month.ToString();
                string value = data.Rows[i]["sum_total"].ToString();
                money.Add(key, value);
            }
            return money;
        }
        public Dictionary<String, String> getRevenue()
        {
            Dictionary<String, String> money = getOrderMoney();
            Dictionary<String, String> revenue = new Dictionary<string, string>();
            int i = 1;
            /*while (i <= DateTime.Now.Month)
            {
                if (i == money) { } ;
            }*/
            double sum = 0;
            foreach (KeyValuePair<string, string> item in money)
            {
                if (i.ToString().Equals(item.Key))
                {
                    sum = sum + Convert.ToDouble(item.Value);
                }
                else
                {
                    revenue.Add(i.ToString(), sum.ToString());
                    i++;
                }
            }
            return revenue;
        }
    }
}
