using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class OrderFood
    {
        private int quantity;
        private double totalPrice;

        public int Quantity { get => quantity; set => quantity = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public OrderFood(int quantity)
        {
            this.quantity = quantity;
            this.totalPrice = 0;
        }

        public OrderFood()
        {
            this.totalPrice = 0;
        }
    }
}
