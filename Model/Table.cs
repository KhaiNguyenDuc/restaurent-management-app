using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Table
    {
        private int id;
        private string tableNumber;
        private string type;
        private string state;
        public int Id { get => id; set => id = value; }
        public string TableNumber { get => tableNumber; set => tableNumber = value; }
        public string Type { get => type; set => type = value; }
        public string State { get => state; set => state = value; }

        public Table(int id, string tableNumber, string type, string state)
        {
            this.id = id;
            this.tableNumber = tableNumber;
            this.type = type;
            this.state = state;
        }

        public Table()
        {
        }
    }
}
