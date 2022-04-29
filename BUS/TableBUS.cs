using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class TableBUS
    {
        TableDAO table = new TableDAO();
        public DataTable getTables()
        {
            return table.getTables();
        }
        public int getStatus(string tableID)
        {
            return table.getStatus(tableID);
        }
    }
}
