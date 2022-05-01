using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Account
    {
        private int id;
        private string username;
        private string password;
        private int type; // 0: admin, 1: staff
        private int adminID;
        public Account()
        {
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        
        public int Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }
        public int AdminID { get => adminID; set => adminID = value; }

        public Account(int id, string username, string password, int type)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public Account(int id, string username, string password, int type, int adminID) : this(id, username, password, type)
        {
            this.adminID = adminID;
        }

        public Account(string username, string password, int type)
        {
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
