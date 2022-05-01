using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Model
{
    public class Food
    {
        private int id;
        private string name;
        private double price;
        private int type;// 0: food, 1: drink
        private string path;
        private Image img;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public Image Img
        {
            get
            {
                if (!string.IsNullOrEmpty(Path))
                {
                    if (File.Exists(Path))
                    {
                        return Image.FromFile(Path);
                    }
                }
                return null;
            }
        }
        public int Id { get => id; set => id = value; }
        public int Type { get => type; set => type = value; }
        public string Path { get => path; set => path = value; }

        public Food(int id, string name, double price, int type, string path)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
            this.Path = path;
        }

        public Food()
        {
        }
    }
}
