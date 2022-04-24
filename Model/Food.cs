using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Food
    {
        private int id;
        private string name;
        private double price;
        private int type;// 0: food, 1: drink
        private string image;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public string Image { get => image; set => image = value; }
        public int Id { get => id; set => id = value; }
        public int Type { get => type; set => type = value; }

        public Food(int id, string name, double price, int type, string image)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
            this.image = image;
        }

        public Food()
        {
        }
    }
}
