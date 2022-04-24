using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Order
    {
        private int id;
        private DateTime orderDate;
        private double sumToTalPrice;

        public int Id { get => id; set => id = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public double SumToTalPrice { get => sumToTalPrice; set => sumToTalPrice = value; }

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
