using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace BUS
{
    public class TableBUS
    {
        TableDAO tableDAO = new TableDAO();
        Table table = new Table();
        public DataTable getTables()
        {
            return tableDAO.getTables();
        }
        public bool isNewOrder(int tableID)
        {
            return tableDAO.isNewOrder(tableID);
        }
        public DataTable getTables(string location)
        {
            if (location.Equals("Khu A (VIP)"))
            {
                location = "A";
            }
            else if (location.Equals("Khu B"))
            {
                location = "B";
            }
            else if (location.Equals("Khu C"))
            {
                location = "C";
            }
            else if (location.Equals("Khu D"))
            {
                location = "D";
            }
            return tableDAO.getTables(location);
        }
        public int getStatus(string tableID)
        {
            return tableDAO.getStatus(tableID);
        }
        public void updateStatus(string stateString, string tableID)
        {
            int stateINT = checkState(stateString);
            tableDAO.updateStatus(stateINT, tableID);// int - string
        }
        public int checkState(string stateString)
        {
            int stateINT = 0;
            if (stateString.Equals("Trống"))
            {
                stateINT = 0;
            }
            else if (stateString.Equals("Đặt bàn"))
            {
                stateINT = 1;
            }
            else
            {
                stateINT = 2;
            }
            return stateINT;
        }
        public bool isVIP(string location)
        {
            if(location =="Khu A (VIP)")
            {
                return true;
            }
            return false;
        }
        public void addTables(Table table)
        {
            tableDAO.insertTables(table);
        }
        public void deleteTables(int tableID)
        {
            tableDAO.deleteTables(tableID);
        }
        public void updateTables(Table table)
        {
            tableDAO.updateTables(table);
        }
    }
}
