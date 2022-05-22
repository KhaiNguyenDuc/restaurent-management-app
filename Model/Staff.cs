using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Staff
    {
        private int iD;
        private string name;
        private int gender; // 0: Nam, 1: Nữ
        private DateTime birthday;
        private string address;
        private string phoneNumber;
        private double salary;
        private string path;
        private int accountID;
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        
        public double Salary { get => salary; set => salary = value; }
      
        public int AccountID { get => accountID; set => accountID = value; }
        public string Path { get => path; set => path = value; }
        public int Gender { get => gender; set => gender = value; }

        public Staff(int iD, string name, int gender, DateTime birthday, string address, string phoneNumber, double salary, string path, int accountID)
        {
            this.iD = iD;
            this.name = name;
            this.Gender = gender;
            this.birthday = birthday;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.salary = salary;
            this.path = path;
            this.accountID = accountID;
        }

        public Staff(string name, int gender, DateTime birthday, string address, string phoneNumber, int accountID) : this(name, gender, birthday, address, phoneNumber)
        {
            this.accountID = accountID;
        }

        public Staff(string name, int gender, DateTime birthday, string address, string phoneNumber)
        {
            this.name = name;
            this.Gender = gender;
            this.birthday = birthday;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public Staff()
        {
        }
    }
}
