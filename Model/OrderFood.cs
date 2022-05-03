using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class OrderFood
    {
        private int foodID;
        private int orderID;
        private int quantity;
        private double totalPrice;
        private string state;
        public int Quantity { get => quantity; set => quantity = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
       
        public int OrderID { get => orderID; set => orderID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public string State { get => state; set => state = value; }

        public OrderFood(int foodID, int orderID, int quantity, double totalPrice, string state) : this(foodID, orderID, quantity, totalPrice)
        {
            this.state = state;
        }

        public OrderFood(int tableID, int orderID, int quantity, double totalPrice) : this(tableID)
        {
            this.orderID = orderID;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }

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
