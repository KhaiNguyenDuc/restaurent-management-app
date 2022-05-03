using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Order
    {
        private int id;
        private DateTime orderDate;
        private double sumToTalPrice;
        private int tableID;
        private int state;// 0: old, 1:new

        public int Id { get => id; set => id = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public double SumToTalPrice { get => sumToTalPrice; set => sumToTalPrice = value; }
        public int TableID { get => tableID; set => tableID = value; }
        public int State { get => state; set => state = value; }

        public Order(DateTime orderDate, double sumToTalPrice, int tableID, int state)
        {
            this.orderDate = orderDate;
            this.sumToTalPrice = sumToTalPrice;
            this.tableID = tableID;
            this.state = state;
        }

        public Order(int id, DateTime orderDate, double sumToTalPrice, int tableID) : this(id, orderDate)
        {
            this.sumToTalPrice = sumToTalPrice;
            this.tableID = tableID;
        }

        public Order(int id, DateTime orderDate)
        {
            this.id = id;
            this.orderDate = orderDate;
            this.sumToTalPrice = 0;
        }

        public Order()
        {
            this.sumToTalPrice = 0;
        }
    }
}
