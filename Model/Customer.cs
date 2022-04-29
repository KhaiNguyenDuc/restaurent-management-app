using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        private int id;
        private string name;
        private string phoneNumber;
        private int point;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Point { get => point; set => point = value; }

        public Customer(int id, string name, string phoneNumber, int point)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.point = point;
        }

        public Customer(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public Customer()
        {
        }
    }
}
